namespace StudentCRUD
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
            this.txtStudentRollno = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtSub1Mark = new System.Windows.Forms.TextBox();
            this.txtSub2Mark = new System.Windows.Forms.TextBox();
            this.txtSub3Mark = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.StudentRollno = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.Sub1Marks = new System.Windows.Forms.Label();
            this.Sub2Mark = new System.Windows.Forms.Label();
            this.Sub3Mark = new System.Windows.Forms.Label();
            this.Percentage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStudentRollno
            // 
            this.txtStudentRollno.Location = new System.Drawing.Point(197, 39);
            this.txtStudentRollno.Name = "txtStudentRollno";
            this.txtStudentRollno.Size = new System.Drawing.Size(100, 20);
            this.txtStudentRollno.TabIndex = 0;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(197, 86);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // txtSub1Mark
            // 
            this.txtSub1Mark.Location = new System.Drawing.Point(197, 139);
            this.txtSub1Mark.Name = "txtSub1Mark";
            this.txtSub1Mark.Size = new System.Drawing.Size(100, 20);
            this.txtSub1Mark.TabIndex = 2;
            // 
            // txtSub2Mark
            // 
            this.txtSub2Mark.Location = new System.Drawing.Point(197, 191);
            this.txtSub2Mark.Name = "txtSub2Mark";
            this.txtSub2Mark.Size = new System.Drawing.Size(100, 20);
            this.txtSub2Mark.TabIndex = 3;
            // 
            // txtSub3Mark
            // 
            this.txtSub3Mark.Location = new System.Drawing.Point(197, 238);
            this.txtSub3Mark.Name = "txtSub3Mark";
            this.txtSub3Mark.Size = new System.Drawing.Size(100, 20);
            this.txtSub3Mark.TabIndex = 4;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(197, 290);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtPercentage.TabIndex = 5;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(469, 12);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(326, 211);
            this.txtShow.TabIndex = 6;
            // 
            // StudentRollno
            // 
            this.StudentRollno.AutoSize = true;
            this.StudentRollno.Location = new System.Drawing.Point(72, 39);
            this.StudentRollno.Name = "StudentRollno";
            this.StudentRollno.Size = new System.Drawing.Size(105, 13);
            this.StudentRollno.TabIndex = 7;
            this.StudentRollno.Text = "Enter Student Rollno";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(72, 86);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(103, 13);
            this.StudentName.TabIndex = 8;
            this.StudentName.Text = "Enter Student Name";
            // 
            // Sub1Marks
            // 
            this.Sub1Marks.AutoSize = true;
            this.Sub1Marks.Location = new System.Drawing.Point(72, 146);
            this.Sub1Marks.Name = "Sub1Marks";
            this.Sub1Marks.Size = new System.Drawing.Size(85, 13);
            this.Sub1Marks.TabIndex = 9;
            this.Sub1Marks.Text = "Enter sub1 Mark";
            // 
            // Sub2Mark
            // 
            this.Sub2Mark.AutoSize = true;
            this.Sub2Mark.Location = new System.Drawing.Point(72, 191);
            this.Sub2Mark.Name = "Sub2Mark";
            this.Sub2Mark.Size = new System.Drawing.Size(87, 13);
            this.Sub2Mark.TabIndex = 10;
            this.Sub2Mark.Text = "Enter Sub2 Mark";
            // 
            // Sub3Mark
            // 
            this.Sub3Mark.AutoSize = true;
            this.Sub3Mark.Location = new System.Drawing.Point(72, 245);
            this.Sub3Mark.Name = "Sub3Mark";
            this.Sub3Mark.Size = new System.Drawing.Size(87, 13);
            this.Sub3Mark.TabIndex = 11;
            this.Sub3Mark.Text = "Enter Sub3 Mark";
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Location = new System.Drawing.Point(72, 297);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(90, 13);
            this.Percentage.TabIndex = 12;
            this.Percentage.Text = "Enter Percentage";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(197, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(347, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(347, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(606, 257);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 17;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Sub3Mark);
            this.Controls.Add(this.Sub2Mark);
            this.Controls.Add(this.Sub1Marks);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.StudentRollno);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtSub3Mark);
            this.Controls.Add(this.txtSub2Mark);
            this.Controls.Add(this.txtSub1Mark);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentRollno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentRollno;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtSub1Mark;
        private System.Windows.Forms.TextBox txtSub2Mark;
        private System.Windows.Forms.TextBox txtSub3Mark;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Label StudentRollno;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label Sub1Marks;
        private System.Windows.Forms.Label Sub2Mark;
        private System.Windows.Forms.Label Sub3Mark;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
    }
}

