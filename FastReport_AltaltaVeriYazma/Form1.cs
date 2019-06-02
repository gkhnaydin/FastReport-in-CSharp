using System;
using System.IO;
using System.Windows.Forms;

namespace FastReport_AltaltaVeriYazma
{
    public partial class FastReport_Form : Form
    {
        private FastReport.Report report1;

        public FastReport_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report1 = new FastReport.Report();
            report1.Load(Path.Combine(@"AltAltaVeriYazma.frx"));


            var kisi = new Kisi();
            var kisiList = kisi.getKisiList();

            foreach (var data in kisiList)
            {
                var rowadaparsel = dataSet1.Tables["Kisi"].NewRow();

                rowadaparsel["No"] = data.No;
                rowadaparsel["Ad"] = data.Ad;
                rowadaparsel["Soyad"] = data.Soyad;
                rowadaparsel["TC"] = data.TC;
                dataSet1.Tables["Kisi"].Rows.Add(rowadaparsel);
            }

            report1.RegisterData(dataSet1.Tables["Kisi"], "Kisi");
            report1.GetDataSource("Kisi").Enabled = true;
            (report1.Report.FindObject("Data1") as FastReport.DataBand).DataSource = report1.GetDataSource("Kisi");

            report1.Show();
        }
    }
}
