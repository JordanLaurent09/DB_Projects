namespace Theme_34_Lesson_6_CRUD
{
    partial class Form1
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
            newNameTB = new TextBox();
            newSurnameTB = new TextBox();
            newAgeTB = new TextBox();
            addNewStudentBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            studentsInfoLB = new ListBox();
            label5 = new Label();
            showAllDataBTN = new Button();
            SuspendLayout();
            // 
            // newNameTB
            // 
            newNameTB.Location = new Point(122, 72);
            newNameTB.Name = "newNameTB";
            newNameTB.Size = new Size(100, 23);
            newNameTB.TabIndex = 0;
            // 
            // newSurnameTB
            // 
            newSurnameTB.Location = new Point(122, 133);
            newSurnameTB.Name = "newSurnameTB";
            newSurnameTB.Size = new Size(100, 23);
            newSurnameTB.TabIndex = 1;
            // 
            // newAgeTB
            // 
            newAgeTB.Location = new Point(122, 205);
            newAgeTB.Name = "newAgeTB";
            newAgeTB.Size = new Size(100, 23);
            newAgeTB.TabIndex = 2;
            // 
            // addNewStudentBTN
            // 
            addNewStudentBTN.Location = new Point(134, 262);
            addNewStudentBTN.Name = "addNewStudentBTN";
            addNewStudentBTN.Size = new Size(75, 23);
            addNewStudentBTN.TabIndex = 3;
            addNewStudentBTN.Text = "Добавить";
            addNewStudentBTN.UseVisualStyleBackColor = true;
            addNewStudentBTN.Click += addNewStudentBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 54);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 4;
            label1.Text = "Введите имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 115);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 5;
            label2.Text = "Введите фамилию:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 187);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Введите возраст:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 9);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 7;
            label4.Text = "Добавить студента в БД";
            // 
            // studentsInfoLB
            // 
            studentsInfoLB.FormattingEnabled = true;
            studentsInfoLB.ItemHeight = 15;
            studentsInfoLB.Location = new Point(608, 72);
            studentsInfoLB.Name = "studentsInfoLB";
            studentsInfoLB.Size = new Size(296, 274);
            studentsInfoLB.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(650, 9);
            label5.Name = "label5";
            label5.Size = new Size(206, 15);
            label5.TabIndex = 9;
            label5.Text = "Просмотр информации о студентах";
            // 
            // showAllDataBTN
            // 
            showAllDataBTN.Location = new Point(659, 369);
            showAllDataBTN.Name = "showAllDataBTN";
            showAllDataBTN.Size = new Size(187, 23);
            showAllDataBTN.TabIndex = 10;
            showAllDataBTN.Text = "Вывести данные студентов";
            showAllDataBTN.UseVisualStyleBackColor = true;
            showAllDataBTN.Click += showAllDataBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 659);
            Controls.Add(showAllDataBTN);
            Controls.Add(label5);
            Controls.Add(studentsInfoLB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addNewStudentBTN);
            Controls.Add(newAgeTB);
            Controls.Add(newSurnameTB);
            Controls.Add(newNameTB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newNameTB;
        private TextBox newSurnameTB;
        private TextBox newAgeTB;
        private Button addNewStudentBTN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox studentsInfoLB;
        private Label label5;
        private Button showAllDataBTN;
    }
}
