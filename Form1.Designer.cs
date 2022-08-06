namespace WindowsForms_Task4
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
            this.GroupHeadlineLbl = new System.Windows.Forms.Label();
            this.LessonNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LessonTopicTextB = new System.Windows.Forms.TextBox();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RefuseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HeadlinePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.NoteEverybodyBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.CommentLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CrystalCountLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ClassWorkLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InspectionWorksLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NoteEverybodyLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LoggedInLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StudentNameSurnameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MainTeacherRB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.TheTeacherIsReplacedRB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.StudentsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.CrystalPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeadlinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupHeadlineLbl
            // 
            this.GroupHeadlineLbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupHeadlineLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GroupHeadlineLbl.Location = new System.Drawing.Point(13, 18);
            this.GroupHeadlineLbl.Name = "GroupHeadlineLbl";
            this.GroupHeadlineLbl.Size = new System.Drawing.Size(144, 36);
            this.GroupHeadlineLbl.TabIndex = 0;
            this.GroupHeadlineLbl.Text = "FBES_3212_az";
            // 
            // LessonNameLbl
            // 
            this.LessonNameLbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonNameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LessonNameLbl.Location = new System.Drawing.Point(189, 18);
            this.LessonNameLbl.Name = "LessonNameLbl";
            this.LessonNameLbl.Size = new System.Drawing.Size(867, 36);
            this.LessonNameLbl.TabIndex = 1;
            this.LessonNameLbl.Text = " Основы разработки приложений с использованием Windows Forms и WPF (СТ-3)) ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(908, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lesson Topic";
            // 
            // LessonTopicTextB
            // 
            this.LessonTopicTextB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonTopicTextB.ForeColor = System.Drawing.Color.DimGray;
            this.LessonTopicTextB.Location = new System.Drawing.Point(912, 101);
            this.LessonTopicTextB.Multiline = true;
            this.LessonTopicTextB.Name = "LessonTopicTextB";
            this.LessonTopicTextB.Size = new System.Drawing.Size(321, 66);
            this.LessonTopicTextB.TabIndex = 3;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BorderRadius = 5;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(1253, 101);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 28);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            // 
            // RefuseBtn
            // 
            this.RefuseBtn.BorderRadius = 5;
            this.RefuseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefuseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefuseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefuseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefuseBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.RefuseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefuseBtn.ForeColor = System.Drawing.Color.White;
            this.RefuseBtn.Location = new System.Drawing.Point(1253, 144);
            this.RefuseBtn.Name = "RefuseBtn";
            this.RefuseBtn.Size = new System.Drawing.Size(110, 28);
            this.RefuseBtn.TabIndex = 8;
            this.RefuseBtn.Text = "Refuse";
            this.RefuseBtn.Click += new System.EventHandler(this.RefuseBtn_Click);
            // 
            // HeadlinePanel
            // 
            this.HeadlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.HeadlinePanel.BorderColor = System.Drawing.Color.DodgerBlue;
            this.HeadlinePanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.HeadlinePanel.BorderThickness = 2;
            this.HeadlinePanel.Controls.Add(this.NoteEverybodyBtn);
            this.HeadlinePanel.Controls.Add(this.CommentLbl);
            this.HeadlinePanel.Controls.Add(this.CrystalPictureBox);
            this.HeadlinePanel.Controls.Add(this.CrystalCountLbl);
            this.HeadlinePanel.Controls.Add(this.ClassWorkLbl);
            this.HeadlinePanel.Controls.Add(this.InspectionWorksLbl);
            this.HeadlinePanel.Controls.Add(this.NoteEverybodyLbl);
            this.HeadlinePanel.Controls.Add(this.LoggedInLbl);
            this.HeadlinePanel.Controls.Add(this.StudentNameSurnameLbl);
            this.HeadlinePanel.Location = new System.Drawing.Point(-15, 188);
            this.HeadlinePanel.Name = "HeadlinePanel";
            this.HeadlinePanel.Size = new System.Drawing.Size(1500, 80);
            this.HeadlinePanel.TabIndex = 9;
            // 
            // NoteEverybodyBtn
            // 
            this.NoteEverybodyBtn.BorderColor = System.Drawing.Color.Lime;
            this.NoteEverybodyBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.NoteEverybodyBtn.BorderThickness = 3;
            this.NoteEverybodyBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.NoteEverybodyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NoteEverybodyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NoteEverybodyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NoteEverybodyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NoteEverybodyBtn.FillColor = System.Drawing.Color.White;
            this.NoteEverybodyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NoteEverybodyBtn.ForeColor = System.Drawing.Color.White;
            this.NoteEverybodyBtn.Location = new System.Drawing.Point(624, 45);
            this.NoteEverybodyBtn.Name = "NoteEverybodyBtn";
            this.NoteEverybodyBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.NoteEverybodyBtn.Size = new System.Drawing.Size(18, 18);
            this.NoteEverybodyBtn.TabIndex = 0;
            this.NoteEverybodyBtn.Text = "guna2CircleButton1";
            this.NoteEverybodyBtn.Click += new System.EventHandler(this.NoteEverybodyBtn_Click);
            // 
            // CommentLbl
            // 
            this.CommentLbl.BackColor = System.Drawing.Color.Transparent;
            this.CommentLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CommentLbl.Location = new System.Drawing.Point(1302, 30);
            this.CommentLbl.Name = "CommentLbl";
            this.CommentLbl.Size = new System.Drawing.Size(76, 25);
            this.CommentLbl.TabIndex = 12;
            this.CommentLbl.Text = "Comment";
            // 
            // CrystalCountLbl
            // 
            this.CrystalCountLbl.BackColor = System.Drawing.Color.Transparent;
            this.CrystalCountLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrystalCountLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CrystalCountLbl.Location = new System.Drawing.Point(1133, 30);
            this.CrystalCountLbl.Name = "CrystalCountLbl";
            this.CrystalCountLbl.Size = new System.Drawing.Size(12, 25);
            this.CrystalCountLbl.TabIndex = 5;
            this.CrystalCountLbl.Text = "5";
            // 
            // ClassWorkLbl
            // 
            this.ClassWorkLbl.BackColor = System.Drawing.Color.Transparent;
            this.ClassWorkLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassWorkLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClassWorkLbl.Location = new System.Drawing.Point(964, 30);
            this.ClassWorkLbl.Name = "ClassWorkLbl";
            this.ClassWorkLbl.Size = new System.Drawing.Size(89, 25);
            this.ClassWorkLbl.TabIndex = 4;
            this.ClassWorkLbl.Text = "Class Work";
            // 
            // InspectionWorksLbl
            // 
            this.InspectionWorksLbl.BackColor = System.Drawing.Color.Transparent;
            this.InspectionWorksLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspectionWorksLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.InspectionWorksLbl.Location = new System.Drawing.Point(766, 30);
            this.InspectionWorksLbl.Name = "InspectionWorksLbl";
            this.InspectionWorksLbl.Size = new System.Drawing.Size(136, 25);
            this.InspectionWorksLbl.TabIndex = 3;
            this.InspectionWorksLbl.Text = "Inspection Works";
            // 
            // NoteEverybodyLbl
            // 
            this.NoteEverybodyLbl.BackColor = System.Drawing.Color.Transparent;
            this.NoteEverybodyLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteEverybodyLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NoteEverybodyLbl.Location = new System.Drawing.Point(573, 14);
            this.NoteEverybodyLbl.Name = "NoteEverybodyLbl";
            this.NoteEverybodyLbl.Size = new System.Drawing.Size(124, 25);
            this.NoteEverybodyLbl.TabIndex = 2;
            this.NoteEverybodyLbl.Text = "Note Everybody";
            // 
            // LoggedInLbl
            // 
            this.LoggedInLbl.BackColor = System.Drawing.Color.Transparent;
            this.LoggedInLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoggedInLbl.Location = new System.Drawing.Point(356, 30);
            this.LoggedInLbl.Name = "LoggedInLbl";
            this.LoggedInLbl.Size = new System.Drawing.Size(154, 25);
            this.LoggedInLbl.TabIndex = 1;
            this.LoggedInLbl.Text = "Logged in to MyStat";
            // 
            // StudentNameSurnameLbl
            // 
            this.StudentNameSurnameLbl.BackColor = System.Drawing.Color.Transparent;
            this.StudentNameSurnameLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameSurnameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StudentNameSurnameLbl.Location = new System.Drawing.Point(78, 30);
            this.StudentNameSurnameLbl.Name = "StudentNameSurnameLbl";
            this.StudentNameSurnameLbl.Size = new System.Drawing.Size(198, 25);
            this.StudentNameSurnameLbl.TabIndex = 0;
            this.StudentNameSurnameLbl.Text = "Student\'s Name, Surname";
            // 
            // MainTeacherRB
            // 
            this.MainTeacherRB.AutoSize = true;
            this.MainTeacherRB.Checked = true;
            this.MainTeacherRB.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.MainTeacherRB.CheckedState.BorderThickness = 3;
            this.MainTeacherRB.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.MainTeacherRB.CheckedState.InnerColor = System.Drawing.Color.DodgerBlue;
            this.MainTeacherRB.CheckedState.InnerOffset = -4;
            this.MainTeacherRB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTeacherRB.Location = new System.Drawing.Point(29, 58);
            this.MainTeacherRB.Name = "MainTeacherRB";
            this.MainTeacherRB.Size = new System.Drawing.Size(91, 20);
            this.MainTeacherRB.TabIndex = 10;
            this.MainTeacherRB.TabStop = true;
            this.MainTeacherRB.Text = "Main Teacher";
            this.MainTeacherRB.UncheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.MainTeacherRB.UncheckedState.BorderThickness = 3;
            this.MainTeacherRB.UncheckedState.FillColor = System.Drawing.Color.White;
            this.MainTeacherRB.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.MainTeacherRB.UncheckedState.InnerOffset = -4;
            // 
            // TheTeacherIsReplacedRB
            // 
            this.TheTeacherIsReplacedRB.AutoSize = true;
            this.TheTeacherIsReplacedRB.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TheTeacherIsReplacedRB.CheckedState.BorderThickness = 0;
            this.TheTeacherIsReplacedRB.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.TheTeacherIsReplacedRB.CheckedState.InnerColor = System.Drawing.Color.DodgerBlue;
            this.TheTeacherIsReplacedRB.CheckedState.InnerOffset = -4;
            this.TheTeacherIsReplacedRB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheTeacherIsReplacedRB.Location = new System.Drawing.Point(129, 58);
            this.TheTeacherIsReplacedRB.Name = "TheTeacherIsReplacedRB";
            this.TheTeacherIsReplacedRB.Size = new System.Drawing.Size(136, 20);
            this.TheTeacherIsReplacedRB.TabIndex = 11;
            this.TheTeacherIsReplacedRB.Text = "The teacher is replaced";
            this.TheTeacherIsReplacedRB.UncheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TheTeacherIsReplacedRB.UncheckedState.BorderThickness = 2;
            this.TheTeacherIsReplacedRB.UncheckedState.FillColor = System.Drawing.Color.White;
            this.TheTeacherIsReplacedRB.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TheTeacherIsReplacedRB.UncheckedState.InnerOffset = -4;
            // 
            // StudentsPanel
            // 
            this.StudentsPanel.AutoScroll = true;
            this.StudentsPanel.Location = new System.Drawing.Point(-1, 274);
            this.StudentsPanel.Name = "StudentsPanel";
            this.StudentsPanel.Size = new System.Drawing.Size(1465, 379);
            this.StudentsPanel.TabIndex = 12;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // CrystalPictureBox
            // 
            this.CrystalPictureBox.Image = global::WindowsForms_Task4.Properties.Resources.crystal;
            this.CrystalPictureBox.Location = new System.Drawing.Point(1151, 24);
            this.CrystalPictureBox.Name = "CrystalPictureBox";
            this.CrystalPictureBox.Size = new System.Drawing.Size(38, 37);
            this.CrystalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CrystalPictureBox.TabIndex = 11;
            this.CrystalPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsForms_Task4.Properties.Resources.pencil1;
            this.pictureBox1.Image = global::WindowsForms_Task4.Properties.Resources.pencil;
            this.pictureBox1.Location = new System.Drawing.Point(1033, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 649);
            this.Controls.Add(this.StudentsPanel);
            this.Controls.Add(this.TheTeacherIsReplacedRB);
            this.Controls.Add(this.MainTeacherRB);
            this.Controls.Add(this.HeadlinePanel);
            this.Controls.Add(this.RefuseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LessonTopicTextB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LessonNameLbl);
            this.Controls.Add(this.GroupHeadlineLbl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.HeadlinePanel.ResumeLayout(false);
            this.HeadlinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GroupHeadlineLbl;
        private System.Windows.Forms.Label LessonNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LessonTopicTextB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2Button RefuseBtn;
        private Guna.UI2.WinForms.Guna2Panel HeadlinePanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel StudentNameSurnameLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel LoggedInLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel CrystalCountLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel ClassWorkLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel InspectionWorksLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel NoteEverybodyLbl;
        private System.Windows.Forms.PictureBox CrystalPictureBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel CommentLbl;
        private Guna.UI2.WinForms.Guna2RadioButton MainTeacherRB;
        private Guna.UI2.WinForms.Guna2RadioButton TheTeacherIsReplacedRB;
        private Guna.UI2.WinForms.Guna2Panel StudentsPanel;
        private Guna.UI2.WinForms.Guna2CircleButton NoteEverybodyBtn;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
    }
}

