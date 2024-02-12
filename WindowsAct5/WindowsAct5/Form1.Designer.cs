namespace WindowsAct5
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
            button1 = new Button();
            label1 = new Label();
            radioMarried = new RadioButton();
            radioUnmarried = new RadioButton();
            Status = new GroupBox();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            groupBox1 = new GroupBox();
            cmbCountry = new ComboBox();
            txtName = new TextBox();
            label2 = new Label();
            chkReading = new CheckBox();
            chkPaint = new CheckBox();
            groupBox2 = new GroupBox();
            Status.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(361, 395);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Preview";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 55);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // radioMarried
            // 
            radioMarried.AutoSize = true;
            radioMarried.Location = new Point(54, 22);
            radioMarried.Name = "radioMarried";
            radioMarried.Size = new Size(66, 19);
            radioMarried.TabIndex = 0;
            radioMarried.TabStop = true;
            radioMarried.Text = "Married";
            radioMarried.UseVisualStyleBackColor = true;
            // 
            // radioUnmarried
            // 
            radioUnmarried.AutoSize = true;
            radioUnmarried.Location = new Point(205, 22);
            radioUnmarried.Name = "radioUnmarried";
            radioUnmarried.Size = new Size(81, 19);
            radioUnmarried.TabIndex = 1;
            radioUnmarried.TabStop = true;
            radioUnmarried.Text = "Unmarried";
            radioUnmarried.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            Status.Controls.Add(radioUnmarried);
            Status.Controls.Add(radioMarried);
            Status.Location = new Point(145, 319);
            Status.Name = "Status";
            Status.Size = new Size(366, 62);
            Status.TabIndex = 5;
            Status.TabStop = false;
            Status.Text = "Status";
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(54, 22);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(51, 19);
            radioMale.TabIndex = 0;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(205, 22);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(63, 19);
            radioFemale.TabIndex = 1;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioFemale);
            groupBox1.Controls.Add(radioMale);
            groupBox1.Location = new Point(145, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 62);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Items.AddRange(new object[] { "Philippines", "Bangladesh" });
            cmbCountry.Location = new Point(323, 106);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(188, 23);
            cmbCountry.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(323, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 23);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 101);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Country";
            // 
            // chkReading
            // 
            chkReading.AutoSize = true;
            chkReading.Location = new Point(54, 22);
            chkReading.Name = "chkReading";
            chkReading.Size = new Size(69, 19);
            chkReading.TabIndex = 0;
            chkReading.Text = "Reading";
            chkReading.UseVisualStyleBackColor = true;
            // 
            // chkPaint
            // 
            chkPaint.AutoSize = true;
            chkPaint.Location = new Point(203, 22);
            chkPaint.Name = "chkPaint";
            chkPaint.Size = new Size(70, 19);
            chkPaint.TabIndex = 1;
            chkPaint.Text = "Painting";
            chkPaint.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkPaint);
            groupBox2.Controls.Add(chkReading);
            groupBox2.Location = new Point(145, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 62);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hobbies";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(Status);
            Controls.Add(groupBox1);
            Controls.Add(cmbCountry);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CustomerDataEntry";
            Status.ResumeLayout(false);
            Status.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private RadioButton radioMarried;
        private RadioButton radioUnmarried;
        private GroupBox Status;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private GroupBox groupBox1;
        private ComboBox cmbCountry;
        private TextBox txtName;
        private Label label2;
        private CheckBox chkReading;
        private CheckBox chkPaint;
        private GroupBox groupBox2;
    }
}
