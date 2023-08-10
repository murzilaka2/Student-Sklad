﻿namespace Sklad.PartWindows
{
    partial class Addition
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
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.BackButtonAdding = new FontAwesome.Sharp.IconButton();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.GoHomeButton = new FontAwesome.Sharp.IconButton();
            this.HideProductViewButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeProductViewButton = new FontAwesome.Sharp.IconButton();
            this.CloseProductViewButton = new FontAwesome.Sharp.IconButton();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.HideButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.CloseButton = new FontAwesome.Sharp.IconButton();
            this.Logo = new FontAwesome.Sharp.IconPictureBox();
            this.RevisionListButton = new FontAwesome.Sharp.IconButton();
            this.AdditionListButton = new FontAwesome.Sharp.IconButton();
            this.TransferListButton = new FontAwesome.Sharp.IconButton();
            this.RemovalListButton = new FontAwesome.Sharp.IconButton();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.AdditionDesktopPanel = new System.Windows.Forms.Panel();
            this.AdditionDataGrid = new System.Windows.Forms.DataGridView();
            this.FooterPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.DesktopPanel.SuspendLayout();
            this.AdditionDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.BackButtonAdding);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(195, 546);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(789, 65);
            this.FooterPanel.TabIndex = 6;
            // 
            // BackButtonAdding
            // 
            this.BackButtonAdding.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackButtonAdding.FlatAppearance.BorderSize = 0;
            this.BackButtonAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButtonAdding.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.BackButtonAdding.IconColor = System.Drawing.Color.Black;
            this.BackButtonAdding.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackButtonAdding.Location = new System.Drawing.Point(704, 0);
            this.BackButtonAdding.Name = "BackButtonAdding";
            this.BackButtonAdding.Size = new System.Drawing.Size(85, 65);
            this.BackButtonAdding.TabIndex = 6;
            this.BackButtonAdding.UseVisualStyleBackColor = true;
            this.BackButtonAdding.Click += new System.EventHandler(this.BackButtonAdding_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.GoHomeButton);
            this.HeaderPanel.Controls.Add(this.HideProductViewButton);
            this.HeaderPanel.Controls.Add(this.MinimizeProductViewButton);
            this.HeaderPanel.Controls.Add(this.CloseProductViewButton);
            this.HeaderPanel.Controls.Add(this.LogoLabel);
            this.HeaderPanel.Controls.Add(this.HideButton);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(195, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(789, 75);
            this.HeaderPanel.TabIndex = 5;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // GoHomeButton
            // 
            this.GoHomeButton.FlatAppearance.BorderSize = 0;
            this.GoHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoHomeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.GoHomeButton.IconColor = System.Drawing.Color.Black;
            this.GoHomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GoHomeButton.Location = new System.Drawing.Point(6, 20);
            this.GoHomeButton.Name = "GoHomeButton";
            this.GoHomeButton.Size = new System.Drawing.Size(42, 45);
            this.GoHomeButton.TabIndex = 16;
            this.GoHomeButton.UseVisualStyleBackColor = true;
            this.GoHomeButton.Click += new System.EventHandler(this.GoHomeButton_Click);
            // 
            // HideProductViewButton
            // 
            this.HideProductViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideProductViewButton.FlatAppearance.BorderSize = 0;
            this.HideProductViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideProductViewButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideProductViewButton.IconColor = System.Drawing.Color.Black;
            this.HideProductViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideProductViewButton.Location = new System.Drawing.Point(670, 4);
            this.HideProductViewButton.Name = "HideProductViewButton";
            this.HideProductViewButton.Size = new System.Drawing.Size(40, 42);
            this.HideProductViewButton.TabIndex = 11;
            this.HideProductViewButton.UseVisualStyleBackColor = true;
            this.HideProductViewButton.Click += new System.EventHandler(this.HideProductViewButton_Click);
            // 
            // MinimizeProductViewButton
            // 
            this.MinimizeProductViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeProductViewButton.FlatAppearance.BorderSize = 0;
            this.MinimizeProductViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeProductViewButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.MinimizeProductViewButton.IconColor = System.Drawing.Color.Black;
            this.MinimizeProductViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeProductViewButton.Location = new System.Drawing.Point(707, 4);
            this.MinimizeProductViewButton.Name = "MinimizeProductViewButton";
            this.MinimizeProductViewButton.Size = new System.Drawing.Size(40, 42);
            this.MinimizeProductViewButton.TabIndex = 10;
            this.MinimizeProductViewButton.UseVisualStyleBackColor = true;
            this.MinimizeProductViewButton.Click += new System.EventHandler(this.MinimizeProductViewButton_Click);
            // 
            // CloseProductViewButton
            // 
            this.CloseProductViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseProductViewButton.FlatAppearance.BorderSize = 0;
            this.CloseProductViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseProductViewButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseProductViewButton.IconColor = System.Drawing.Color.Black;
            this.CloseProductViewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseProductViewButton.Location = new System.Drawing.Point(744, 4);
            this.CloseProductViewButton.Name = "CloseProductViewButton";
            this.CloseProductViewButton.Size = new System.Drawing.Size(40, 42);
            this.CloseProductViewButton.TabIndex = 9;
            this.CloseProductViewButton.UseVisualStyleBackColor = true;
            this.CloseProductViewButton.Click += new System.EventHandler(this.CloseProductViewButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.Location = new System.Drawing.Point(304, 19);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(141, 32);
            this.LogoLabel.TabIndex = 3;
            this.LogoLabel.Text = "Addition";
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideButton.IconColor = System.Drawing.Color.Black;
            this.HideButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideButton.Location = new System.Drawing.Point(1272, 3);
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
            this.MinimizeButton.Location = new System.Drawing.Point(1309, 3);
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
            this.CloseButton.Location = new System.Drawing.Point(1346, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 42);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
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
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.NavigationPanel);
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(195, 611);
            this.MenuPanel.TabIndex = 4;
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
            // DesktopPanel
            // 
            this.DesktopPanel.AutoScroll = true;
            this.DesktopPanel.Controls.Add(this.AdditionDesktopPanel);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 0);
            this.DesktopPanel.Size = new System.Drawing.Size(984, 611);
            this.DesktopPanel.TabIndex = 7;
            // 
            // AdditionDesktopPanel
            // 
            this.AdditionDesktopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionDesktopPanel.Controls.Add(this.AdditionDataGrid);
            this.AdditionDesktopPanel.Location = new System.Drawing.Point(196, 75);
            this.AdditionDesktopPanel.Name = "AdditionDesktopPanel";
            this.AdditionDesktopPanel.Size = new System.Drawing.Size(788, 471);
            this.AdditionDesktopPanel.TabIndex = 0;
            // 
            // AdditionDataGrid
            // 
            this.AdditionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdditionDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdditionDataGrid.Location = new System.Drawing.Point(0, 0);
            this.AdditionDataGrid.Name = "AdditionDataGrid";
            this.AdditionDataGrid.RowTemplate.Height = 25;
            this.AdditionDataGrid.Size = new System.Drawing.Size(788, 471);
            this.AdditionDataGrid.TabIndex = 0;
            // 
            // Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.DesktopPanel);
            this.Name = "Addition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Addition";
            this.Load += new System.EventHandler(this.Addition_Load);
            this.Resize += new System.EventHandler(this.Addition_Resize);
            this.FooterPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.DesktopPanel.ResumeLayout(false);
            this.AdditionDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdditionDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel FooterPanel;
        private FontAwesome.Sharp.IconButton BackButtonAdding;
        private Panel HeaderPanel;
        private Label LogoLabel;
        private FontAwesome.Sharp.IconButton HideButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton CloseButton;
        private FontAwesome.Sharp.IconPictureBox Logo;
        private FontAwesome.Sharp.IconButton RevisionListButton;
        private FontAwesome.Sharp.IconButton AdditionListButton;
        private FontAwesome.Sharp.IconButton TransferListButton;
        private FontAwesome.Sharp.IconButton RemovalListButton;
        private Panel NavigationPanel;
        private Panel MenuPanel;
        private Panel LogoPanel;
        private Panel DesktopPanel;
        private FontAwesome.Sharp.IconButton HideProductViewButton;
        private FontAwesome.Sharp.IconButton MinimizeProductViewButton;
        private FontAwesome.Sharp.IconButton CloseProductViewButton;
        private FontAwesome.Sharp.IconButton GoHomeButton;
        private Panel AdditionDesktopPanel;
        private DataGridView AdditionDataGrid;
    }
}