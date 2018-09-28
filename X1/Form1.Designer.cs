namespace X1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.x1_ShopDataSet = new X1.X1_ShopDataSet();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new X1.X1_ShopDataSetTableAdapters.TovarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x1_ShopDataSet1 = new X1.X1_ShopDataSet1();
            this.tovarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter1 = new X1.X1_ShopDataSet1TableAdapters.TovarTableAdapter();
            this.iDTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalTovarDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kolvoTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x1_ShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1_ShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "О нас";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(273, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "X1-Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категории";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Мыши";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Клавиатуры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Наушники";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(32, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ноутбуки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(32, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "ПК";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(32, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Планшеты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(32, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Телефоны";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(32, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Игровые консоли";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x1_ShopDataSet
            // 
            this.x1_ShopDataSet.DataSetName = "X1_ShopDataSet";
            this.x1_ShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.x1_ShopDataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTovarDataGridViewTextBoxColumn,
            this.nazvTovarDataGridViewTextBoxColumn,
            this.opisTovarDataGridViewTextBoxColumn,
            this.cenaTovarDataGridViewTextBoxColumn,
            this.nalTovarDataGridViewCheckBoxColumn,
            this.kolvoTovarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(183, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 240);
            this.dataGridView1.TabIndex = 6;
            // 
            // x1_ShopDataSet1
            // 
            this.x1_ShopDataSet1.DataSetName = "X1_ShopDataSet1";
            this.x1_ShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource1
            // 
            this.tovarBindingSource1.DataMember = "Tovar";
            this.tovarBindingSource1.DataSource = this.x1_ShopDataSet1;
            // 
            // tovarTableAdapter1
            // 
            this.tovarTableAdapter1.ClearBeforeFill = true;
            // 
            // iDTovarDataGridViewTextBoxColumn
            // 
            this.iDTovarDataGridViewTextBoxColumn.DataPropertyName = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn.HeaderText = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn.Name = "iDTovarDataGridViewTextBoxColumn";
            this.iDTovarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazvTovarDataGridViewTextBoxColumn
            // 
            this.nazvTovarDataGridViewTextBoxColumn.DataPropertyName = "Nazv_Tovar";
            this.nazvTovarDataGridViewTextBoxColumn.HeaderText = "Nazv_Tovar";
            this.nazvTovarDataGridViewTextBoxColumn.Name = "nazvTovarDataGridViewTextBoxColumn";
            // 
            // opisTovarDataGridViewTextBoxColumn
            // 
            this.opisTovarDataGridViewTextBoxColumn.DataPropertyName = "Opis_Tovar";
            this.opisTovarDataGridViewTextBoxColumn.HeaderText = "Opis_Tovar";
            this.opisTovarDataGridViewTextBoxColumn.Name = "opisTovarDataGridViewTextBoxColumn";
            // 
            // cenaTovarDataGridViewTextBoxColumn
            // 
            this.cenaTovarDataGridViewTextBoxColumn.DataPropertyName = "Cena_Tovar";
            this.cenaTovarDataGridViewTextBoxColumn.HeaderText = "Cena_Tovar";
            this.cenaTovarDataGridViewTextBoxColumn.Name = "cenaTovarDataGridViewTextBoxColumn";
            // 
            // nalTovarDataGridViewCheckBoxColumn
            // 
            this.nalTovarDataGridViewCheckBoxColumn.DataPropertyName = "Nal_Tovar";
            this.nalTovarDataGridViewCheckBoxColumn.HeaderText = "Nal_Tovar";
            this.nalTovarDataGridViewCheckBoxColumn.Name = "nalTovarDataGridViewCheckBoxColumn";
            // 
            // kolvoTovarDataGridViewTextBoxColumn
            // 
            this.kolvoTovarDataGridViewTextBoxColumn.DataPropertyName = "Kolvo_Tovar";
            this.kolvoTovarDataGridViewTextBoxColumn.HeaderText = "Kolvo_Tovar";
            this.kolvoTovarDataGridViewTextBoxColumn.Name = "kolvoTovarDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Вывод данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(690, 351);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Shop X1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x1_ShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1_ShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private X1_ShopDataSet x1_ShopDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private X1_ShopDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private X1_ShopDataSet1 x1_ShopDataSet1;
        private System.Windows.Forms.BindingSource tovarBindingSource1;
        private X1_ShopDataSet1TableAdapters.TovarTableAdapter tovarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nalTovarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoTovarDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}

