namespace Sklad.Components
{
    partial class Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.TransferListButton = new FontAwesome.Sharp.IconButton();
            this.RemovalListButton = new FontAwesome.Sharp.IconButton();
            this.RevisionListButton = new FontAwesome.Sharp.IconButton();
            this.AdditionListButton = new FontAwesome.Sharp.IconButton();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.TransferListButton);
            this.NavigationPanel.Controls.Add(this.RemovalListButton);
            this.NavigationPanel.Controls.Add(this.RevisionListButton);
            this.NavigationPanel.Controls.Add(this.AdditionListButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.NavigationPanel.Size = new System.Drawing.Size(310, 471);
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
            this.TransferListButton.Size = new System.Drawing.Size(310, 70);
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
            this.RemovalListButton.Size = new System.Drawing.Size(310, 70);
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
            this.RevisionListButton.Size = new System.Drawing.Size(310, 70);
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
            this.AdditionListButton.Size = new System.Drawing.Size(310, 70);
            this.AdditionListButton.TabIndex = 4;
            this.AdditionListButton.Text = "   Addition";
            this.AdditionListButton.UseVisualStyleBackColor = true;
            this.AdditionListButton.Click += new System.EventHandler(this.AdditionListButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NavigationPanel);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(310, 473);
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel NavigationPanel;
        private FontAwesome.Sharp.IconButton TransferListButton;
        private FontAwesome.Sharp.IconButton RemovalListButton;
        private FontAwesome.Sharp.IconButton RevisionListButton;
        private FontAwesome.Sharp.IconButton AdditionListButton;
    }
}
