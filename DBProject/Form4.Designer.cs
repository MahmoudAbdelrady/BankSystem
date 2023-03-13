
namespace DBProject
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.projectDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet = new DBProject.ProjectDBDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Control Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-1, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add bank";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add bank branch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(52, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "Sign up a new user";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(571, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 50);
            this.button5.TabIndex = 12;
            this.button5.Text = "Update a user details";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(52, 444);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 50);
            this.button6.TabIndex = 13;
            this.button6.Text = "Show loans list";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(571, 444);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(174, 59);
            this.button8.TabIndex = 15;
            this.button8.Text = "Show loans list (with customer and employee name )";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // projectDBDataSetBindingSource
            // 
            this.projectDBDataSetBindingSource.DataSource = this.projectDBDataSet;
            this.projectDBDataSetBindingSource.Position = 0;
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.BindingSource projectDBDataSetBindingSource;
        private ProjectDBDataSet1 projectDBDataSet;
    }
}