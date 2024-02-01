using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soal_Programmer
{
    public partial class frm1 : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        public frm1()
        {
            InitializeComponent();
        }
        private void frm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soal_ProgrammerdbDataSet1.table_karyawan' table. You can move, or remove it, as needed.
            this.table_karyawanTableAdapter1.Fill(this.soal_ProgrammerdbDataSet1.table_karyawan);

            da = new SqlDataAdapter("SELECT * FROM table_karyawan", "server = LAPTOP-PKU2D3E7\\SQLEXPRESS; database = soal_Programmerdb;Trusted_Connection=True;");
            ds = new DataSet();
            da.Fill(ds, "table_karyawan");
            dataGridView2.DataSource = ds.Tables["table_karyawan"].DefaultView;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if (txtnamaKaryawan1.Text != "")
            {
                da = new SqlDataAdapter("SELECT * FROM table_karyawan WHERE Nmkaryawan = '" + txtnamaKaryawan1.Text + "';", "server = LAPTOP-PKU2D3E7\\SQLEXPRESS; database = soal_Programmerdb;Trusted_Connection=True;");
                ds = new DataSet();
                da.Fill(ds, "table_karyawan");
                dataGridView2.DataSource = ds.Tables["table_karyawan"].DefaultView;
            }else if(txtUsia1.Text != "" && txtUsia2.Text != "")
            {
                da = new SqlDataAdapter("SELECT * from table_karyawan WHERE Usia > "+txtUsia1.Text+" AND Usia < "+txtUsia2.Text+";", "server = LAPTOP-PKU2D3E7\\SQLEXPRESS; database = soal_Programmerdb;Trusted_Connection=True;");
                ds = new DataSet();
                da.Fill(ds, "table_karyawan");
                dataGridView2.DataSource = ds.Tables["table_karyawan"].DefaultView;
            }else if(dtpTanggal1.Text !="" && dtpTanggal2.Text!= "")
            {
                da = new SqlDataAdapter("SELECT * from table_karyawan WHERE TglMasukKerja > '" + dtpTanggal1.Value.ToShortDateString()+ "' AND TglMasukKerja < '" + dtpTanggal2.Value.ToShortDateString() + "';", "server = LAPTOP-PKU2D3E7\\SQLEXPRESS; database = soal_Programmerdb;Trusted_Connection=True;");
                ds = new DataSet();
                da.Fill(ds, "table_karyawan");
                dataGridView2.DataSource = ds.Tables["table_karyawan"].DefaultView;
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
            }
        }
    }
}
