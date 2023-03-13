
namespace DBProject
{
    partial class Form2
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
            this.projectDBDataSet = new DBProject.ProjectDBDataSet1();
            this.projectDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERADDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet1 = new DBProject.ProjectDBDataSet1();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cUSTOMERTableAdapter = new DBProject.ProjectDBDataSet1TableAdapters.CUSTOMERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectDBDataSetBindingSource
            // 
            this.projectDBDataSetBindingSource.DataSource = this.projectDBDataSet;
            this.projectDBDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Control Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add a customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.sSNDataGridViewTextBoxColumn,
            this.eMPSSNDataGridViewTextBoxColumn,
            this.bRANCHNUMDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.cUSTOMERADDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(335, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 336);
            this.dataGridView1.TabIndex = 4;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            this.sSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMPSSNDataGridViewTextBoxColumn
            // 
            this.eMPSSNDataGridViewTextBoxColumn.DataPropertyName = "EMP_SSN";
            this.eMPSSNDataGridViewTextBoxColumn.HeaderText = "EMP_SSN";
            this.eMPSSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPSSNDataGridViewTextBoxColumn.Name = "eMPSSNDataGridViewTextBoxColumn";
            this.eMPSSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // bRANCHNUMDataGridViewTextBoxColumn
            // 
            this.bRANCHNUMDataGridViewTextBoxColumn.DataPropertyName = "BRANCHNUM";
            this.bRANCHNUMDataGridViewTextBoxColumn.HeaderText = "BRANCHNUM";
            this.bRANCHNUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bRANCHNUMDataGridViewTextBoxColumn.Name = "bRANCHNUMDataGridViewTextBoxColumn";
            this.bRANCHNUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERADDDataGridViewTextBoxColumn
            // 
            this.cUSTOMERADDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMERADD";
            this.cUSTOMERADDDataGridViewTextBoxColumn.HeaderText = "CUSTOMERADD";
            this.cUSTOMERADDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERADDDataGridViewTextBoxColumn.Name = "cUSTOMERADDDataGridViewTextBoxColumn";
            this.cUSTOMERADDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.projectDBDataSet1BindingSource;
            // 
            // projectDBDataSet1BindingSource
            // 
            this.projectDBDataSet1BindingSource.DataSource = this.projectDBDataSet1;
            this.projectDBDataSet1BindingSource.Position = 0;
            // 
            // projectDBDataSet1
            // 
            this.projectDBDataSet1.DataSetName = "ProjectDBDataSet1";
            this.projectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-1, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 97);
            this.button4.TabIndex = 7;
            this.button4.Text = "Show Customers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 520);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectDBDataSet1 projectDBDataSet;
        private System.Windows.Forms.BindingSource projectDBDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource projectDBDataSet1BindingSource;
        private ProjectDBDataSet1 projectDBDataSet1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private ProjectDBDataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERADDDataGridViewTextBoxColumn;
    }
}