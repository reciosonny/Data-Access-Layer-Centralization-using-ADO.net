namespace test
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Button1 = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtAddLname = new System.Windows.Forms.TextBox();
            this.txtAddMname = new System.Windows.Forms.TextBox();
            this.txtAddFname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.txtUpdateLname = new System.Windows.Forms.TextBox();
            this.txtUpdateMname = new System.Windows.Forms.TextBox();
            this.txtUpdateFname = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 249);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(831, 237);
            this.TabControl1.TabIndex = 3;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.txtAddLname);
            this.TabPage1.Controls.Add(this.txtAddMname);
            this.TabPage1.Controls.Add(this.txtAddFname);
            this.TabPage1.Controls.Add(this.btnAdd);
            this.TabPage1.Controls.Add(this.Button1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(823, 211);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Add new Person";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(6, 219);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Add";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.btnDelete);
            this.TabPage2.Controls.Add(this.btnUpdate);
            this.TabPage2.Controls.Add(this.txtUpdateId);
            this.TabPage2.Controls.Add(this.txtUpdateLname);
            this.TabPage2.Controls.Add(this.txtUpdateMname);
            this.TabPage2.Controls.Add(this.txtUpdateFname);
            this.TabPage2.Controls.Add(this.Label7);
            this.TabPage2.Controls.Add(this.Label4);
            this.TabPage2.Controls.Add(this.Label5);
            this.TabPage2.Controls.Add(this.Label6);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(823, 211);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Update/Delete Person";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(55, 81);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 13);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Last name:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 13);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Middle name/initial:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(56, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "First name:";
            // 
            // txtAddLname
            // 
            this.txtAddLname.Location = new System.Drawing.Point(120, 81);
            this.txtAddLname.Name = "txtAddLname";
            this.txtAddLname.Size = new System.Drawing.Size(192, 20);
            this.txtAddLname.TabIndex = 11;
            // 
            // txtAddMname
            // 
            this.txtAddMname.Location = new System.Drawing.Point(120, 55);
            this.txtAddMname.Name = "txtAddMname";
            this.txtAddMname.Size = new System.Drawing.Size(192, 20);
            this.txtAddMname.TabIndex = 10;
            // 
            // txtAddFname
            // 
            this.txtAddFname.Location = new System.Drawing.Point(120, 29);
            this.txtAddFname.Name = "txtAddFname";
            this.txtAddFname.Size = new System.Drawing.Size(192, 20);
            this.txtAddFname.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add and Update Datagrid";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(222, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Enabled = false;
            this.txtUpdateId.Location = new System.Drawing.Point(122, 22);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(67, 20);
            this.txtUpdateId.TabIndex = 28;
            // 
            // txtUpdateLname
            // 
            this.txtUpdateLname.Location = new System.Drawing.Point(122, 102);
            this.txtUpdateLname.Name = "txtUpdateLname";
            this.txtUpdateLname.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateLname.TabIndex = 23;
            // 
            // txtUpdateMname
            // 
            this.txtUpdateMname.Location = new System.Drawing.Point(122, 76);
            this.txtUpdateMname.Name = "txtUpdateMname";
            this.txtUpdateMname.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateMname.TabIndex = 22;
            // 
            // txtUpdateFname
            // 
            this.txtUpdateFname.Location = new System.Drawing.Point(122, 50);
            this.txtUpdateFname.Name = "txtUpdateFname";
            this.txtUpdateFname.Size = new System.Drawing.Size(192, 20);
            this.txtUpdateFname.TabIndex = 21;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(55, 25);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(61, 13);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "ID Number:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(57, 102);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 13);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "Last name:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(18, 76);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(98, 13);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Middle name/initial:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(58, 50);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(58, 13);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "First name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "C#.net API sample demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtAddLname;
        internal System.Windows.Forms.TextBox txtAddMname;
        internal System.Windows.Forms.TextBox txtAddFname;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.TextBox txtUpdateId;
        internal System.Windows.Forms.TextBox txtUpdateLname;
        internal System.Windows.Forms.TextBox txtUpdateMname;
        internal System.Windows.Forms.TextBox txtUpdateFname;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
    }
}