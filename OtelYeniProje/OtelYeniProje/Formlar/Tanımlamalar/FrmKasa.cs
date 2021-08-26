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
using OtelYeniProje.Entity;
namespace OtelYeniProje.Formlar.Tanımlamalar
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        OtelDBEntities db = new OtelDBEntities();
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            db.TblKasa.Load();

            bindingSource1.DataSource = db.TblKasa.Local;

            repositoryItemLookUpEditKasaDurum.DataSource = (from x in db.TblDurum
                                                            select new
                                                            {
                                                                x.DurumID,
                                                                x.DurumAd
                                                            }).ToList();
        }
    }
}
