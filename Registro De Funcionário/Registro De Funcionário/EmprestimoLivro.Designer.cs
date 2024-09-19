namespace Registro_De_Funcionário
{
    partial class EmprestimoLivro
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
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Registro_De_Funcionário.BibliotecaDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.livroTableAdapter = new Registro_De_Funcionário.BibliotecaDataSetTableAdapters.LivroTableAdapter();
            this.bibliotecaDataSet1 = new Registro_De_Funcionário.BibliotecaDataSet();
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livroBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.livroBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livroBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.livroBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.livroBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet11 = new Registro_De_Funcionário.BibliotecaDataSet1();
            this.livroBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.livroTableAdapter1 = new Registro_De_Funcionário.BibliotecaDataSet1TableAdapters.LivroTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empréstimoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empréstimoTableAdapter = new Registro_De_Funcionário.BibliotecaDataSetTableAdapters.EmpréstimoTableAdapter();
            this.iDLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmpréstimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevoluçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empréstimoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 503);
            this.panel1.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(22, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "< Voltar Para O Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Carlito", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 49);
            this.label1.TabIndex = 24;
            this.label1.Text = "Empréstimo De Livros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(775, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sair Do Usuário";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(188, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Realizar Empréstimo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // bibliotecaDataSet1
            // 
            this.bibliotecaDataSet1.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecaDataSetBindingSource
            // 
            this.bibliotecaDataSetBindingSource.DataSource = this.bibliotecaDataSet;
            this.bibliotecaDataSetBindingSource.Position = 0;
            // 
            // livroBindingSource1
            // 
            this.livroBindingSource1.DataMember = "Livro";
            this.livroBindingSource1.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // livroBindingSource2
            // 
            this.livroBindingSource2.DataMember = "Livro";
            this.livroBindingSource2.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // livroBindingSource3
            // 
            this.livroBindingSource3.DataMember = "Livro";
            this.livroBindingSource3.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // bibliotecaDataSetBindingSource1
            // 
            this.bibliotecaDataSetBindingSource1.DataSource = this.bibliotecaDataSet;
            this.bibliotecaDataSetBindingSource1.Position = 0;
            // 
            // livroBindingSource4
            // 
            this.livroBindingSource4.DataMember = "Livro";
            this.livroBindingSource4.DataSource = this.bibliotecaDataSetBindingSource1;
            // 
            // livroBindingSource5
            // 
            this.livroBindingSource5.DataMember = "Livro";
            this.livroBindingSource5.DataSource = this.bibliotecaDataSetBindingSource;
            // 
            // bibliotecaDataSetBindingSource2
            // 
            this.bibliotecaDataSetBindingSource2.DataSource = this.bibliotecaDataSet;
            this.bibliotecaDataSetBindingSource2.Position = 0;
            // 
            // livroBindingSource6
            // 
            this.livroBindingSource6.DataMember = "Livro";
            this.livroBindingSource6.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet11
            // 
            this.bibliotecaDataSet11.DataSetName = "BibliotecaDataSet1";
            this.bibliotecaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroBindingSource7
            // 
            this.livroBindingSource7.DataMember = "Livro";
            this.livroBindingSource7.DataSource = this.bibliotecaDataSet11;
            // 
            // livroTableAdapter1
            // 
            this.livroTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLivroDataGridViewTextBoxColumn,
            this.dataEmpréstimoDataGridViewTextBoxColumn,
            this.dataDevoluçãoDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.empréstimoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Magenta;
            this.dataGridView1.Location = new System.Drawing.Point(188, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(704, 269);
            this.dataGridView1.TabIndex = 25;
            // 
            // empréstimoBindingSource
            // 
            this.empréstimoBindingSource.DataMember = "Empréstimo";
            this.empréstimoBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // empréstimoTableAdapter
            // 
            this.empréstimoTableAdapter.ClearBeforeFill = true;
            // 
            // iDLivroDataGridViewTextBoxColumn
            // 
            this.iDLivroDataGridViewTextBoxColumn.DataPropertyName = "ID_Livro";
            this.iDLivroDataGridViewTextBoxColumn.HeaderText = "ID_Livro";
            this.iDLivroDataGridViewTextBoxColumn.Name = "iDLivroDataGridViewTextBoxColumn";
            // 
            // dataEmpréstimoDataGridViewTextBoxColumn
            // 
            this.dataEmpréstimoDataGridViewTextBoxColumn.DataPropertyName = "Data_Empréstimo";
            this.dataEmpréstimoDataGridViewTextBoxColumn.HeaderText = "Data_Empréstimo";
            this.dataEmpréstimoDataGridViewTextBoxColumn.Name = "dataEmpréstimoDataGridViewTextBoxColumn";
            // 
            // dataDevoluçãoDataGridViewTextBoxColumn
            // 
            this.dataDevoluçãoDataGridViewTextBoxColumn.DataPropertyName = "Data_Devolução";
            this.dataDevoluçãoDataGridViewTextBoxColumn.HeaderText = "Data_Devolução";
            this.dataDevoluçãoDataGridViewTextBoxColumn.Name = "dataDevoluçãoDataGridViewTextBoxColumn";
            // 
            // EmprestimoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "EmprestimoLivro";
            this.Text = "EmprestimoLivro";
            this.Load += new System.EventHandler(this.EmprestimoLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empréstimoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource livroBindingSource;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private BibliotecaDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private BibliotecaDataSet bibliotecaDataSet1;
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource;
        private System.Windows.Forms.BindingSource livroBindingSource1;
        private System.Windows.Forms.BindingSource livroBindingSource2;
        private System.Windows.Forms.BindingSource livroBindingSource3;
        private System.Windows.Forms.BindingSource livroBindingSource4;
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource1;
        private System.Windows.Forms.BindingSource livroBindingSource5;
        private System.Windows.Forms.BindingSource livroBindingSource6;
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource2;
        private BibliotecaDataSet1 bibliotecaDataSet11;
        private System.Windows.Forms.BindingSource livroBindingSource7;
        private BibliotecaDataSet1TableAdapters.LivroTableAdapter livroTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource empréstimoBindingSource;
        private BibliotecaDataSetTableAdapters.EmpréstimoTableAdapter empréstimoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmpréstimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevoluçãoDataGridViewTextBoxColumn;
    }
}