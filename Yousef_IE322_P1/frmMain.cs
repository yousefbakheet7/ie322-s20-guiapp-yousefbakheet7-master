using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yousef_IE322_P1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPic01 frm = new frmPic01();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPic02 frm = new frmPic02();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }

        private void BtnMethods_Click(object sender, EventArgs e)
        {
            frmMethods frm = new frmMethods();
            frm.ShowDialog();
        }

        private void BtnClasses_Click(object sender, EventArgs e)
        {
            frmClasses frm = new frmClasses();
            frm.ShowDialog();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picLogo_IE_Click(object sender, EventArgs e)
        {

        }
    }
}
