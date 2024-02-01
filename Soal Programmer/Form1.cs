using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
        string connectionString = @"Data Source=LAPTOP-PKU2D3E7\SQLEXPRESS;
                                  Initial Catalog=soal_Programmerdb;Trusted_Connection=True;";
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable dtRecord;
        String IDKaryawan;
        DataGridViewRow selectedRow;



        public frm1()
        {
            InitializeComponent();
        }
        private void frm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soal_ProgrammerdbDataSet1.table_karyawan' table. You can move, or remove it, as needed.
            this.table_karyawanTableAdapter1.Fill(this.soal_ProgrammerdbDataSet1.table_karyawan);
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                using (command = new SqlCommand("SELECT * FROM table_karyawan", con))
                {
                    dataAdapter = new SqlDataAdapter(command);
                    dtRecord = new DataTable();
                    dataAdapter.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;
                }
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtnamaKaryawan1.Text != "")
            {
                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (command = new SqlCommand("SELECT * FROM table_karyawan WHERE Nmkaryawan = '" + txtnamaKaryawan1.Text + "';", con))
                    {
                        dataAdapter = new SqlDataAdapter(command);
                        dtRecord = new DataTable();
                        dataAdapter.Fill(dtRecord);
                        dataGridView1.DataSource = dtRecord;
                    }
                    con.Close();
                }
            }
             else if(txtUsia1.Text != "" && txtUsia2.Text != "")
            {
                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (command = new SqlCommand("SELECT * from table_karyawan WHERE Usia > " + txtUsia1.Text + " AND Usia < " + txtUsia2.Text + ";", con))
                    {
                        dataAdapter = new SqlDataAdapter(command);
                        dtRecord = new DataTable();
                        dataAdapter.Fill(dtRecord);
                        dataGridView1.DataSource = dtRecord;
                    }
                    con.Close();
                }

            }
            else if(dtpTanggal1.Text !="" && dtpTanggal2.Text!= "")
            {
                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (command = new SqlCommand("SELECT * from table_karyawan WHERE TglMasukKerja > '" + dtpTanggal1.Value.ToShortDateString() + "' AND TglMasukKerja < '" + dtpTanggal2.Value.ToShortDateString() + "';", con))
                    {
                        dataAdapter = new SqlDataAdapter(command);
                        dtRecord = new DataTable();
                        dataAdapter.Fill(dtRecord);
                        dataGridView1.DataSource = dtRecord;
                    }
                    con.Close();
                }
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frm2 form2 = new frm2();
            form2.ShowDialog();

            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                using (command = new SqlCommand("SELECT * FROM table_karyawan", con))
                {
                    dataAdapter = new SqlDataAdapter(command);
                    dtRecord = new DataTable();
                    dataAdapter.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;
                }
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                IDKaryawan = Convert.ToString(selectedRow.Cells["IDKaryawan"].Value);
                
                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (command = new SqlCommand("DELETE table_karyawan WHERE IDKaryawan = @param1;", con))
                    {
                        command.Parameters.Add("@param1", SqlDbType.VarChar, 30).Value = IDKaryawan;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }

                    using (command = new SqlCommand("SELECT * FROM table_karyawan", con))
                    {
                        dataAdapter = new SqlDataAdapter(command);
                        dtRecord = new DataTable();
                        dataAdapter.Fill(dtRecord);
                        dataGridView1.DataSource = dtRecord;
                    }
                    con.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
            IDKaryawan = Convert.ToString(selectedRow.Cells["IDKaryawan"].Value);

            frm2 form2 = new frm2(IDKaryawan);
            form2.ShowDialog();

            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                using (command = new SqlCommand("SELECT * FROM table_karyawan", con))
                {
                    dataAdapter = new SqlDataAdapter(command);
                    dtRecord = new DataTable();
                    dataAdapter.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;
                }
                con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
        }

       
    }
}
