using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelYeniProje.Formlar.Tanımlamalar;
namespace OtelYeniProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDurumTanımlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDurum fr = new FrmDurum();
            fr.Show();
        }

        private void btnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBirim fr = new FrmBirim();
            fr.Show();
        }


        //DEPARTMAN TANIMLARI BUTONU
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepartman fr = new FrmDepartman();
            fr.Show();
        }

        private void btnGorevTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGorev fr = new FrmGorev();
            fr.Show();
        }

        private void btnKasaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGorev fr = new FrmGorev();
            fr.Show();
        }
    }
}
