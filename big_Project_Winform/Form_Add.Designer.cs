namespace big_Project_Winform
{
    partial class Form_Add
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
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add_id_sinhvien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_name_sinhvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_birthday_sinhvien = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.add_Nam = new System.Windows.Forms.RadioButton();
            this.add_Nu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.add_quequan_sinhvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add_class_sinhvien = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(508, 436);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(151, 47);
            this.button8.TabIndex = 10;
            this.button8.Text = "Trở về";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã sinh viên";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(273, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Làm lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_id_sinhvien
            // 
            this.add_id_sinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_id_sinhvien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_id_sinhvien.Location = new System.Drawing.Point(273, 37);
            this.add_id_sinhvien.Name = "add_id_sinhvien";
            this.add_id_sinhvien.Size = new System.Drawing.Size(200, 33);
            this.add_id_sinhvien.TabIndex = 14;
            this.add_id_sinhvien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Họ tên";
            // 
            // add_name_sinhvien
            // 
            this.add_name_sinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_name_sinhvien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_name_sinhvien.Location = new System.Drawing.Point(273, 98);
            this.add_name_sinhvien.Name = "add_name_sinhvien";
            this.add_name_sinhvien.Size = new System.Drawing.Size(200, 33);
            this.add_name_sinhvien.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày sinh";
            // 
            // add_birthday_sinhvien
            // 
            this.add_birthday_sinhvien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_birthday_sinhvien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.add_birthday_sinhvien.Location = new System.Drawing.Point(273, 160);
            this.add_birthday_sinhvien.Name = "add_birthday_sinhvien";
            this.add_birthday_sinhvien.Size = new System.Drawing.Size(200, 33);
            this.add_birthday_sinhvien.TabIndex = 18;
            this.add_birthday_sinhvien.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giới tính";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // add_Nam
            // 
            this.add_Nam.AutoSize = true;
            this.add_Nam.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Nam.Location = new System.Drawing.Point(273, 228);
            this.add_Nam.Name = "add_Nam";
            this.add_Nam.Size = new System.Drawing.Size(75, 29);
            this.add_Nam.TabIndex = 20;
            this.add_Nam.TabStop = true;
            this.add_Nam.Text = "Nam";
            this.add_Nam.UseVisualStyleBackColor = true;
            // 
            // add_Nu
            // 
            this.add_Nu.AutoSize = true;
            this.add_Nu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Nu.Location = new System.Drawing.Point(396, 223);
            this.add_Nu.Name = "add_Nu";
            this.add_Nu.Size = new System.Drawing.Size(61, 29);
            this.add_Nu.TabIndex = 21;
            this.add_Nu.TabStop = true;
            this.add_Nu.Text = "Nữ";
            this.add_Nu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Quê quán";
            // 
            // add_quequan_sinhvien
            // 
            this.add_quequan_sinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_quequan_sinhvien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_quequan_sinhvien.Location = new System.Drawing.Point(273, 274);
            this.add_quequan_sinhvien.Name = "add_quequan_sinhvien";
            this.add_quequan_sinhvien.Size = new System.Drawing.Size(200, 33);
            this.add_quequan_sinhvien.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Lớp";
            // 
            // add_class_sinhvien
            // 
            this.add_class_sinhvien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_class_sinhvien.FormattingEnabled = true;
            this.add_class_sinhvien.Location = new System.Drawing.Point(273, 342);
            this.add_class_sinhvien.Name = "add_class_sinhvien";
            this.add_class_sinhvien.Size = new System.Drawing.Size(200, 33);
            this.add_class_sinhvien.TabIndex = 25;
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 518);
            this.Controls.Add(this.add_class_sinhvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add_quequan_sinhvien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_Nu);
            this.Controls.Add(this.add_Nam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_birthday_sinhvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_name_sinhvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_id_sinhvien);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(752, 565);
            this.MinimumSize = new System.Drawing.Size(752, 565);
            this.Name = "Form_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sinh viên";
            this.Load += new System.EventHandler(this.Form_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox add_id_sinhvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox add_name_sinhvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker add_birthday_sinhvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton add_Nam;
        private System.Windows.Forms.RadioButton add_Nu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox add_quequan_sinhvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox add_class_sinhvien;
    }
}