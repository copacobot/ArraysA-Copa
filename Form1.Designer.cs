namespace ArraysA___Curtis_Copa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxStudentName = new System.Windows.Forms.TextBox();
            this.txtboxGrade = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonDisplayArray = new System.Windows.Forms.Button();
            this.lblStudentData = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxpercent1 = new System.Windows.Forms.Label();
            this.boxpercent2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtboxStudentName
            // 
            this.txtboxStudentName.Location = new System.Drawing.Point(69, 162);
            this.txtboxStudentName.Name = "txtboxStudentName";
            this.txtboxStudentName.Size = new System.Drawing.Size(153, 20);
            this.txtboxStudentName.TabIndex = 1;
            // 
            // txtboxGrade
            // 
            this.txtboxGrade.Location = new System.Drawing.Point(289, 162);
            this.txtboxGrade.Name = "txtboxGrade";
            this.txtboxGrade.Size = new System.Drawing.Size(216, 20);
            this.txtboxGrade.TabIndex = 2;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(190, 210);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(170, 23);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Text = "Add Student to Grading Array";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonDisplayArray
            // 
            this.buttonDisplayArray.Location = new System.Drawing.Point(69, 285);
            this.buttonDisplayArray.Name = "buttonDisplayArray";
            this.buttonDisplayArray.Size = new System.Drawing.Size(410, 23);
            this.buttonDisplayArray.TabIndex = 4;
            this.buttonDisplayArray.Text = "Display Array - Display Each Student\'s Info from the Stored Array and Calculate A" +
    "verage";
            this.buttonDisplayArray.UseVisualStyleBackColor = true;
            this.buttonDisplayArray.Click += new System.EventHandler(this.buttonDisplayArray_Click);
            // 
            // lblStudentData
            // 
            this.lblStudentData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStudentData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentData.Location = new System.Drawing.Point(42, 337);
            this.lblStudentData.Name = "lblStudentData";
            this.lblStudentData.Size = new System.Drawing.Size(463, 139);
            this.lblStudentData.TabIndex = 5;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(86, 516);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(393, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear Text Box and Array and Reset Student Counter/Array Index";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course Grade";
            // 
            // boxpercent1
            // 
            this.boxpercent1.AutoSize = true;
            this.boxpercent1.Location = new System.Drawing.Point(228, 165);
            this.boxpercent1.Name = "boxpercent1";
            this.boxpercent1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxpercent1.Size = new System.Drawing.Size(15, 13);
            this.boxpercent1.TabIndex = 9;
            this.boxpercent1.Text = "%";
            // 
            // boxpercent2
            // 
            this.boxpercent2.AutoSize = true;
            this.boxpercent2.Location = new System.Drawing.Point(511, 165);
            this.boxpercent2.Name = "boxpercent2";
            this.boxpercent2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxpercent2.Size = new System.Drawing.Size(15, 13);
            this.boxpercent2.TabIndex = 10;
            this.boxpercent2.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 578);
            this.Controls.Add(this.boxpercent2);
            this.Controls.Add(this.boxpercent1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.lblStudentData);
            this.Controls.Add(this.buttonDisplayArray);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.txtboxGrade);
            this.Controls.Add(this.txtboxStudentName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxStudentName;
        private System.Windows.Forms.TextBox txtboxGrade;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonDisplayArray;
        private System.Windows.Forms.Label lblStudentData;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label boxpercent1;
        private System.Windows.Forms.Label boxpercent2;
    }
}

