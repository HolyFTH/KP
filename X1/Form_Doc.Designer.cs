namespace X1
{
    partial class Form_Doc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.x1_ShopDataSet1 = new X1.X1_ShopDataSet1();
            this.polzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polzTableAdapter = new X1.X1_ShopDataSet1TableAdapters.PolzTableAdapter();
            this.iDPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRoshPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuspolzIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1_ShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polzBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPolzDataGridViewTextBoxColumn,
            this.namePolzDataGridViewTextBoxColumn,
            this.famPolzDataGridViewTextBoxColumn,
            this.otchPolzDataGridViewTextBoxColumn,
            this.emailPolzDataGridViewTextBoxColumn,
            this.dataRoshPolzDataGridViewTextBoxColumn,
            this.logPolzDataGridViewTextBoxColumn,
            this.passPolzDataGridViewTextBoxColumn,
            this.statuspolzIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.polzBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(874, 205);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(154, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 301);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(154, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(95, 327);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(154, 20);
            this.textBox5.TabIndex = 1;
            // 
            // x1_ShopDataSet1
            // 
            this.x1_ShopDataSet1.DataSetName = "X1_ShopDataSet1";
            this.x1_ShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polzBindingSource
            // 
            this.polzBindingSource.DataMember = "Polz";
            this.polzBindingSource.DataSource = this.x1_ShopDataSet1;
            // 
            // polzTableAdapter
            // 
            this.polzTableAdapter.ClearBeforeFill = true;
            // 
            // iDPolzDataGridViewTextBoxColumn
            // 
            this.iDPolzDataGridViewTextBoxColumn.DataPropertyName = "ID_Polz";
            this.iDPolzDataGridViewTextBoxColumn.HeaderText = "ID_Polz";
            this.iDPolzDataGridViewTextBoxColumn.Name = "iDPolzDataGridViewTextBoxColumn";
            this.iDPolzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namePolzDataGridViewTextBoxColumn
            // 
            this.namePolzDataGridViewTextBoxColumn.DataPropertyName = "Name_Polz";
            this.namePolzDataGridViewTextBoxColumn.HeaderText = "Name_Polz";
            this.namePolzDataGridViewTextBoxColumn.Name = "namePolzDataGridViewTextBoxColumn";
            // 
            // famPolzDataGridViewTextBoxColumn
            // 
            this.famPolzDataGridViewTextBoxColumn.DataPropertyName = "Fam_Polz";
            this.famPolzDataGridViewTextBoxColumn.HeaderText = "Fam_Polz";
            this.famPolzDataGridViewTextBoxColumn.Name = "famPolzDataGridViewTextBoxColumn";
            // 
            // otchPolzDataGridViewTextBoxColumn
            // 
            this.otchPolzDataGridViewTextBoxColumn.DataPropertyName = "Otch_Polz";
            this.otchPolzDataGridViewTextBoxColumn.HeaderText = "Otch_Polz";
            this.otchPolzDataGridViewTextBoxColumn.Name = "otchPolzDataGridViewTextBoxColumn";
            // 
            // emailPolzDataGridViewTextBoxColumn
            // 
            this.emailPolzDataGridViewTextBoxColumn.DataPropertyName = "E_mail_Polz";
            this.emailPolzDataGridViewTextBoxColumn.HeaderText = "E_mail_Polz";
            this.emailPolzDataGridViewTextBoxColumn.Name = "emailPolzDataGridViewTextBoxColumn";
            // 
            // dataRoshPolzDataGridViewTextBoxColumn
            // 
            this.dataRoshPolzDataGridViewTextBoxColumn.DataPropertyName = "Data_Rosh_Polz";
            this.dataRoshPolzDataGridViewTextBoxColumn.HeaderText = "Data_Rosh_Polz";
            this.dataRoshPolzDataGridViewTextBoxColumn.Name = "dataRoshPolzDataGridViewTextBoxColumn";
            // 
            // logPolzDataGridViewTextBoxColumn
            // 
            this.logPolzDataGridViewTextBoxColumn.DataPropertyName = "Log_Polz";
            this.logPolzDataGridViewTextBoxColumn.HeaderText = "Log_Polz";
            this.logPolzDataGridViewTextBoxColumn.Name = "logPolzDataGridViewTextBoxColumn";
            // 
            // passPolzDataGridViewTextBoxColumn
            // 
            this.passPolzDataGridViewTextBoxColumn.DataPropertyName = "Pass_Polz";
            this.passPolzDataGridViewTextBoxColumn.HeaderText = "Pass_Polz";
            this.passPolzDataGridViewTextBoxColumn.Name = "passPolzDataGridViewTextBoxColumn";
            // 
            // statuspolzIDDataGridViewTextBoxColumn
            // 
            this.statuspolzIDDataGridViewTextBoxColumn.DataPropertyName = "Status_polz_ID";
            this.statuspolzIDDataGridViewTextBoxColumn.HeaderText = "Status_polz_ID";
            this.statuspolzIDDataGridViewTextBoxColumn.Name = "statuspolzIDDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дата рождения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Doc";
            this.Text = "Form_Doc";
            this.Load += new System.EventHandler(this.Form_Doc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1_ShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polzBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private X1_ShopDataSet1 x1_ShopDataSet1;
        private System.Windows.Forms.BindingSource polzBindingSource;
        private X1_ShopDataSet1TableAdapters.PolzTableAdapter polzTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn famPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRoshPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuspolzIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}