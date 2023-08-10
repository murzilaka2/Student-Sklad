namespace Sklad.Windows
{
    partial class ViewStorage
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
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.EditEnableButton = new FontAwesome.Sharp.IconButton();
            this.RemoveButton = new FontAwesome.Sharp.IconButton();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SaveStorageButton = new FontAwesome.Sharp.IconButton();
            this.BackButton = new FontAwesome.Sharp.IconButton();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HideStorageViewButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeStorageViewButton = new FontAwesome.Sharp.IconButton();
            this.CloseStorageViewButton = new FontAwesome.Sharp.IconButton();
            this.HideProductViewButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeProductViewButton = new FontAwesome.Sharp.IconButton();
            this.CloseProductViewButton = new FontAwesome.Sharp.IconButton();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.HideProductButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeProductButton = new FontAwesome.Sharp.IconButton();
            this.CloseProductButton = new FontAwesome.Sharp.IconButton();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.MenuPanel.TabIndex = 3;
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
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.EditEnableButton);
            this.FooterPanel.Controls.Add(this.RemoveButton);
            this.FooterPanel.Controls.Add(this.ErrorLabel);
            this.FooterPanel.Controls.Add(this.SaveStorageButton);
            this.FooterPanel.Controls.Add(this.BackButton);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(195, 546);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(789, 65);
            this.FooterPanel.TabIndex = 5;
            // 
            // EditEnableButton
            // 
            this.EditEnableButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditEnableButton.FlatAppearance.BorderSize = 0;
            this.EditEnableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEnableButton.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.EditEnableButton.IconColor = System.Drawing.Color.Black;
            this.EditEnableButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditEnableButton.Location = new System.Drawing.Point(85, 0);
            this.EditEnableButton.Name = "EditEnableButton";
            this.EditEnableButton.Size = new System.Drawing.Size(85, 65);
            this.EditEnableButton.TabIndex = 7;
            this.EditEnableButton.UseVisualStyleBackColor = true;
            this.EditEnableButton.Click += new System.EventHandler(this.EditEnableButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.RemoveButton.IconColor = System.Drawing.Color.Black;
            this.RemoveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RemoveButton.Location = new System.Drawing.Point(619, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(85, 65);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
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
            // SaveStorageButton
            // 
            this.SaveStorageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveStorageButton.FlatAppearance.BorderSize = 0;
            this.SaveStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveStorageButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SaveStorageButton.IconColor = System.Drawing.Color.Black;
            this.SaveStorageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveStorageButton.Location = new System.Drawing.Point(0, 0);
            this.SaveStorageButton.Name = "SaveStorageButton";
            this.SaveStorageButton.Size = new System.Drawing.Size(85, 65);
            this.SaveStorageButton.TabIndex = 3;
            this.SaveStorageButton.UseVisualStyleBackColor = true;
            this.SaveStorageButton.Click += new System.EventHandler(this.SaveStorageButton_Click);
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
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HideStorageViewButton);
            this.HeaderPanel.Controls.Add(this.MinimizeStorageViewButton);
            this.HeaderPanel.Controls.Add(this.CloseStorageViewButton);
            this.HeaderPanel.Controls.Add(this.HideProductViewButton);
            this.HeaderPanel.Controls.Add(this.MinimizeProductViewButton);
            this.HeaderPanel.Controls.Add(this.CloseProductViewButton);
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
            this.HeaderPanel.TabIndex = 6;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // HideStorageViewButton
            // 
            this.HideStorageViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideStorageViewButton.FlatAppearance.BorderSize = 0;
            this.HideStorageViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideStorageViewButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideStorageViewButton.IconColor = System.Drawing.Color.Black;
            this.HideStorageViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideStorageViewButton.Location = new System.Drawing.Point(672, 3);
            this.HideStorageViewButton.Name = "HideStorageViewButton";
            this.HideStorageViewButton.Size = new System.Drawing.Size(40, 42);
            this.HideStorageViewButton.TabIndex = 11;
            this.HideStorageViewButton.UseVisualStyleBackColor = true;
            this.HideStorageViewButton.Click += new System.EventHandler(this.HideStorageViewButton_Click);
            // 
            // MinimizeStorageViewButton
            // 
            this.MinimizeStorageViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeStorageViewButton.FlatAppearance.BorderSize = 0;
            this.MinimizeStorageViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeStorageViewButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeStorageViewButton.IconColor = System.Drawing.Color.Black;
            this.MinimizeStorageViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeStorageViewButton.Location = new System.Drawing.Point(709, 3);
            this.MinimizeStorageViewButton.Name = "MinimizeStorageViewButton";
            this.MinimizeStorageViewButton.Size = new System.Drawing.Size(40, 42);
            this.MinimizeStorageViewButton.TabIndex = 10;
            this.MinimizeStorageViewButton.UseVisualStyleBackColor = true;
            this.MinimizeStorageViewButton.Click += new System.EventHandler(this.MinimizeStorageViewButton_Click);
            // 
            // CloseStorageViewButton
            // 
            this.CloseStorageViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseStorageViewButton.FlatAppearance.BorderSize = 0;
            this.CloseStorageViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseStorageViewButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseStorageViewButton.IconColor = System.Drawing.Color.Black;
            this.CloseStorageViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseStorageViewButton.Location = new System.Drawing.Point(746, 3);
            this.CloseStorageViewButton.Name = "CloseStorageViewButton";
            this.CloseStorageViewButton.Size = new System.Drawing.Size(40, 42);
            this.CloseStorageViewButton.TabIndex = 9;
            this.CloseStorageViewButton.UseVisualStyleBackColor = true;
            this.CloseStorageViewButton.Click += new System.EventHandler(this.CloseStorageViewButton_Click);
            // 
            // HideProductViewButton
            // 
            this.HideProductViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideProductViewButton.FlatAppearance.BorderSize = 0;
            this.HideProductViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideProductViewButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideProductViewButton.IconColor = System.Drawing.Color.Black;
            this.HideProductViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideProductViewButton.Location = new System.Drawing.Point(1281, 3);
            this.HideProductViewButton.Name = "HideProductViewButton";
            this.HideProductViewButton.Size = new System.Drawing.Size(40, 42);
            this.HideProductViewButton.TabIndex = 8;
            this.HideProductViewButton.UseVisualStyleBackColor = true;
            // 
            // MinimizeProductViewButton
            // 
            this.MinimizeProductViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeProductViewButton.FlatAppearance.BorderSize = 0;
            this.MinimizeProductViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeProductViewButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeProductViewButton.IconColor = System.Drawing.Color.Black;
            this.MinimizeProductViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeProductViewButton.Location = new System.Drawing.Point(1318, 3);
            this.MinimizeProductViewButton.Name = "MinimizeProductViewButton";
            this.MinimizeProductViewButton.Size = new System.Drawing.Size(40, 42);
            this.MinimizeProductViewButton.TabIndex = 7;
            this.MinimizeProductViewButton.UseVisualStyleBackColor = true;
            // 
            // CloseProductViewButton
            // 
            this.CloseProductViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseProductViewButton.FlatAppearance.BorderSize = 0;
            this.CloseProductViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseProductViewButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseProductViewButton.IconColor = System.Drawing.Color.Black;
            this.CloseProductViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseProductViewButton.Location = new System.Drawing.Point(1355, 3);
            this.CloseProductViewButton.Name = "CloseProductViewButton";
            this.CloseProductViewButton.Size = new System.Drawing.Size(40, 42);
            this.CloseProductViewButton.TabIndex = 6;
            this.CloseProductViewButton.UseVisualStyleBackColor = true;
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.Location = new System.Drawing.Point(295, 14);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(215, 32);
            this.LogoLabel.TabIndex = 4;
            this.LogoLabel.Text = "View Storage";
            // 
            // HideProductButton
            // 
            this.HideProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideProductButton.FlatAppearance.BorderSize = 0;
            this.HideProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideProductButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideProductButton.IconColor = System.Drawing.Color.Black;
            this.HideProductButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideProductButton.Location = new System.Drawing.Point(1889, 3);
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
            this.MinimizeProductButton.Location = new System.Drawing.Point(1926, 3);
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
            this.CloseProductButton.Location = new System.Drawing.Point(1963, 3);
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
            this.HideButton.Location = new System.Drawing.Point(2499, 3);
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
            this.MinimizeButton.Location = new System.Drawing.Point(2536, 3);
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
            this.CloseButton.Location = new System.Drawing.Point(2573, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 42);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
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
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(191, 16);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(320, 24);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.AddressTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(195, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 68);
            this.panel1.TabIndex = 9;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTextBox.Enabled = false;
            this.AddressTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressTextBox.Location = new System.Drawing.Point(191, 16);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(320, 24);
            this.AddressTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Address:";
            // 
            // ViewStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "ViewStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewStorage";
            this.Resize += new System.EventHandler(this.ViewStorage_Resize);
            this.MenuPanel.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Panel FooterPanel;
        private FontAwesome.Sharp.IconButton RemoveButton;
        private Label ErrorLabel;
        private FontAwesome.Sharp.IconButton SaveStorageButton;
        private FontAwesome.Sharp.IconButton BackButton;
        private Panel HeaderPanel;
        private FontAwesome.Sharp.IconButton HideProductViewButton;
        private FontAwesome.Sharp.IconButton MinimizeProductViewButton;
        private FontAwesome.Sharp.IconButton CloseProductViewButton;
        private Label LogoLabel;
        private FontAwesome.Sharp.IconButton HideProductButton;
        private FontAwesome.Sharp.IconButton MinimizeProductButton;
        private FontAwesome.Sharp.IconButton CloseProductButton;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconButton HideStorageViewButton;
        private FontAwesome.Sharp.IconButton MinimizeStorageViewButton;
        private FontAwesome.Sharp.IconButton CloseStorageViewButton;
        private Panel panel2;
        private TextBox NameTextBox;
        private Label label2;
        private Panel panel1;
        private TextBox AddressTextBox;
        private Label label1;
        private FontAwesome.Sharp.IconButton EditEnableButton;
        private Panel LogoPanel;
        private FontAwesome.Sharp.IconPictureBox Logo;
        private Panel NavigationPanel;
        private FontAwesome.Sharp.IconButton TransferListButton;
        private FontAwesome.Sharp.IconButton RemovalListButton;
        private FontAwesome.Sharp.IconButton RevisionListButton;
        private FontAwesome.Sharp.IconButton AdditionListButton;
    }
}