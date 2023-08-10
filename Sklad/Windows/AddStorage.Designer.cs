namespace Sklad.Windows
{
    partial class AddStorage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.TransferListButton = new FontAwesome.Sharp.IconButton();
            this.RemovalListButton = new FontAwesome.Sharp.IconButton();
            this.RevisionListButton = new FontAwesome.Sharp.IconButton();
            this.AdditionListButton = new FontAwesome.Sharp.IconButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.Logo = new FontAwesome.Sharp.IconPictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HideStorageButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeStorageButton = new FontAwesome.Sharp.IconButton();
            this.CloseStorageButton = new FontAwesome.Sharp.IconButton();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.HideProductButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeProductButton = new FontAwesome.Sharp.IconButton();
            this.CloseProductButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AddProductButton = new FontAwesome.Sharp.IconButton();
            this.BackButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.MenuPanel.TabIndex = 2;
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
            this.NavigationPanel.TabIndex = 3;
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
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.Logo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(195, 75);
            this.LogoPanel.TabIndex = 2;
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
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HideStorageButton);
            this.HeaderPanel.Controls.Add(this.MinimizeStorageButton);
            this.HeaderPanel.Controls.Add(this.CloseStorageButton);
            this.HeaderPanel.Controls.Add(this.LogoLabel);
            this.HeaderPanel.Controls.Add(this.HideProductButton);
            this.HeaderPanel.Controls.Add(this.MinimizeProductButton);
            this.HeaderPanel.Controls.Add(this.CloseProductButton);
            this.HeaderPanel.Controls.Add(this.HideButton);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(195, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(789, 75);
            this.HeaderPanel.TabIndex = 3;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // HideStorageButton
            // 
            this.HideStorageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideStorageButton.FlatAppearance.BorderSize = 0;
            this.HideStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideStorageButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideStorageButton.IconColor = System.Drawing.Color.Black;
            this.HideStorageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideStorageButton.Location = new System.Drawing.Point(671, 3);
            this.HideStorageButton.Name = "HideStorageButton";
            this.HideStorageButton.Size = new System.Drawing.Size(40, 42);
            this.HideStorageButton.TabIndex = 8;
            this.HideStorageButton.UseVisualStyleBackColor = true;
            this.HideStorageButton.Click += new System.EventHandler(this.HideStorageButton_Click);
            // 
            // MinimizeStorageButton
            // 
            this.MinimizeStorageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeStorageButton.FlatAppearance.BorderSize = 0;
            this.MinimizeStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeStorageButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeStorageButton.IconColor = System.Drawing.Color.Black;
            this.MinimizeStorageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeStorageButton.Location = new System.Drawing.Point(708, 3);
            this.MinimizeStorageButton.Name = "MinimizeStorageButton";
            this.MinimizeStorageButton.Size = new System.Drawing.Size(40, 42);
            this.MinimizeStorageButton.TabIndex = 7;
            this.MinimizeStorageButton.UseVisualStyleBackColor = true;
            this.MinimizeStorageButton.Click += new System.EventHandler(this.MinimizeStorageButton_Click);
            // 
            // CloseStorageButton
            // 
            this.CloseStorageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseStorageButton.FlatAppearance.BorderSize = 0;
            this.CloseStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseStorageButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseStorageButton.IconColor = System.Drawing.Color.Black;
            this.CloseStorageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseStorageButton.Location = new System.Drawing.Point(745, 3);
            this.CloseStorageButton.Name = "CloseStorageButton";
            this.CloseStorageButton.Size = new System.Drawing.Size(40, 42);
            this.CloseStorageButton.TabIndex = 6;
            this.CloseStorageButton.UseVisualStyleBackColor = true;
            this.CloseStorageButton.Click += new System.EventHandler(this.CloseStorageButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.Location = new System.Drawing.Point(319, 19);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(200, 32);
            this.LogoLabel.TabIndex = 4;
            this.LogoLabel.Text = "Add Storage";
            // 
            // HideProductButton
            // 
            this.HideProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideProductButton.FlatAppearance.BorderSize = 0;
            this.HideProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideProductButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideProductButton.IconColor = System.Drawing.Color.Black;
            this.HideProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideProductButton.Location = new System.Drawing.Point(1280, 3);
            this.HideProductButton.Name = "HideProductButton";
            this.HideProductButton.Size = new System.Drawing.Size(40, 42);
            this.HideProductButton.TabIndex = 5;
            this.HideProductButton.UseVisualStyleBackColor = true;
            // 
            // MinimizeProductButton
            // 
            this.MinimizeProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeProductButton.FlatAppearance.BorderSize = 0;
            this.MinimizeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeProductButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeProductButton.IconColor = System.Drawing.Color.Black;
            this.MinimizeProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeProductButton.Location = new System.Drawing.Point(1317, 3);
            this.MinimizeProductButton.Name = "MinimizeProductButton";
            this.MinimizeProductButton.Size = new System.Drawing.Size(40, 42);
            this.MinimizeProductButton.TabIndex = 4;
            this.MinimizeProductButton.UseVisualStyleBackColor = true;
            // 
            // CloseProductButton
            // 
            this.CloseProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseProductButton.FlatAppearance.BorderSize = 0;
            this.CloseProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseProductButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseProductButton.IconColor = System.Drawing.Color.Black;
            this.CloseProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseProductButton.Location = new System.Drawing.Point(1354, 3);
            this.CloseProductButton.Name = "CloseProductButton";
            this.CloseProductButton.Size = new System.Drawing.Size(40, 42);
            this.CloseProductButton.TabIndex = 3;
            this.CloseProductButton.UseVisualStyleBackColor = true;
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideButton.IconColor = System.Drawing.Color.Black;
            this.HideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideButton.Location = new System.Drawing.Point(1890, 3);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(40, 42);
            this.HideButton.TabIndex = 2;
            this.HideButton.UseVisualStyleBackColor = true;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeButton.IconColor = System.Drawing.Color.Black;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.Location = new System.Drawing.Point(1927, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 42);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseButton.IconColor = System.Drawing.Color.Black;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.Location = new System.Drawing.Point(1964, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 42);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.ErrorLabel);
            this.FooterPanel.Controls.Add(this.AddProductButton);
            this.FooterPanel.Controls.Add(this.BackButton);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(195, 546);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(789, 65);
            this.FooterPanel.TabIndex = 4;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.Location = new System.Drawing.Point(342, 18);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(161, 23);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "Input all Fields!";
            this.ErrorLabel.Visible = false;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddProductButton.IconColor = System.Drawing.Color.Black;
            this.AddProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddProductButton.Location = new System.Drawing.Point(0, 0);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(85, 65);
            this.AddProductButton.TabIndex = 3;
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.BackButton.IconColor = System.Drawing.Color.Black;
            this.BackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackButton.Location = new System.Drawing.Point(704, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 65);
            this.BackButton.TabIndex = 2;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NameTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(195, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 68);
            this.panel2.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(191, 16);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(320, 31);
            this.NameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AddressTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(195, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(789, 68);
            this.panel4.TabIndex = 9;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressTextBox.Location = new System.Drawing.Point(191, 22);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(320, 31);
            this.AddressTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address:";
            // 
            // AddStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "AddStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddStorage";
            this.Resize += new System.EventHandler(this.AddStorage_Resize);
            this.MenuPanel.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Panel HeaderPanel;
        private Label LogoLabel;
        private FontAwesome.Sharp.IconButton HideProductButton;
        private FontAwesome.Sharp.IconButton MinimizeProductButton;
        private FontAwesome.Sharp.IconButton CloseProductButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton HideStorageButton;
        private FontAwesome.Sharp.IconButton MinimizeStorageButton;
        private FontAwesome.Sharp.IconButton CloseStorageButton;
        private Panel FooterPanel;
        private Label ErrorLabel;
        private FontAwesome.Sharp.IconButton AddProductButton;
        private FontAwesome.Sharp.IconButton BackButton;
        private Panel panel2;
        private TextBox NameTextBox;
        private Label label2;
        private Panel panel4;
        private TextBox AddressTextBox;
        private Label label3;
        private Panel LogoPanel;
        private FontAwesome.Sharp.IconPictureBox Logo;
        private Panel NavigationPanel;
        private FontAwesome.Sharp.IconButton TransferListButton;
        private FontAwesome.Sharp.IconButton RemovalListButton;
        private FontAwesome.Sharp.IconButton RevisionListButton;
        private FontAwesome.Sharp.IconButton AdditionListButton;
    }
}