using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIZLICENCE;

namespace TIMS.FORMS
{
    public partial class frmLicenceRequest : Form
    {
        string FingerPrintEncrypted = string.Empty;
        public frmLicenceRequest()
        {
            InitializeComponent();
        }

        private void frmLicenceRequest_Load(object sender, EventArgs e)
        {
            LicenceInfo licenceInfo = new LicenceInfo();
            FingerPrintEncrypted = licenceInfo.GetMachineInfoEncrypted();
            txtProductID.Text = licenceInfo.GetMachineInfo();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LicenceInfo licenceInfo = new LicenceInfo();

            licenceInfo.WriteTextToFile(@"C:\Users\Public\Downloads", "licence.txt", FingerPrintEncrypted);

            licenceInfo.OpenFolder(@"C:\Users\Public\Downloads");

            this.Close();
        }
    }
}
