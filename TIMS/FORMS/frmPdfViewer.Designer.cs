namespace TIMS.FORMS
{
    partial class frmPdfViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPdfViewer));
            this.axAcroPDFViewer = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDFViewer
            // 
            this.axAcroPDFViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDFViewer.Enabled = true;
            this.axAcroPDFViewer.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDFViewer.Name = "axAcroPDFViewer";
            this.axAcroPDFViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFViewer.OcxState")));
            this.axAcroPDFViewer.Size = new System.Drawing.Size(800, 450);
            this.axAcroPDFViewer.TabIndex = 0;
            // 
            // frmPdfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axAcroPDFViewer);
            this.Name = "frmPdfViewer";
            this.Text = "PDF Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxAcroPDFLib.AxAcroPDF axAcroPDFViewer;
    }
}