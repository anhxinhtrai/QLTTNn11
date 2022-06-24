using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTN
{
    public partial class Dangnhap : Form
    {
        string acc;
        int pass;
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acc = Convert.ToString(txtB1.Text);
            pass = Convert.ToInt32(txtB2.Text);
            if (acc=="admin"&&pass==123456)
            {
                if (rdB.Checked)
                {
                    frmmain frm = new frmmain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lựa chọn sai! \nVui lòng chọn lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else if (acc=="11200056" && pass==140402)
            {
                if (rdB2.Checked)
                {
                    thuchienthi tht = new thuchienthi();
                    tht.Show();
                    this.Hide();
                }    
                else
                {
                    MessageBox.Show("Lựa chọn sai! \nVui lòng chọn lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                lbl3.Text = "Tài khoản hoặc mật khẩu không chính xác!";
            }
        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtB2.PasswordChar = (char)0;
            }
            else
            {
                txtB2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
