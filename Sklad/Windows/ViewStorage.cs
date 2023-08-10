using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad.Windows
{
    public partial class ViewStorage : Form
    {
        int borderSize = 2;
        Main main;
        Models.Storage storage;
        public ViewStorage(Main main, Models.Storage storage)
        {
            InitializeComponent();
            this.main = main;
            main.Hide();
            this.storage = storage;
            Presets();
            LoadStorage();
        }
        void LoadStorage()
        {
            NameTextBox.Text = storage.Name;
            AddressTextBox.Text = storage.Address;
        }
        void Presets()
        {
            this.MinimumSize = new Size(700, 700);
            MenuPanel.BackColor = Color.FromArgb(240, 233, 233);
            HeaderPanel.BackColor = Color.FromArgb(255, 255, 255);
            FooterPanel.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        //Премещение формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Убираем рамку формы && Позволяет изменять размеры формы вручную
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            base.WndProc(ref m);
        }
        private void SaveStorageButton_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void Update()
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text) && !string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                using (Models.ApplicationContext db = new Models.ApplicationContext())
                {
                    var editStorage = db.Storages.FirstOrDefault(e => e.Id == storage.Id);
                    if (editStorage is not null)
                    {
                        editStorage.Name = NameTextBox.Text;
                        editStorage.Address = AddressTextBox.Text;
                        db.SaveChanges();
                    }
                }
                this.DialogResult = DialogResult.OK;
                main.Top = this.Top;
                main.Left = this.Left;
                main.Size = this.Size;
                main.WindowState = this.WindowState;
                main.Show();
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            using (Models.ApplicationContext db = new Models.ApplicationContext())
            {
                var removeStorage = db.Storages.FirstOrDefault(e => e.Id == storage.Id);
                db.Storages.Remove(removeStorage!);
                db.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
            main.Top = this.Top;
            main.Left = this.Left;
            main.Size = this.Size;
            main.WindowState = this.WindowState;
            main.Show();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            main.Top = this.Top;
            main.Left = this.Left;
            main.Size = this.Size;
            main.WindowState = this.WindowState;
            main.Show();
            this.Close();
        }
        private void CloseStorageViewButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinimizeStorageViewButton_Click(object sender, EventArgs e)
        {
            this.WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Size = new Size(687, 607);
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        private void HideStorageViewButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ViewStorage_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EditEnableButton_Click(object sender, EventArgs e)
        {
            Enable_Items();
        }
        private void Enable_Items()
        {
            EditEnableButton.Enabled = false;
            SaveStorageButton.Enabled = true;
            NameTextBox.Enabled = true;
            AddressTextBox.Enabled = true;
            NameTextBox.BorderStyle = BorderStyle.Fixed3D;
            AddressTextBox.BorderStyle = BorderStyle.Fixed3D;
            NameTextBox.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;
        }

        private void AdditionListButton_Click(object sender, EventArgs e)
        {
            PartWindows.Addition additionForm = new PartWindows.Addition(this);
            additionForm.Top = this.Top;
            additionForm.Left = this.Left;
            additionForm.Size = this.Size;
            additionForm.WindowState = this.WindowState;
            additionForm.ShowDialog();
        }
        private void RevisionListButton_Click(object sender, EventArgs e)
        {
            PartWindows.Revision revisionForm = new PartWindows.Revision(this);
            revisionForm.Top = this.Top;
            revisionForm.Left = this.Left;
            revisionForm.Size = this.Size;
            revisionForm.WindowState = this.WindowState;
            revisionForm.ShowDialog();
        }
        private void RemovalListButton_Click(object sender, EventArgs e)
        {
            PartWindows.Removal removalForm = new PartWindows.Removal(this);
            removalForm.Top = this.Top;
            removalForm.Left = this.Left;
            removalForm.Size = this.Size;
            removalForm.WindowState = this.WindowState;
            removalForm.ShowDialog();
        }
        private void TransferListButton_Click(object sender, EventArgs e)
        {
            PartWindows.Transfer transferForm = new PartWindows.Transfer(this);
            transferForm.Top = this.Top;
            transferForm.Left = this.Left;
            transferForm.Size = this.Size;
            transferForm.WindowState = this.WindowState;
            transferForm.ShowDialog();
        }
    }
}
