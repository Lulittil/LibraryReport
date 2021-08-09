namespace LibraryReport
{
    partial class VP
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
            this.sellingBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet6 = new LibraryReport.LibraryDataSet6();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sellingBookTableAdapter = new LibraryReport.LibraryDataSet6TableAdapters.SellingBookTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.начальнаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.конечнаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоПроданныхКнигDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прибыльDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.названиеКнигиDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.начальнаяСтоимостьDataGridViewTextBoxColumn,
            this.конечнаяСтоимостьDataGridViewTextBoxColumn,
            this.датаПродажиDataGridViewTextBoxColumn,
            this.колвоПроданныхКнигDataGridViewTextBoxColumn,
            this.прибыльDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sellingBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // sellingBookBindingSource
            // 
            this.sellingBookBindingSource.DataMember = "SellingBook";
            this.sellingBookBindingSource.DataSource = this.libraryDataSet6;
            // 
            // libraryDataSet6
            // 
            this.libraryDataSet6.DataSetName = "LibraryDataSet6";
            this.libraryDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(72, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "До";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(651, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сформировать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sellingBookTableAdapter
            // 
            this.sellingBookTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 122;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // названиеКнигиDataGridViewTextBoxColumn
            // 
            this.названиеКнигиDataGridViewTextBoxColumn.DataPropertyName = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.Name = "названиеКнигиDataGridViewTextBoxColumn";
            this.названиеКнигиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            this.авторDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // начальнаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.начальнаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Начальная стоимость";
            this.начальнаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Начальная стоимость";
            this.начальнаяСтоимостьDataGridViewTextBoxColumn.Name = "начальнаяСтоимостьDataGridViewTextBoxColumn";
            this.начальнаяСтоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // конечнаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.конечнаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Конечная стоимость";
            this.конечнаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Конечная стоимость";
            this.конечнаяСтоимостьDataGridViewTextBoxColumn.Name = "конечнаяСтоимостьDataGridViewTextBoxColumn";
            this.конечнаяСтоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаПродажиDataGridViewTextBoxColumn
            // 
            this.датаПродажиDataGridViewTextBoxColumn.DataPropertyName = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.Name = "датаПродажиDataGridViewTextBoxColumn";
            this.датаПродажиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // колвоПроданныхКнигDataGridViewTextBoxColumn
            // 
            this.колвоПроданныхКнигDataGridViewTextBoxColumn.DataPropertyName = "Кол-во проданных книг";
            this.колвоПроданныхКнигDataGridViewTextBoxColumn.HeaderText = "Кол-во проданных книг";
            this.колвоПроданныхКнигDataGridViewTextBoxColumn.Name = "колвоПроданныхКнигDataGridViewTextBoxColumn";
            this.колвоПроданныхКнигDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // прибыльDataGridViewTextBoxColumn
            // 
            this.прибыльDataGridViewTextBoxColumn.DataPropertyName = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn.HeaderText = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn.Name = "прибыльDataGridViewTextBoxColumn";
            this.прибыльDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VP";
            this.Text = "VP";
            this.Load += new System.EventHandler(this.VP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellingBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private LibraryDataSet6 libraryDataSet6;
        private System.Windows.Forms.BindingSource sellingBookBindingSource;
        private LibraryDataSet6TableAdapters.SellingBookTableAdapter sellingBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn начальнаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn конечнаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоПроданныхКнигDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прибыльDataGridViewTextBoxColumn;
    }
}