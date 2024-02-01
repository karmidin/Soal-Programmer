namespace Soal_Programmer
{
    partial class frm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnamaKaryawan1 = new System.Windows.Forms.TextBox();
            this.txtUsia1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUsia2 = new System.Windows.Forms.TextBox();
            this.txtnamaKaryawan2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.soalProgrammerdbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soal_ProgrammerdbDataSet1 = new Soal_Programmer.soal_ProgrammerdbDataSet();
            this.table_karyawanTableAdapter1 = new Soal_Programmer.soal_ProgrammerdbDataSetTableAdapters.table_karyawanTableAdapter();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpTanggal1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggal2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soalProgrammerdbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soal_ProgrammerdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Filter Data :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nama Karyawan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tgl Masuk Kerja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Usia";
            // 
            // txtnamaKaryawan1
            // 
            this.txtnamaKaryawan1.Location = new System.Drawing.Point(126, 52);
            this.txtnamaKaryawan1.Name = "txtnamaKaryawan1";
            this.txtnamaKaryawan1.Size = new System.Drawing.Size(152, 22);
            this.txtnamaKaryawan1.TabIndex = 4;
            // 
            // txtUsia1
            // 
            this.txtUsia1.Location = new System.Drawing.Point(126, 84);
            this.txtUsia1.Name = "txtUsia1";
            this.txtUsia1.Size = new System.Drawing.Size(152, 22);
            this.txtUsia1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "s/d";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "s/d";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(338, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "s/d";
            // 
            // txtUsia2
            // 
            this.txtUsia2.Location = new System.Drawing.Point(386, 87);
            this.txtUsia2.Name = "txtUsia2";
            this.txtUsia2.Size = new System.Drawing.Size(152, 22);
            this.txtUsia2.TabIndex = 13;
            // 
            // txtnamaKaryawan2
            // 
            this.txtnamaKaryawan2.Location = new System.Drawing.Point(386, 55);
            this.txtnamaKaryawan2.Name = "txtnamaKaryawan2";
            this.txtnamaKaryawan2.Size = new System.Drawing.Size(152, 22);
            this.txtnamaKaryawan2.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(553, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Hasil Filter Data (GRID)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(478, 150);
            this.dataGridView1.TabIndex = 16;
  
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "table_karyawan";
            this.bindingSource1.DataSource = this.soalProgrammerdbDataSet1BindingSource;
            // 
            // soalProgrammerdbDataSet1BindingSource
            // 
            this.soalProgrammerdbDataSet1BindingSource.DataSource = this.soal_ProgrammerdbDataSet1;
            this.soalProgrammerdbDataSet1BindingSource.Position = 0;
            // 
            // soal_ProgrammerdbDataSet1
            // 
            this.soal_ProgrammerdbDataSet1.DataSetName = "soal_ProgrammerdbDataSet";
            this.soal_ProgrammerdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_karyawanTableAdapter1
            // 
            this.table_karyawanTableAdapter1.ClearBeforeFill = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 336);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 29);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(203, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(112, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(294, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpTanggal1
            // 
            this.dtpTanggal1.Location = new System.Drawing.Point(123, 116);
            this.dtpTanggal1.Name = "dtpTanggal1";
            this.dtpTanggal1.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggal1.TabIndex = 21;
            // 
            // dtpTanggal2
            // 
            this.dtpTanggal2.Location = new System.Drawing.Point(386, 122);
            this.dtpTanggal2.Name = "dtpTanggal2";
            this.dtpTanggal2.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggal2.TabIndex = 22;
            // 
            // frm1
            // 
            this.ClientSize = new System.Drawing.Size(663, 394);
            this.Controls.Add(this.dtpTanggal2);
            this.Controls.Add(this.dtpTanggal1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUsia2);
            this.Controls.Add(this.txtnamaKaryawan2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUsia1);
            this.Controls.Add(this.txtnamaKaryawan1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "frm1";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soalProgrammerdbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soal_ProgrammerdbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
       
        
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    
        
        private System.Windows.Forms.Label label8;
        private soal_ProgrammerdbDataSet soal_ProgrammerdbDataSet;
        private System.Windows.Forms.BindingSource tablekaryawanBindingSource;
        private soal_ProgrammerdbDataSetTableAdapters.table_karyawanTableAdapter table_karyawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglMasukKerjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnamaKaryawan1;
        private System.Windows.Forms.TextBox txtUsia1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUsia2;
        private System.Windows.Forms.TextBox txtnamaKaryawan2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource soalProgrammerdbDataSet1BindingSource;
        private soal_ProgrammerdbDataSet soal_ProgrammerdbDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private soal_ProgrammerdbDataSetTableAdapters.table_karyawanTableAdapter table_karyawanTableAdapter1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpTanggal1;
        private System.Windows.Forms.DateTimePicker dtpTanggal2;
    }
}

