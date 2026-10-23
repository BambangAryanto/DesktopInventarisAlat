using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace DesktopInventarisAlat
{
    public partial class FormReport : Form
    {
        private string reportfilename;

        public FormReport() : this ("Laporan Peminjaman.rpt")
        {

        }

        public FormReport(string filename)
        {
            InitializeComponent();
            this.reportfilename = filename;
            this.Load += FormReport_Load;
        }

        public FormReport(ReportDocument rpt)
        {
            InitializeComponent();
            SetReport(rpt);
        }

        public void SetReport(ReportDocument rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(reportfilename))
            {
                TampilReport(reportfilename);
            }
        }

        public void  TampilReport(string namafile)
        {
            try
            {
                string reportPath = Path.Combine(Application.StartupPath, namafile);
                if (!File.Exists(reportPath))
                {
                    string alternatifPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\" + namafile);
                    if (File.Exists(alternatifPath))
                    {
                        reportPath = Path.GetFullPath(alternatifPath);
                    }
                }
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("File Report Tidak Ditemukan");
                    return;
                }
                ReportDocument rpt = new ReportDocument();
                rpt.Load(reportPath);

                ConnectionInfo crConn = new ConnectionInfo();
                crConn.ServerName = "localhost";
                crConn.DatabaseName = "inventaris_alat";
                crConn.UserID = "root";
                crConn.Password = "";

                foreach (Table crTabel in rpt.Database.Tables)
                {
                    TableLogOnInfo crLogon = crTabel.LogOnInfo;
                    crLogon.ConnectionInfo = crConn;
                    crTabel.ApplyLogOnInfo(crLogon);
                }
                SetReport(rpt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Gagal Menampilkan Report Laporan : " + e.Message);
            }
        }
    }
}