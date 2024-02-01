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
        string connectionString = @"Data Source=LAPTOP-PKU2D3E7\SQLEXPRESS;Initial Catalog=soal_Programmerdb;Trusted_Connection=True;";
        public frm2()
        {
            InitializeComponent();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                using (command = new SqlCommand("INSERT INTO table_karyawan VALUES (@param1,@param2,@param3,@param4);", con))
                {
                    command.Parameters.Add("@param1", SqlDbType.VarChar,30).Value = txtId.Text;
                    command.Parameters.Add("@param2", SqlDbType.VarChar, 30).Value = txtNama.Text;
                    command.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = dtpTanggal.Value.ToShortDateString();
                    command.Parameters.Add("@param4", SqlDbType.Int).Value = txtUsia.Text;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            this.Close();
        }
    }
}
