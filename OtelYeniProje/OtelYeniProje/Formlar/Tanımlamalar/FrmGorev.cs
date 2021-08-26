using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelYeniProje.Entity;
namespace OtelYeniProje.Formlar.Tanımlamalar
{
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }
        OtelDBEntities db = new OtelDBEntities();
        private void FrmGorev_Load(object sender, EventArgs e)
        {
            db.TblGorev.Load();
            bindingSource1.DataSource = db.TblGorev.Local;

            repositoryItemLookUpEditGorevDepartman.DataSource = (from x in db.TblDepartman
                                                                 select new
                                                                 {
                                                                     x.DepartmanID,
                                                                     x.DepartmanAd
                                                                 }).ToList();
            repositoryItemLookUpEditGorevDurum.DataSource = (from x in db.TblDurum
                                                             select new
                                                             {
                                                                 x.DurumID,
                                                                 x.DurumAd
                                                             }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen girdiğiniz değerleri kontrol ediniz.");
            }
        }
    }
}
