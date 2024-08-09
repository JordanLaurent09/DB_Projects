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
            searchTB = new TextBox();
            label6 = new Label();
            label7 = new Label();
            nameRB = new RadioButton();
            surnameRB = new RadioButton();
            searchBTN = new Button();
            label8 = new Label();
            currentNameTB = new TextBox();
            currentSurnameTB = new TextBox();
            currentAgeTB = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            updateDataBTN = new Button();
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
            studentsInfoLB.Location = new Point(309, 41);
            studentsInfoLB.Name = "studentsInfoLB";
            studentsInfoLB.Size = new Size(454, 274);
            studentsInfoLB.TabIndex = 8;
            studentsInfoLB.SelectedIndexChanged += studentsInfoLB_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 9);
            label5.Name = "label5";
            label5.Size = new Size(206, 15);
            label5.TabIndex = 9;
            label5.Text = "Просмотр информации о студентах";
            // 
            // showAllDataBTN
            // 
            showAllDataBTN.Location = new Point(435, 321);
            showAllDataBTN.Name = "showAllDataBTN";
            showAllDataBTN.Size = new Size(187, 23);
            showAllDataBTN.TabIndex = 10;
            showAllDataBTN.Text = "Вывести данные студентов";
            showAllDataBTN.UseVisualStyleBackColor = true;
            showAllDataBTN.Click += showAllDataBTN_Click;
            // 
            // searchTB
            // 
            searchTB.Location = new Point(888, 59);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(160, 23);
            searchTB.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(888, 41);
            label6.Name = "label6";
            label6.Size = new Size(160, 15);
            label6.TabIndex = 12;
            label6.Text = "Введите имя или фамилию:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(912, 9);
            label7.Name = "label7";
            label7.Size = new Size(208, 15);
            label7.TabIndex = 13;
            label7.Text = "Поиск студента по имени /фамилии";
            // 
            // nameRB
            // 
            nameRB.AutoSize = true;
            nameRB.Location = new Point(888, 88);
            nameRB.Name = "nameRB";
            nameRB.Size = new Size(49, 19);
            nameRB.TabIndex = 14;
            nameRB.TabStop = true;
            nameRB.Text = "Имя";
            nameRB.UseVisualStyleBackColor = true;
            // 
            // surnameRB
            // 
            surnameRB.AutoSize = true;
            surnameRB.Location = new Point(995, 88);
            surnameRB.Name = "surnameRB";
            surnameRB.Size = new Size(76, 19);
            surnameRB.TabIndex = 15;
            surnameRB.TabStop = true;
            surnameRB.Text = "Фамилия";
            surnameRB.UseVisualStyleBackColor = true;
            // 
            // searchBTN
            // 
            searchBTN.Location = new Point(1089, 59);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(75, 23);
            searchBTN.TabIndex = 16;
            searchBTN.Text = "Поиск";
            searchBTN.UseVisualStyleBackColor = true;
            searchBTN.Click += searchBTN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(946, 141);
            label8.Name = "label8";
            label8.Size = new Size(163, 15);
            label8.TabIndex = 17;
            label8.Text = "Изменение данных студента";
            // 
            // currentNameTB
            // 
            currentNameTB.Location = new Point(888, 187);
            currentNameTB.Name = "currentNameTB";
            currentNameTB.Size = new Size(100, 23);
            currentNameTB.TabIndex = 18;
            // 
            // currentSurnameTB
            // 
            currentSurnameTB.Location = new Point(1009, 187);
            currentSurnameTB.Name = "currentSurnameTB";
            currentSurnameTB.Size = new Size(100, 23);
            currentSurnameTB.TabIndex = 19;
            // 
            // currentAgeTB
            // 
            currentAgeTB.Location = new Point(1130, 187);
            currentAgeTB.Name = "currentAgeTB";
            currentAgeTB.Size = new Size(53, 23);
            currentAgeTB.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(918, 166);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 21;
            label9.Text = "Имя:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1029, 166);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 22;
            label10.Text = "Фамилия:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1130, 166);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 23;
            label11.Text = "Возраст:";
            // 
            // updateDataBTN
            // 
            updateDataBTN.Location = new Point(959, 232);
            updateDataBTN.Name = "updateDataBTN";
            updateDataBTN.Size = new Size(150, 23);
            updateDataBTN.TabIndex = 24;
            updateDataBTN.Text = "Редактировать данные";
            updateDataBTN.UseVisualStyleBackColor = true;
            updateDataBTN.Click += updateDataBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 809);
            Controls.Add(updateDataBTN);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(currentAgeTB);
            Controls.Add(currentSurnameTB);
            Controls.Add(currentNameTB);
            Controls.Add(label8);
            Controls.Add(searchBTN);
            Controls.Add(surnameRB);
            Controls.Add(nameRB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(searchTB);
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
        private TextBox searchTB;
        private Label label6;
        private Label label7;
        private RadioButton nameRB;
        private RadioButton surnameRB;
        private Button searchBTN;
        private Label label8;
        private TextBox currentNameTB;
        private TextBox currentSurnameTB;
        private TextBox currentAgeTB;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button updateDataBTN;
    }
}
