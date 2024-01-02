namespace Wiko_Store.UI
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlDeaCust = new System.Windows.Forms.Panel();
            this.lblCustTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.pnlProductDetails = new System.Windows.Forms.Panel();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.txtProdSearch = new System.Windows.Forms.TextBox();
            this.lblProdSearch = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.pnlDeaCust.SuspendLayout();
            this.pnlProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Controls.Add(this.lblTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1148, 48);
            this.panelTop.TabIndex = 4;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1035, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.Transparent;
            this.lblTop.Location = new System.Drawing.Point(559, 19);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(205, 18);
            this.lblTop.TabIndex = 1;
            this.lblTop.Text = "PURCHASE and SALES";
            // 
            // pnlDeaCust
            // 
            this.pnlDeaCust.Controls.Add(this.dtpBillDate);
            this.pnlDeaCust.Controls.Add(this.txtAddress);
            this.pnlDeaCust.Controls.Add(this.txtName);
            this.pnlDeaCust.Controls.Add(this.txtContact);
            this.pnlDeaCust.Controls.Add(this.txtEmail);
            this.pnlDeaCust.Controls.Add(this.txtSearch);
            this.pnlDeaCust.Controls.Add(this.lblBillDate);
            this.pnlDeaCust.Controls.Add(this.lblAddress);
            this.pnlDeaCust.Controls.Add(this.lblContact);
            this.pnlDeaCust.Controls.Add(this.lblSearch);
            this.pnlDeaCust.Controls.Add(this.lblName);
            this.pnlDeaCust.Controls.Add(this.lblEmail);
            this.pnlDeaCust.Controls.Add(this.lblCustTitle);
            this.pnlDeaCust.Location = new System.Drawing.Point(12, 54);
            this.pnlDeaCust.Name = "pnlDeaCust";
            this.pnlDeaCust.Size = new System.Drawing.Size(1124, 123);
            this.pnlDeaCust.TabIndex = 5;
            // 
            // lblCustTitle
            // 
            this.lblCustTitle.AutoSize = true;
            this.lblCustTitle.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCustTitle.Location = new System.Drawing.Point(13, 15);
            this.lblCustTitle.Name = "lblCustTitle";
            this.lblCustTitle.Size = new System.Drawing.Size(248, 18);
            this.lblCustTitle.TabIndex = 0;
            this.lblCustTitle.Text = "Dealer and Customer Details";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(303, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(13, 50);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 16);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(303, 96);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(66, 16);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(594, 54);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 16);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(839, 54);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(68, 16);
            this.lblBillDate.TabIndex = 6;
            this.lblBillDate.Text = "Bill Date";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(97, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 22);
            this.txtSearch.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(385, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(385, 94);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(164, 22);
            this.txtContact.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(97, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 22);
            this.txtName.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(684, 48);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(138, 64);
            this.txtAddress.TabIndex = 13;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CalendarFont = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Location = new System.Drawing.Point(913, 54);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBillDate.TabIndex = 14;
            // 
            // pnlProductDetails
            // 
            this.pnlProductDetails.Controls.Add(this.txtProdName);
            this.pnlProductDetails.Controls.Add(this.lblProdName);
            this.pnlProductDetails.Controls.Add(this.txtProdSearch);
            this.pnlProductDetails.Controls.Add(this.lblProdSearch);
            this.pnlProductDetails.Controls.Add(this.lblProductDetails);
            this.pnlProductDetails.Location = new System.Drawing.Point(12, 183);
            this.pnlProductDetails.Name = "pnlProductDetails";
            this.pnlProductDetails.Size = new System.Drawing.Size(1124, 118);
            this.pnlProductDetails.TabIndex = 6;
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblProductDetails.Location = new System.Drawing.Point(13, 10);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(138, 18);
            this.lblProductDetails.TabIndex = 1;
            this.lblProductDetails.Text = "Product Details";
            // 
            // txtProdSearch
            // 
            this.txtProdSearch.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSearch.Location = new System.Drawing.Point(97, 41);
            this.txtProdSearch.Name = "txtProdSearch";
            this.txtProdSearch.Size = new System.Drawing.Size(164, 22);
            this.txtProdSearch.TabIndex = 9;
            // 
            // lblProdSearch
            // 
            this.lblProdSearch.AutoSize = true;
            this.lblProdSearch.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdSearch.Location = new System.Drawing.Point(13, 41);
            this.lblProdSearch.Name = "lblProdSearch";
            this.lblProdSearch.Size = new System.Drawing.Size(61, 16);
            this.lblProdSearch.TabIndex = 8;
            this.lblProdSearch.Text = "Search";
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(97, 85);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(164, 22);
            this.txtProdName.TabIndex = 13;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(13, 85);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(48, 16);
            this.lblProdName.TabIndex = 12;
            this.lblProdName.Text = "Name";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1148, 493);
            this.Controls.Add(this.pnlProductDetails);
            this.Controls.Add(this.pnlDeaCust);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.pnlDeaCust.ResumeLayout(false);
            this.pnlDeaCust.PerformLayout();
            this.pnlProductDetails.ResumeLayout(false);
            this.pnlProductDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlDeaCust;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCustTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Panel pnlProductDetails;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtProdSearch;
        private System.Windows.Forms.Label lblProdSearch;
    }
}