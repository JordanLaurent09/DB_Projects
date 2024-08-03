namespace Theme_32_Homework_Practice_4
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
            timeLB = new Label();
            passengersDGV = new DataGridView();
            survivedBTN = new Button();
            adultBTN = new Button();
            thirdClassBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)passengersDGV).BeginInit();
            SuspendLayout();
            // 
            // timeLB
            // 
            timeLB.AutoSize = true;
            timeLB.Location = new Point(12, 9);
            timeLB.Name = "timeLB";
            timeLB.Size = new Size(13, 15);
            timeLB.TabIndex = 0;
            timeLB.Text = "0";
            // 
            // passengersDGV
            // 
            passengersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            passengersDGV.Location = new Point(109, 46);
            passengersDGV.Name = "passengersDGV";
            passengersDGV.Size = new Size(741, 313);
            passengersDGV.TabIndex = 1;
            // 
            // survivedBTN
            // 
            survivedBTN.Location = new Point(339, 397);
            survivedBTN.Name = "survivedBTN";
            survivedBTN.Size = new Size(184, 23);
            survivedBTN.TabIndex = 2;
            survivedBTN.Text = "Выжившие";
            survivedBTN.UseVisualStyleBackColor = true;
            survivedBTN.Click += survivedBTN_Click;
            // 
            // adultBTN
            // 
            adultBTN.Location = new Point(339, 435);
            adultBTN.Name = "adultBTN";
            adultBTN.Size = new Size(184, 23);
            adultBTN.TabIndex = 3;
            adultBTN.Text = "Совершеннолетние";
            adultBTN.UseVisualStyleBackColor = true;
            adultBTN.Click += adultBTN_Click;
            // 
            // thirdClassBTN
            // 
            thirdClassBTN.Location = new Point(339, 473);
            thirdClassBTN.Name = "thirdClassBTN";
            thirdClassBTN.Size = new Size(184, 23);
            thirdClassBTN.TabIndex = 4;
            thirdClassBTN.Text = "Пассажиры третьего класса";
            thirdClassBTN.UseVisualStyleBackColor = true;
            thirdClassBTN.Click += thirdClassBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 565);
            Controls.Add(thirdClassBTN);
            Controls.Add(adultBTN);
            Controls.Add(survivedBTN);
            Controls.Add(passengersDGV);
            Controls.Add(timeLB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)passengersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLB;
        private DataGridView passengersDGV;
        private Button survivedBTN;
        private Button adultBTN;
        private Button thirdClassBTN;
    }
}
