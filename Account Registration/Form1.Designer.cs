namespace Account_Registration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Student = new TextBox();
            Last = new TextBox();
            First = new TextBox();
            Middle = new TextBox();
            age = new TextBox();
            num = new TextBox();
            Program = new ComboBox();
            add = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 58);
            label1.Name = "label1";
            label1.Size = new Size(79, 16);
            label1.TabIndex = 0;
            label1.Text = "Student No. :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 58);
            label2.Name = "label2";
            label2.Size = new Size(68, 16);
            label2.TabIndex = 1;
            label2.Text = "Program : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 142);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 2;
            label3.Text = "Last Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(249, 142);
            label4.Name = "label4";
            label4.Size = new Size(80, 16);
            label4.TabIndex = 3;
            label4.Text = "First Name : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(441, 142);
            label5.Name = "label5";
            label5.Size = new Size(91, 16);
            label5.TabIndex = 4;
            label5.Text = "Middle Name : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(49, 233);
            label6.Name = "label6";
            label6.Size = new Size(38, 16);
            label6.TabIndex = 5;
            label6.Text = "Age : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(249, 234);
            label7.Name = "label7";
            label7.Size = new Size(78, 16);
            label7.TabIndex = 6;
            label7.Text = "Contact No. :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(49, 335);
            label8.Name = "label8";
            label8.Size = new Size(65, 16);
            label8.TabIndex = 7;
            label8.Text = "Address : ";
            // 
            // Student
            // 
            Student.BackColor = Color.FromArgb(176, 255, 176);
            Student.Location = new Point(49, 91);
            Student.Name = "Student";
            Student.Size = new Size(152, 23);
            Student.TabIndex = 8;
            // 
            // Last
            // 
            Last.BackColor = Color.FromArgb(176, 255, 176);
            Last.Location = new Point(49, 182);
            Last.Name = "Last";
            Last.Size = new Size(152, 23);
            Last.TabIndex = 9;
            // 
            // First
            // 
            First.BackColor = Color.FromArgb(176, 255, 176);
            First.Location = new Point(249, 182);
            First.Name = "First";
            First.Size = new Size(151, 23);
            First.TabIndex = 10;
            // 
            // Middle
            // 
            Middle.BackColor = Color.FromArgb(176, 255, 176);
            Middle.Location = new Point(441, 182);
            Middle.Name = "Middle";
            Middle.Size = new Size(140, 23);
            Middle.TabIndex = 11;
            // 
            // age
            // 
            age.BackColor = Color.FromArgb(176, 255, 176);
            age.Location = new Point(49, 268);
            age.Name = "age";
            age.Size = new Size(152, 23);
            age.TabIndex = 12;
            age.TextChanged += textBox5_TextChanged;
            // 
            // num
            // 
            num.BackColor = Color.FromArgb(176, 255, 176);
            num.Location = new Point(249, 268);
            num.Name = "num";
            num.Size = new Size(151, 23);
            num.TabIndex = 13;
            // 
            // Program
            // 
            Program.BackColor = Color.FromArgb(176, 255, 176);
            Program.FormattingEnabled = true;
            Program.Items.AddRange(new object[] { "BS in Information Technology" });
            Program.Location = new Point(249, 91);
            Program.Name = "Program";
            Program.Size = new Size(332, 23);
            Program.TabIndex = 14;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(176, 255, 176);
            add.Location = new Point(49, 377);
            add.Name = "add";
            add.Size = new Size(532, 23);
            add.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(204, 255, 204);
            button1.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(238, 430);
            button1.Name = "button1";
            button1.Size = new Size(139, 41);
            button1.TabIndex = 16;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 210, 147);
            ClientSize = new Size(608, 517);
            Controls.Add(button1);
            Controls.Add(add);
            Controls.Add(Program);
            Controls.Add(num);
            Controls.Add(age);
            Controls.Add(Middle);
            Controls.Add(First);
            Controls.Add(Last);
            Controls.Add(Student);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "Form Registration";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox Student;
        private TextBox Last;
        private TextBox First;
        private TextBox Middle;
        private TextBox age;
        private TextBox num;
        private ComboBox Program;
        private TextBox add;
        private Button button1;
    }
}