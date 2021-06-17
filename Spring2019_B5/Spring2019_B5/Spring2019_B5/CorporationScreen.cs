using Spring2019_B5.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spring2019_B5
{
    public partial class CorporationScreen : Form
    {
        public CorporationScreen()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CorporationScreen_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
            select.Name = "checkcol";
            select.HeaderText = "Selected";
            select.ValueType = typeof(bool);
            dgvMain.Columns.Add(select);
            dgvMain.DataSource = CorporationDAO.getListCorpo();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            dgvMain.Columns.Add(edit);
            edit.HeaderText = "Edit";
            edit.Text = "Edit";
            edit.Name = "btnedit";
            edit.UseColumnTextForButtonValue = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    check = true;
                    DialogResult dr = MessageBox.Show("You want to delete this !", "", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            CorporationDAO.Delete(row.Cells[1].Value.ToString());
                            MessageBox.Show("Delete Success");
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvMain.CurrentRow.Index;
            if (dgvMain.Rows[i].Cells[5].Selected)
            {

                FrmUpdate up = new FrmUpdate(dgvMain.Rows[i].Cells[1].Value.ToString());
                this.Hide();
                up.ShowDialog();
                this.Close();
            }
        }
    }
}
