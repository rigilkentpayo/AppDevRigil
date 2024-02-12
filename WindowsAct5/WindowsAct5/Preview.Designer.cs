namespace WindowsAct5
{
    partial class Preview
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
            lblName = new Label();
            lblCountry = new Label();
            lblGender = new Label();
            lblHobby = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 59);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 102);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 143);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 8;
            label3.Text = "Sex";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(145, 187);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 9;
            label4.Text = "Hobbies";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(145, 231);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 10;
            label5.Text = "Status";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(322, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(148, 25);
            lblName.TabIndex = 11;
            lblName.Text = "Customer Name";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountry.Location = new Point(322, 102);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(148, 25);
            lblCountry.TabIndex = 12;
            lblCountry.Text = "Customer Name";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(322, 143);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(148, 25);
            lblGender.TabIndex = 13;
            lblGender.Text = "Customer Name";
            // 
            // lblHobby
            // 
            lblHobby.AutoSize = true;
            lblHobby.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHobby.Location = new Point(322, 187);
            lblHobby.Name = "lblHobby";
            lblHobby.Size = new Size(148, 25);
            lblHobby.TabIndex = 14;
            lblHobby.Text = "Customer Name";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(322, 231);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(148, 25);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Customer Name";
            // 
            // Preview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(lblHobby);
            Controls.Add(lblGender);
            Controls.Add(lblCountry);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Preview";
            Text = "CustomerDataEntry";
            Load += Preview_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblName;
        private Label lblCountry;
        private Label lblGender;
        private Label lblHobby;
        private Label lblStatus;
    }
}
