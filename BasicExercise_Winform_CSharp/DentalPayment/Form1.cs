using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalPayment
{
    public partial class Form1 : Form
    {
        int caoVoi = 100000, 
            tayTrang = 1500000, 
            tramRang = 200000, 
            nhoRang = 150000;

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxTotal.Text = "";

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if(textBoxName.TextLength > 0)
            {
                buttonTinhTien.Enabled = true;
                buttonXoa.Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
           
                buttonTinhTien.Enabled = false;
                buttonXoa.Enabled = false;
        }

        private void buttonTinhTien_Click(object sender, EventArgs e)
        {
            labelCV.Text = caoVoi.ToString();

            int total = 0;
            if (checkBoxCV.Checked)
            {
                total += caoVoi;
            }
            if (checkBoxTT.Checked)
            {
                total += tayTrang;
            }
            if(numericNR.Value > 0)
            {
                total += (numericNR.TabIndex * nhoRang);
            }
            if (numericTR.Value > 0)
            {
                total += (numericTR.TabIndex * tramRang);
            }
            textBoxTotal.Text = total.ToString();
            MessageBox.Show("Khách hàng: "+textBoxName.Text + " cần trả số tiền "+total, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
             if(dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }
    }
}
