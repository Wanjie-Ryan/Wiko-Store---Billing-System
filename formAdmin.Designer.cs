namespace Wiko_Store
{
    partial class Form1
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblAppFname = new System.Windows.Forms.Label();
            this.lblSubheading = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Teal;
            this.panelFooter.Controls.Add(this.lblFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 448);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1151, 59);
            this.panelFooter.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Black Ops One", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFooter.Location = new System.Drawing.Point(665, 30);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(238, 20);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Developed By: Wanjie Ryan";
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1151, 24);
            this.menuStripTop.TabIndex = 1;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Black Ops One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 16);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User:";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Black Ops One", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.Location = new System.Drawing.Point(63, 35);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(141, 19);
            this.lblLoggedInUser.TabIndex = 3;
            this.lblLoggedInUser.Text = "Shalom Brother";
            // 
            // lblAppFname
            // 
            this.lblAppFname.AutoSize = true;
            this.lblAppFname.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFname.Location = new System.Drawing.Point(665, 246);
            this.lblAppFname.Name = "lblAppFname";
            this.lblAppFname.Size = new System.Drawing.Size(156, 22);
            this.lblAppFname.TabIndex = 4;
            this.lblAppFname.Text = "Salam Stores";
            // 
            // lblSubheading
            // 
            this.lblSubheading.AutoSize = true;
            this.lblSubheading.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubheading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubheading.Location = new System.Drawing.Point(610, 280);
            this.lblSubheading.Name = "lblSubheading";
            this.lblSubheading.Size = new System.Drawing.Size(290, 15);
            this.lblSubheading.TabIndex = 5;
            this.lblSubheading.Text = "Billing And Inventory Management System.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 507);
            this.Controls.Add(this.lblSubheading);
            this.Controls.Add(this.lblAppFname);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblAppFname;
        private System.Windows.Forms.Label lblSubheading;
    }
}

