using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlisinhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioitinh="";
            if(radnam.Checked)
            {
               gioitinh= radnam.Text+"";
            }else if(radnu.Checked)
            {
                gioitinh=radnu.Text+"";
            }
            dataGridView1.Rows.Add(txtMasv.Text, txtHoten.Text, dtpNgaysinh.Text,gioitinh, cboNoisinh.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtpNgaysinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value == radnam.Text)
            {
                radnam.Checked = true;
            }else if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == radnu.Text)
            {
                radnu.Checked = true;
            }
            cboNoisinh.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[0].Value= txtMasv.Text;
            dataGridView1.CurrentRow.Cells[1].Value =  txtHoten.Text;
            dataGridView1.CurrentRow.Cells[2].Value = dtpNgaysinh.Text;
            if (dataGridView1.CurrentRow.Cells[3].Value==radnam.Text)
            {
                dataGridView1.CurrentRow.Cells[3].Value = radnu.Text;
                radnu.Checked = true;
            }else if (dataGridView1.CurrentRow.Cells[3].Value == radnu.Text)
            {
                dataGridView1.CurrentRow.Cells[3].Value=radnam.Text;
                radnam.Checked= true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           int RowIndex=dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(RowIndex);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show(); 
            //mo ra 1 giao dien moi
        }
    }
}
