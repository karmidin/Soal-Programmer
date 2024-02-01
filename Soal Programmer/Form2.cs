using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soal_Programmer
{
    public partial class frm2 : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable dtRecord;
        String IDKaryawan;

        string connectionString = @"Data Source=LAPTOP-PKU2D3E7\SQLEXPRESS;Initial Catalog=soal_Programmerdb;Trusted_Connection=True;";
        public frm2()
        {
            InitializeComponent();
            btnSaveEdit.Text = "Save";
        }

        public frm2(string iDKaryawan)
        {
            InitializeComponent();
            IDKaryawan = iDKaryawan;
            btnSaveEdit.Text = "Update";

            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                using (command = new SqlCommand("SELECT * FROM table_karyawan WHERE IDkaryawan = @param1", con))
                {
                    command.Parameters.Add("@param1", SqlDbType.VarChar, 30).Value = iDKaryawan;
                    dataAdapter = new SqlDataAdapter(command);
                    dtRecord = new DataTable();
                    dataAdapter.Fill(dtRecord);
                }
                con.Close();
                txtId.Text = dtRecord.Rows[0]["IDKaryawan"].ToString();
                txtNama.Text = dtRecord.Rows[0]["NmKaryawan"].ToString();
                txtUsia.Text = dtRecord.Rows[0]["Usia"].ToString();
                dtpTanggal.Text = dtRecord.Rows[0]["TglMasukKerja"].ToString();
            }

            txtId.Enabled = false;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    if (IDKaryawan == "")
                    {
                        using (command = new SqlCommand("INSERT INTO table_karyawan VALUES (@param1,@param2,@param3,@param4);", con))
                        {
                            command.Parameters.Add("@param1", SqlDbType.VarChar, 30).Value = txtId.Text;
                            command.Parameters.Add("@param2", SqlDbType.VarChar, 30).Value = txtNama.Text;
                            command.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = dtpTanggal.Value.ToShortDateString();
                            command.Parameters.Add("@param4", SqlDbType.Int).Value = txtUsia.Text;
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (command = new SqlCommand("UPDATE table_karyawan SET NmKaryawan = @param2, TglMasukKerja= @param3, Usia = @param4 WHERE IDKaryawan = @param1;", con))
                        {
                            command.Parameters.Add("@param1", SqlDbType.VarChar, 30).Value = txtId.Text;
                            command.Parameters.Add("@param2", SqlDbType.VarChar, 30).Value = txtNama.Text;
                            command.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = dtpTanggal.Value.ToShortDateString();
                            command.Parameters.Add("@param4", SqlDbType.Int).Value = txtUsia.Text;
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                        }
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pastikan mengisi data dengan benar");
            }
            con.Close();
        }
    }
}
