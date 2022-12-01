namespace TIMS.FORMS
{
    partial class frmRegistration
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
            this.txtGeneratedLicence = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenUpload = new System.Windows.Forms.Button();
            this.btnGenBrowse = new System.Windows.Forms.Button();
            this.lblValidDays = new System.Windows.Forms.Label();
            this.lblLicenceType = new System.Windows.Forms.Label();
            this.lblPaructId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtGeneratedLicence
            // 
            this.txtGeneratedLicence.Location = new System.Drawing.Point(133, 37);
            this.txtGeneratedLicence.Name = "txtGeneratedLicence";
            this.txtGeneratedLicence.ReadOnly = true;
            this.txtGeneratedLicence.Size = new System.Drawing.Size(516, 26);
            this.txtGeneratedLicence.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "File Path:.";
            // 
            // btnGenUpload
            // 
            this.btnGenUpload.Location = new System.Drawing.Point(133, 80);
            this.btnGenUpload.Name = "btnGenUpload";
            this.btnGenUpload.Size = new System.Drawing.Size(121, 26);
            this.btnGenUpload.TabIndex = 14;
            this.btnGenUpload.Text = "Upload";
            this.btnGenUpload.UseVisualStyleBackColor = true;
            this.btnGenUpload.Click += new System.EventHandler(this.btnGenUpload_Click);
            // 
            // btnGenBrowse
            // 
            this.btnGenBrowse.Location = new System.Drawing.Point(685, 37);
            this.btnGenBrowse.Name = "btnGenBrowse";
            this.btnGenBrowse.Size = new System.Drawing.Size(121, 26);
            this.btnGenBrowse.TabIndex = 13;
            this.btnGenBrowse.Text = "Browse";
            this.btnGenBrowse.UseVisualStyleBackColor = true;
            this.btnGenBrowse.Click += new System.EventHandler(this.btnGenBrowse_Click);
            // 
            // lblValidDays
            // 
            this.lblValidDays.AutoSize = true;
            this.lblValidDays.Location = new System.Drawing.Point(254, 180);
            this.lblValidDays.Name = "lblValidDays";
            this.lblValidDays.Size = new System.Drawing.Size(0, 20);
            this.lblValidDays.TabIndex = 24;
            // 
            // lblLicenceType
            // 
            this.lblLicenceType.AutoSize = true;
            this.lblLicenceType.Location = new System.Drawing.Point(254, 150);
            this.lblLicenceType.Name = "lblLicenceType";
            this.lblLicenceType.Size = new System.Drawing.Size(0, 20);
            this.lblLicenceType.TabIndex = 23;
            // 
            // lblPaructId
            // 
            this.lblPaructId.AutoSize = true;
            this.lblPaructId.Location = new System.Drawing.Point(254, 116);
            this.lblPaructId.Name = "lblPaructId";
            this.lblPaructId.Size = new System.Drawing.Size(0, 20);
            this.lblPaructId.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Days:.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Licence Type:.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Product ID:.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(725, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 26);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 225);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblValidDays);
            this.Controls.Add(this.lblLicenceType);
            this.Controls.Add(this.lblPaructId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGenUpload);
            this.Controls.Add(this.btnGenBrowse);
            this.Controls.Add(this.txtGeneratedLicence);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGeneratedLicence;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenUpload;
        private System.Windows.Forms.Button btnGenBrowse;
        private System.Windows.Forms.Label lblValidDays;
        private System.Windows.Forms.Label lblLicenceType;
        private System.Windows.Forms.Label lblPaructId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}