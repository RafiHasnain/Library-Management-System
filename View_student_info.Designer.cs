namespace Library_ManagementSystem
{
    partial class View_student_info
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.TextBox();
            this.student_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.student_dept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.student_sem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.student_contact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 448);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.student_email);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.student_contact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.student_sem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.student_dept);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.student_ID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.student_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(285, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 250);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(173, 47);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(100, 22);
            this.student_name.TabIndex = 1;
            // 
            // student_ID
            // 
            this.student_ID.Location = new System.Drawing.Point(173, 118);
            this.student_ID.Name = "student_ID";
            this.student_ID.Size = new System.Drawing.Size(100, 22);
            this.student_ID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID";
            // 
            // student_dept
            // 
            this.student_dept.Location = new System.Drawing.Point(451, 47);
            this.student_dept.Name = "student_dept";
            this.student_dept.Size = new System.Drawing.Size(100, 22);
            this.student_dept.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // student_sem
            // 
            this.student_sem.Location = new System.Drawing.Point(451, 118);
            this.student_sem.Name = "student_sem";
            this.student_sem.Size = new System.Drawing.Size(100, 22);
            this.student_sem.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Semester";
            // 
            // student_contact
            // 
            this.student_contact.Location = new System.Drawing.Point(711, 47);
            this.student_contact.Name = "student_contact";
            this.student_contact.Size = new System.Drawing.Size(100, 22);
            this.student_contact.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact";
            // 
            // student_email
            // 
            this.student_email.Location = new System.Drawing.Point(711, 113);
            this.student_email.Name = "student_email";
            this.student_email.Size = new System.Drawing.Size(100, 22);
            this.student_email.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // View_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 783);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_student_info";
            this.Text = "View_student_info";
            this.Load += new System.EventHandler(this.View_student_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox student_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox student_sem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox student_dept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label1;
    }
}