using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Sklad
{
    // Разработать приложение Sklad, для возможности хранения товаров.
    //1. Товар (id, storageId, name, description, type, count, price, date) +
    //2. Склад (id, name, address) +
    //3. Реализовать возможность: добавление, редактирование, удаления товара. +
    //4. Ведомость (id, storageId, productId, date, description)
    //5. Вынести на панель: пункты:
    //1) Редактирование склада (по нажатию на имя склада). +
    //2) Ведомость по добавлению товара
    //3) Ведомость по редактированию товара
    //4) Ведомость по удалению товара.
    //5) Ведомость по перемещению товара.
    //5. Реализовать возможность: перемещение товара с помощью ведимости. + 
    public partial class Main : Form
    {
        int borderSize = 2;
        bool result = true, viewState = true, isLoad = false;
        public Main()
        {
            InitializeComponent();
            Presets();
        }
        private void Main_Resize(object sender, EventArgs e)
        {
            AdjustForm();
            if (isLoad && !viewState)
            {
                DesktopPanel.Controls.Clear();
                LoadProducts();
            }
        }
        void Presets()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(700, 700);
            MenuPanel.BackColor = Color.FromArgb(240, 233, 233);
            HeaderPanel.BackColor = Color.FromArgb(255, 255, 255);
            FooterPanel.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                LoadProducts();
            });
            Task task2 = Task.Run(() =>
            {
                StartProgress();
            });
            Task.Run(() =>
            {
                Task.WaitAll(task, task2);
                isLoad = true;
            });

        }
        void StopProgress()
        {
            result = false;
            this.Invoke(new EventHandler(delegate
            {
                ProgressLabel.Visible = false;
                IconLoading.Visible = false;
            }));
        }
        void StartProgress()
        {
            this.Invoke(new EventHandler(delegate
            {
                ProgressLabel.Visible = true;
                IconLoading.Visible = true;
            }));
            int count = default;
            while (result)
            {
                this.Invoke(new EventHandler(delegate
                {
                    switch (count % 3)
                    {
                        case 0: { IconLoading.IconChar = FontAwesome.Sharp.IconChar.BatteryEmpty; break; }
                        case 1: { IconLoading.IconChar = FontAwesome.Sharp.IconChar.BatteryHalf; break; }
                        case 2: { IconLoading.IconChar = FontAwesome.Sharp.IconChar.BatteryFull; break; }
                    }
                }));
                Thread.Sleep(300);
                count++;
            }
        }
        private void LoadProducts()
        {
            List<Models.Storage> storages;
            using (Models.ApplicationContext db = new Models.ApplicationContext())
            {
                storages = db.Storages.Include(x => x.Products).ToList();
            }           
            if (viewState)
            {
                foreach (Models.Storage storage in storages)
                {
                    foreach (var item in storage.Products)
                    {
                        Button button = new Button() { Text = $"{item.Name}" };
                        button.Tag = item;
                        button.Height = 50;
                        button.Font = new Font("Veranda", 16, FontStyle.Bold);
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Dock = DockStyle.Top;
                        button.Click += Button_Click;
                        this.Invoke(new EventHandler(delegate
                        {
                            DesktopPanel.Controls.Add(button);
                        }));
                    }
                    Label label = new Label()
                    {
                        Text = $"---{storage.Name}---"
                    };
                    label.FlatStyle = FlatStyle.Flat;
                    label.Dock = DockStyle.Top;
                    label.Height = 50;
                    label.Padding = new Padding();
                    label.Font = new Font("Veranda", 18, FontStyle.Bold);
                    label.Tag = storage;
                    label.MouseEnter += Label_MouseEnter;
                    label.MouseLeave += Label_MouseLeave;
                    label.Click += Label_Click;
                    this.Invoke(new EventHandler(delegate
                    {
                        DesktopPanel.Controls.Add(label);
                    }));
                }
            }
            else
            {
                int heigth = 10;
                foreach (Models.Storage storage in storages)
                {
                    Label label = new Label()
                    {
                        Text = $"---{storage.Name}---"
                    };
                    label.FlatStyle = FlatStyle.Flat;
                    label.Height = 50;
                    label.Width = 400;
                    label.Dock = DockStyle.None;
                    label.Location = new Point(5, heigth);
                    heigth += label.Height;
                    label.Padding = new Padding();
                    label.Font = new Font("Veranda", 18, FontStyle.Bold);
                    label.Tag = storage;
                    label.MouseEnter += Label_MouseEnter;
                    label.MouseLeave += Label_MouseLeave;
                    label.Click += Label_Click;
                    this.Invoke(new EventHandler(delegate
                    {
                        DesktopPanel.Controls.Add(label);
                    }));
                    int lastW = 10;
                    foreach (var item in storage.Products)
                    {
                        SizeF size;
                        Button button = new Button() { Text = $"{item.Name}" };
                        button.Location = new Point(lastW, heigth);
                        using (Graphics cg = this.CreateGraphics())
                        {
                            size = cg.MeasureString(item.Name, new Font("Veranda", 16, FontStyle.Bold));
                            size.Width += 40;
                        }
                        button.Tag = item;
                        button.Height = 50;
                        button.Width = (int)size.Width;
                        button.Font = new Font("Veranda", 16, FontStyle.Bold);
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Dock = DockStyle.None;
                        lastW += (int)size.Width;
                        if (lastW >= (DesktopPanel.Width - 200))
                        {
                            heigth += button.Height;
                            lastW = 10;
                        }
                        button.Click += Button_Click;
                        this.Invoke(new EventHandler(delegate
                        {
                            DesktopPanel.Controls.Add(button);
                        }));
                    }
                    heigth += 70;
                }
            }
            this.Invoke(new EventHandler(delegate
            {
                SearchTextBox.Text = String.Empty;
            }));
            StopProgress();
        }
        private void Label_MouseLeave(object? sender, EventArgs e)
        {
            Label label = (Label)sender!;
            label.BackColor = Color.Transparent;
        }

        private void Label_MouseEnter(object? sender, EventArgs e)
        {
            Label label = (Label)sender!;
            label.BackColor = Color.FromArgb(240, 233, 233);
        }
        private void Label_Click(object? sender, EventArgs e)
        {
            Label label = (Label)sender!;
            Models.Storage storage = (Models.Storage)label.Tag;
            Windows.ViewStorage viewStorage = new Windows.ViewStorage(this, storage);
            viewStorage.Top = this.Top;
            viewStorage.Left = this.Left;
            viewStorage.Size = this.Size;
            viewStorage.WindowState = this.WindowState;
            viewStorage.ShowDialog();
            if (viewStorage.DialogResult == DialogResult.OK)
            {
                DesktopPanel.Controls.Clear();
                Task.Run(() =>
                {
                    LoadProducts();
                });
            }
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender!;
            Models.Product product = (Models.Product)button.Tag;
            Windows.ViewProduct viewProduct = new Windows.ViewProduct(this, product);
            viewProduct.Top = this.Top;
            viewProduct.Left = this.Left;
            viewProduct.Size = this.Size;
            viewProduct.WindowState = this.WindowState;
            viewProduct.ShowDialog();
            if (viewProduct.DialogResult == DialogResult.OK)
            {
                DesktopPanel.Controls.Clear();
                Task.Run(() =>
                {
                    LoadProducts();
                });
            }
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
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Size = new Size(687, 607);
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        private void HideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Windows.AddProduct addProduct = new Windows.AddProduct(this);
            addProduct.Top = this.Top;
            addProduct.Left = this.Left;
            addProduct.Size = this.Size;
            addProduct.WindowState = this.WindowState;
            addProduct.ShowDialog();
            if (addProduct.DialogResult == DialogResult.OK)
            {
                DesktopPanel.Controls.Clear();
                Task.Run(() =>
                {
                    LoadProducts();
                });
            }
        }
        private void AddStorageButton_Click(object sender, EventArgs e)
        {
            Windows.AddStorage addStorage = new Windows.AddStorage(this);
            addStorage.Top = this.Top;
            addStorage.Left = this.Left;
            addStorage.Size = this.Size;
            addStorage.WindowState = this.WindowState;
            addStorage.ShowDialog();
            if (addStorage.DialogResult == DialogResult.OK)
            {
                DesktopPanel.Controls.Clear();
                Task.Run(() =>
                {
                    LoadProducts();
                });
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            DesktopPanel.Controls.Clear();
            if (!string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                Task.Run(() =>
                {
                    FindProductByName(SearchTextBox.Text.Trim().ToLower());
                });
            }
            else
            {
                Task.Run(() =>
                {
                    LoadProducts();
                });
            }
        }
        private void FindProductByName(string name)
        {
            List<Models.Storage> storages;
            using (Models.ApplicationContext db = new Models.ApplicationContext())
            {
                storages = db.Storages.Include(x => x.Products.Where(e => e.Name.ToLower().Contains(name))).ToList();
            }
            if (viewState)
            {
                foreach (Models.Storage storage in storages)
                {
                    foreach (var item in storage.Products)
                    {
                        Button button = new Button() { Text = $"{item.Name}" };
                        button.Tag = item;
                        button.Height = 50;
                        button.Font = new Font("Veranda", 16, FontStyle.Bold);
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Dock = DockStyle.Top;
                        button.Click += Button_Click;
                        this.Invoke(new EventHandler(delegate
                        {
                            DesktopPanel.Controls.Add(button);
                        }));
                    }
                    Label label = new Label()
                    {
                        Text = $"---{storage.Name}---"
                    };
                    label.FlatStyle = FlatStyle.Flat;
                    label.Dock = DockStyle.Top;
                    label.Height = 50;
                    label.Padding = new Padding();
                    label.Font = new Font("Veranda", 18, FontStyle.Bold);
                    label.Tag = storage;
                    label.MouseEnter += Label_MouseEnter;
                    label.MouseLeave += Label_MouseLeave;
                    label.Click += Label_Click;
                    this.Invoke(new EventHandler(delegate
                    {
                        DesktopPanel.Controls.Add(label);
                    }));
                }
            }
            else
            {
                int heigth = 10;
                foreach (Models.Storage storage in storages)
                {
                    Label label = new Label()
                    {
                        Text = $"---{storage.Name}---"
                    };
                    label.FlatStyle = FlatStyle.Flat;
                    label.Height = 50;
                    label.Width = 400;
                    label.Dock = DockStyle.None;
                    label.Location = new Point(5, heigth);
                    heigth += label.Height;
                    label.Padding = new Padding();
                    label.Font = new Font("Veranda", 18, FontStyle.Bold);
                    label.Tag = storage;
                    label.MouseEnter += Label_MouseEnter;
                    label.MouseLeave += Label_MouseLeave;
                    label.Click += Label_Click;
                    this.Invoke(new EventHandler(delegate
                    {
                        DesktopPanel.Controls.Add(label);
                    }));
                    int lastW = 10;
                    foreach (var item in storage.Products)
                    {
                        SizeF size;
                        Button button = new Button() { Text = $"{item.Name}" };
                        button.Location = new Point(lastW, heigth);
                        using (Graphics cg = this.CreateGraphics())
                        {
                            size = cg.MeasureString(item.Name, new Font("Veranda", 16, FontStyle.Bold));
                            size.Width += 40;
                        }
                        button.Tag = item;
                        button.Height = 50;
                        button.Width = (int)size.Width;
                        button.Font = new Font("Veranda", 16, FontStyle.Bold);
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Dock = DockStyle.None;
                        lastW += (int)size.Width;
                        if (lastW >= (DesktopPanel.Width - 200))
                        {
                            heigth += button.Height;
                            lastW = 10;
                        }
                        button.Click += Button_Click;
                        this.Invoke(new EventHandler(delegate
                        {
                            DesktopPanel.Controls.Add(button);
                        }));
                    }
                    heigth += 70;
                }
            }
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
        private void ReloadButton_Click(object sender, EventArgs e)
        {
            DesktopPanel.Controls.Clear();
            SearchTextBox.Text = String.Empty;
            Task.Run(() =>
            {
                LoadProducts();
            });
        }
        private void ChangeViewButton_Click(object sender, EventArgs e)
        {
            DesktopPanel.Controls.Clear();
            viewState = !viewState;
            Task.Run(() =>
            {
                LoadProducts();
            });
        }
    }
}

