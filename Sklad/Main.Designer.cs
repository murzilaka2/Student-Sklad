namespace Sklad
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.Logo = new FontAwesome.Sharp.IconPictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ReloadButton = new FontAwesome.Sharp.IconButton();
            this.ChangeViewButton = new FontAwesome.Sharp.IconButton();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.IconLoading = new FontAwesome.Sharp.IconPictureBox();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AddStorageButton = new FontAwesome.Sharp.IconButton();
            this.AddButton = new FontAwesome.Sharp.IconButton();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.AdditionListButton = new FontAwesome.Sharp.IconButton();
            this.RevisionListButton = new FontAwesome.Sharp.IconButton();
            this.RemovalListButton = new FontAwesome.Sharp.IconButton();
            this.TransferListButton = new FontAwesome.Sharp.IconButton();
            this.MenuPanel.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLoading)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.DesktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.NavigationPanel);
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(195, 611);
            this.MenuPanel.TabIndex = 0;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.TransferListButton);
            this.NavigationPanel.Controls.Add(this.RemovalListButton);
            this.NavigationPanel.Controls.Add(this.RevisionListButton);
            this.NavigationPanel.Controls.Add(this.AdditionListButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 75);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.NavigationPanel.Size = new System.Drawing.Size(195, 471);
            this.NavigationPanel.TabIndex = 2;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.Logo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(195, 75);
            this.LogoPanel.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.Control;
            this.Logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Logo.IconChar = FontAwesome.Sharp.IconChar.PhoenixFramework;
            this.Logo.IconColor = System.Drawing.SystemColors.ControlText;
            this.Logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logo.IconSize = 102;
            this.Logo.Location = new System.Drawing.Point(35, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(102, 102);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.ReloadButton);
            this.HeaderPanel.Controls.Add(this.ChangeViewButton);
            this.HeaderPanel.Controls.Add(this.LogoLabel);
            this.HeaderPanel.Controls.Add(this.HideButton);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(195, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(789, 75);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // ReloadButton
            // 
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.ReloadButton.IconColor = System.Drawing.Color.Black;
            this.ReloadButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReloadButton.Location = new System.Drawing.Point(52, 19);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(42, 45);
            this.ReloadButton.TabIndex = 5;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // ChangeViewButton
            // 
            this.ChangeViewButton.FlatAppearance.BorderSize = 0;
            this.ChangeViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeViewButton.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.ChangeViewButton.IconColor = System.Drawing.Color.Black;
            this.ChangeViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChangeViewButton.Location = new System.Drawing.Point(6, 19);
            this.ChangeViewButton.Name = "ChangeViewButton";
            this.ChangeViewButton.Size = new System.Drawing.Size(42, 45);
            this.ChangeViewButton.TabIndex = 4;
            this.ChangeViewButton.UseVisualStyleBackColor = true;
            this.ChangeViewButton.Click += new System.EventHandler(this.ChangeViewButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.Location = new System.Drawing.Point(332, 18);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(97, 32);
            this.LogoLabel.TabIndex = 3;
            this.LogoLabel.Text = "Sklad";
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideButton.IconColor = System.Drawing.Color.Black;
            this.HideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideButton.Location = new System.Drawing.Point(672, 3);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(40, 42);
            this.HideButton.TabIndex = 2;
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeButton.IconColor = System.Drawing.Color.Black;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.Location = new System.Drawing.Point(709, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 42);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseButton.IconColor = System.Drawing.Color.Black;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.Location = new System.Drawing.Point(746, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 42);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgressLabel.Location = new System.Drawing.Point(332, 237);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(95, 25);
            this.ProgressLabel.TabIndex = 4;
            this.ProgressLabel.Text = "Loading";
            this.ProgressLabel.Visible = false;
            // 
            // IconLoading
            // 
            this.IconLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.IconLoading.BackColor = System.Drawing.SystemColors.Control;
            this.IconLoading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconLoading.IconChar = FontAwesome.Sharp.IconChar.BatteryEmpty;
            this.IconLoading.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconLoading.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconLoading.IconSize = 49;
            this.IconLoading.Location = new System.Drawing.Point(428, 231);
            this.IconLoading.Name = "IconLoading";
            this.IconLoading.Size = new System.Drawing.Size(49, 71);
            this.IconLoading.TabIndex = 3;
            this.IconLoading.TabStop = false;
            this.IconLoading.Visible = false;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.SearchTextBox);
            this.FooterPanel.Controls.Add(this.AddStorageButton);
            this.FooterPanel.Controls.Add(this.AddButton);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(195, 546);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(789, 65);
            this.FooterPanel.TabIndex = 2;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTextBox.Location = new System.Drawing.Point(233, 16);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "Enter keyword to search...";
            this.SearchTextBox.Size = new System.Drawing.Size(301, 26);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // AddStorageButton
            // 
            this.AddStorageButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddStorageButton.FlatAppearance.BorderSize = 0;
            this.AddStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStorageButton.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.AddStorageButton.IconColor = System.Drawing.Color.Black;
            this.AddStorageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddStorageButton.Location = new System.Drawing.Point(704, 0);
            this.AddStorageButton.Name = "AddStorageButton";
            this.AddStorageButton.Size = new System.Drawing.Size(85, 65);
            this.AddStorageButton.TabIndex = 6;
            this.AddStorageButton.UseVisualStyleBackColor = true;
            this.AddStorageButton.Click += new System.EventHandler(this.AddStorageButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddButton.IconColor = System.Drawing.Color.Black;
            this.AddButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(85, 65);
            this.AddButton.TabIndex = 0;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.AutoScroll = true;
            this.DesktopPanel.Controls.Add(this.ProgressLabel);
            this.DesktopPanel.Controls.Add(this.IconLoading);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(195, 75);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 0);
            this.DesktopPanel.Size = new System.Drawing.Size(789, 471);
            this.DesktopPanel.TabIndex = 3;
            // 
            // AdditionListButton
            // 
            this.AdditionListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdditionListButton.FlatAppearance.BorderSize = 0;
            this.AdditionListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdditionListButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditionListButton.IconChar = FontAwesome.Sharp.IconChar.Angular;
            this.AdditionListButton.IconColor = System.Drawing.Color.Black;
            this.AdditionListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AdditionListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdditionListButton.Location = new System.Drawing.Point(0, 100);
            this.AdditionListButton.Name = "AdditionListButton";
            this.AdditionListButton.Size = new System.Drawing.Size(195, 70);
            this.AdditionListButton.TabIndex = 4;
            this.AdditionListButton.Text = "   Addition";
            this.AdditionListButton.UseVisualStyleBackColor = true;
            this.AdditionListButton.Click += new System.EventHandler(this.AdditionListButton_Click);
            // 
            // RevisionListButton
            // 
            this.RevisionListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RevisionListButton.FlatAppearance.BorderSize = 0;
            this.RevisionListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevisionListButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RevisionListButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.RevisionListButton.IconColor = System.Drawing.Color.Black;
            this.RevisionListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RevisionListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RevisionListButton.Location = new System.Drawing.Point(0, 170);
            this.RevisionListButton.Name = "RevisionListButton";
            this.RevisionListButton.Size = new System.Drawing.Size(195, 70);
            this.RevisionListButton.TabIndex = 5;
            this.RevisionListButton.Text = "   Revision";
            this.RevisionListButton.UseVisualStyleBackColor = true;
            this.RevisionListButton.Click += new System.EventHandler(this.RevisionListButton_Click);
            // 
            // RemovalListButton
            // 
            this.RemovalListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemovalListButton.FlatAppearance.BorderSize = 0;
            this.RemovalListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovalListButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemovalListButton.IconChar = FontAwesome.Sharp.IconChar.DiceD6;
            this.RemovalListButton.IconColor = System.Drawing.Color.Black;
            this.RemovalListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RemovalListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemovalListButton.Location = new System.Drawing.Point(0, 240);
            this.RemovalListButton.Name = "RemovalListButton";
            this.RemovalListButton.Size = new System.Drawing.Size(195, 70);
            this.RemovalListButton.TabIndex = 6;
            this.RemovalListButton.Text = "   Removal";
            this.RemovalListButton.UseVisualStyleBackColor = true;
            this.RemovalListButton.Click += new System.EventHandler(this.RemovalListButton_Click);
            // 
            // TransferListButton
            // 
            this.TransferListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransferListButton.FlatAppearance.BorderSize = 0;
            this.TransferListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferListButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferListButton.IconChar = FontAwesome.Sharp.IconChar.Taxi;
            this.TransferListButton.IconColor = System.Drawing.Color.Black;
            this.TransferListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TransferListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransferListButton.Location = new System.Drawing.Point(0, 310);
            this.TransferListButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TransferListButton.Name = "TransferListButton";
            this.TransferListButton.Size = new System.Drawing.Size(195, 70);
            this.TransferListButton.TabIndex = 7;
            this.TransferListButton.Text = "   Transfer";
            this.TransferListButton.UseVisualStyleBackColor = true;
            this.TransferListButton.Click += new System.EventHandler(this.TransferListButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.MenuPanel.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconLoading)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.DesktopPanel.ResumeLayout(false);
            this.DesktopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Panel HeaderPanel;
        private Panel FooterPanel;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton AddButton;
        private Label LogoLabel;
        private Panel DesktopPanel;
        private FontAwesome.Sharp.IconButton AddStorageButton;
        private FontAwesome.Sharp.IconPictureBox Logo;
        private Panel LogoPanel;
        private Panel NavigationPanel;
        private TextBox SearchTextBox;
        private FontAwesome.Sharp.IconPictureBox IconLoading;
        private Label ProgressLabel;
        private FontAwesome.Sharp.IconButton ChangeViewButton;
        private FontAwesome.Sharp.IconButton ReloadButton;
        private FontAwesome.Sharp.IconButton TransferListButton;
        private FontAwesome.Sharp.IconButton RemovalListButton;
        private FontAwesome.Sharp.IconButton RevisionListButton;
        private FontAwesome.Sharp.IconButton AdditionListButton;
    }
}