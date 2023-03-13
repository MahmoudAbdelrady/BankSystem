
namespace DBProject
{
    partial class Form10
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lOANTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet1 = new DBProject.ProjectDBDataSet1();
            this.lOANTableAdapter = new DBProject.ProjectDBDataSet1TableAdapters.LOANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-1, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Loans List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lOANTYPEDataGridViewTextBoxColumn,
            this.lOANNUMDataGridViewTextBoxColumn,
            this.lOANAMOUNTDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lOANBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 366);
            this.dataGridView1.TabIndex = 32;
            // 
            // lOANTYPEDataGridViewTextBoxColumn
            // 
            this.lOANTYPEDataGridViewTextBoxColumn.DataPropertyName = "LOANTYPE";
            this.lOANTYPEDataGridViewTextBoxColumn.HeaderText = "LOANTYPE";
            this.lOANTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANTYPEDataGridViewTextBoxColumn.Name = "lOANTYPEDataGridViewTextBoxColumn";
            this.lOANTYPEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOANNUMDataGridViewTextBoxColumn
            // 
            this.lOANNUMDataGridViewTextBoxColumn.DataPropertyName = "LOANNUM";
            this.lOANNUMDataGridViewTextBoxColumn.HeaderText = "LOANNUM";
            this.lOANNUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANNUMDataGridViewTextBoxColumn.Name = "lOANNUMDataGridViewTextBoxColumn";
            this.lOANNUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOANAMOUNTDataGridViewTextBoxColumn
            // 
            this.lOANAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "LOANAMOUNT";
            this.lOANAMOUNTDataGridViewTextBoxColumn.HeaderText = "LOANAMOUNT";
            this.lOANAMOUNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANAMOUNTDataGridViewTextBoxColumn.Name = "lOANAMOUNTDataGridViewTextBoxColumn";
            this.lOANAMOUNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOANBindingSource
            // 
            this.lOANBindingSource.DataMember = "LOAN";
            this.lOANBindingSource.DataSource = this.projectDBDataSet1;
            // 
            // projectDBDataSet1
            // 
            this.projectDBDataSet1.DataSetName = "ProjectDBDataSet1";
            this.projectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOANTableAdapter
            // 
            this.lOANTableAdapter.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectDBDataSet1 projectDBDataSet1;
        private System.Windows.Forms.BindingSource lOANBindingSource;
        private ProjectDBDataSet1TableAdapters.LOANTableAdapter lOANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
    }
}