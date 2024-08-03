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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 565);
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
    }
}
