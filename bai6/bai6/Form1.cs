using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace bai6
{
    public partial class frmTapLuyen : Form
    {
        private SoundPlayer choiNhac;
        public frmTapLuyen()
        {
            InitializeComponent();
            choiNhac = new SoundPlayer("Lệ Lưu Ly.wav");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (cc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (picHaTa.Visible == false)
                btnClick.Text = txtName.Text + " ơi, Click hạ tạ đi!";
            else
                btnClick.Text = txtName.Text + " ơi, Click nâng tạ đi!";
        }

        private void frmTapLuyen_Load(object sender, EventArgs e)
        {
            picNangTa.Visible = true;
            picHaTa.Visible = false;
        }
        int count = 1;
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (picHaTa.Visible == false)
            {
                picHaTa.Visible = true;
                picNangTa.Visible = false;
                btnClick.Text = btnClick.Text.Replace("hạ", "nâng");
                lblCount.Text = count.ToString();
                count++;
                if (count == 11)
                {
                    DialogResult cc2 = MessageBox.Show("Sếp khỏe quá, được 10 cái rồi, có muốn hiệp nữa không sếp?",
                        "Notice",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (cc2 == DialogResult.Yes)
                    {
                        count = 1;
                    }
                    else
                        Close();
                }
            }
            else
            {
                picHaTa.Visible = false;
                picNangTa.Visible = true;
                btnClick.Text = btnClick.Text.Replace("nâng", "hạ");
            }
        }  
        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked == true)
                choiNhac.Play();
            else
                choiNhac.Stop();
        }
        private void lblCount_Click(object sender, EventArgs e)
        {

        }
        private void btnClose2_Click(object sender, EventArgs e)
        {
            DialogResult cc2 =  MessageBox.Show("Có muốn thoát k?", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if ( cc2 == DialogResult.OK)
            {
                Close();
            }
            
        }
    }
}
