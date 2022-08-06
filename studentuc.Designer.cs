namespace WindowsForms_Task4
{
    partial class StudentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdLbl = new System.Windows.Forms.Label();
            this.FullnameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClassWorkGradesCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LastLoginLbl = new System.Windows.Forms.Label();
            this.YellowBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.NotInclassRBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.InclassRBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.InspectionWorkGradesCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.crystalPB1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.crystalPB2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.crystalPB3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cancelPB = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalPB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPB)).BeginInit();
            this.SuspendLayout();
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.Location = new System.Drawing.Point(12, 40);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(50, 16);
            this.IdLbl.TabIndex = 0;
            this.IdLbl.Text = "label1";
            // 
            // FullnameLbl
            // 
            this.FullnameLbl.AutoSize = true;
            this.FullnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameLbl.Location = new System.Drawing.Point(98, 34);
            this.FullnameLbl.Name = "FullnameLbl";
            this.FullnameLbl.Size = new System.Drawing.Size(70, 25);
            this.FullnameLbl.TabIndex = 1;
            this.FullnameLbl.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsForms_Task4.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(47, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ClassWorkGradesCB
            // 
            this.ClassWorkGradesCB.BackColor = System.Drawing.Color.Transparent;
            this.ClassWorkGradesCB.BorderColor = System.Drawing.Color.Lime;
            this.ClassWorkGradesCB.BorderRadius = 4;
            this.ClassWorkGradesCB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ClassWorkGradesCB.BorderThickness = 2;
            this.ClassWorkGradesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClassWorkGradesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassWorkGradesCB.Enabled = false;
            this.ClassWorkGradesCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClassWorkGradesCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClassWorkGradesCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ClassWorkGradesCB.ForeColor = System.Drawing.Color.DimGray;
            this.ClassWorkGradesCB.ItemHeight = 30;
            this.ClassWorkGradesCB.Location = new System.Drawing.Point(957, 31);
            this.ClassWorkGradesCB.Name = "ClassWorkGradesCB";
            this.ClassWorkGradesCB.Size = new System.Drawing.Size(73, 36);
            this.ClassWorkGradesCB.TabIndex = 17;
            // 
            // LastLoginLbl
            // 
            this.LastLoginLbl.AutoSize = true;
            this.LastLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLoginLbl.Location = new System.Drawing.Point(353, 34);
            this.LastLoginLbl.Name = "LastLoginLbl";
            this.LastLoginLbl.Size = new System.Drawing.Size(70, 25);
            this.LastLoginLbl.TabIndex = 25;
            this.LastLoginLbl.Text = "label1";
            // 
            // YellowBtn
            // 
            this.YellowBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.YellowBtn.CheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.YellowBtn.CheckedState.BorderThickness = 3;
            this.YellowBtn.CheckedState.FillColor = System.Drawing.Color.Yellow;
            this.YellowBtn.CheckedState.InnerColor = System.Drawing.Color.Yellow;
            this.YellowBtn.Location = new System.Drawing.Point(609, 36);
            this.YellowBtn.Name = "YellowBtn";
            this.YellowBtn.Size = new System.Drawing.Size(18, 18);
            this.YellowBtn.TabIndex = 30;
            this.YellowBtn.Text = "guna2CustomRadioButton2";
            this.YellowBtn.UncheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.YellowBtn.UncheckedState.BorderThickness = 3;
            this.YellowBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.YellowBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // NotInclassRBtn
            // 
            this.NotInclassRBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.NotInclassRBtn.Checked = true;
            this.NotInclassRBtn.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.NotInclassRBtn.CheckedState.BorderThickness = 3;
            this.NotInclassRBtn.CheckedState.FillColor = System.Drawing.Color.Red;
            this.NotInclassRBtn.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.NotInclassRBtn.Location = new System.Drawing.Point(666, 36);
            this.NotInclassRBtn.Name = "NotInclassRBtn";
            this.NotInclassRBtn.Size = new System.Drawing.Size(18, 18);
            this.NotInclassRBtn.TabIndex = 32;
            this.NotInclassRBtn.Text = "guna2CustomRadioButton4";
            this.NotInclassRBtn.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.NotInclassRBtn.UncheckedState.BorderThickness = 3;
            this.NotInclassRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.NotInclassRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // InclassRBtn
            // 
            this.InclassRBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.InclassRBtn.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.InclassRBtn.CheckedState.BorderThickness = 3;
            this.InclassRBtn.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.InclassRBtn.CheckedState.InnerColor = System.Drawing.Color.Lime;
            this.InclassRBtn.Location = new System.Drawing.Point(557, 36);
            this.InclassRBtn.Name = "InclassRBtn";
            this.InclassRBtn.Size = new System.Drawing.Size(18, 18);
            this.InclassRBtn.TabIndex = 29;
            this.InclassRBtn.Text = "guna2CustomRadioButton1";
            this.InclassRBtn.UncheckedState.BorderColor = System.Drawing.Color.Lime;
            this.InclassRBtn.UncheckedState.BorderThickness = 3;
            this.InclassRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.InclassRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.InclassRBtn.CheckedChanged += new System.EventHandler(this.InclassRBtn_CheckedChanged);
            // 
            // InspectionWorkGradesCB
            // 
            this.InspectionWorkGradesCB.BackColor = System.Drawing.Color.Transparent;
            this.InspectionWorkGradesCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.InspectionWorkGradesCB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.InspectionWorkGradesCB.BorderThickness = 2;
            this.InspectionWorkGradesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.InspectionWorkGradesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InspectionWorkGradesCB.Enabled = false;
            this.InspectionWorkGradesCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InspectionWorkGradesCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InspectionWorkGradesCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InspectionWorkGradesCB.ForeColor = System.Drawing.Color.DimGray;
            this.InspectionWorkGradesCB.ItemHeight = 30;
            this.InspectionWorkGradesCB.Location = new System.Drawing.Point(779, 31);
            this.InspectionWorkGradesCB.Name = "InspectionWorkGradesCB";
            this.InspectionWorkGradesCB.Size = new System.Drawing.Size(73, 36);
            this.InspectionWorkGradesCB.TabIndex = 33;
            // 
            // crystalPB1
            // 
            this.crystalPB1.Enabled = false;
            this.crystalPB1.Image = global::WindowsForms_Task4.Properties.Resources.crystalColorless;
            this.crystalPB1.ImageRotate = 0F;
            this.crystalPB1.Location = new System.Drawing.Point(1075, 30);
            this.crystalPB1.Name = "crystalPB1";
            this.crystalPB1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.crystalPB1.Size = new System.Drawing.Size(41, 42);
            this.crystalPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crystalPB1.TabIndex = 34;
            this.crystalPB1.TabStop = false;
            this.crystalPB1.Click += new System.EventHandler(this.crystalPB1_Click);
            this.crystalPB1.MouseEnter += new System.EventHandler(this.crystalPB1_MouseEnter);
            this.crystalPB1.MouseLeave += new System.EventHandler(this.crystalPB1_MouseLeave);
            // 
            // crystalPB2
            // 
            this.crystalPB2.Enabled = false;
            this.crystalPB2.Image = global::WindowsForms_Task4.Properties.Resources.crystalColorless;
            this.crystalPB2.ImageRotate = 0F;
            this.crystalPB2.Location = new System.Drawing.Point(1110, 30);
            this.crystalPB2.Name = "crystalPB2";
            this.crystalPB2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.crystalPB2.Size = new System.Drawing.Size(41, 42);
            this.crystalPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crystalPB2.TabIndex = 36;
            this.crystalPB2.TabStop = false;
            this.crystalPB2.MouseEnter += new System.EventHandler(this.crystalPB2_MouseEnter);
            this.crystalPB2.MouseLeave += new System.EventHandler(this.crystalPB2_MouseLeave);
            // 
            // crystalPB3
            // 
            this.crystalPB3.Enabled = false;
            this.crystalPB3.Image = global::WindowsForms_Task4.Properties.Resources.crystalColorless;
            this.crystalPB3.ImageRotate = 0F;
            this.crystalPB3.Location = new System.Drawing.Point(1145, 30);
            this.crystalPB3.Name = "crystalPB3";
            this.crystalPB3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.crystalPB3.Size = new System.Drawing.Size(41, 42);
            this.crystalPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crystalPB3.TabIndex = 37;
            this.crystalPB3.TabStop = false;
            this.crystalPB3.MouseEnter += new System.EventHandler(this.crystalPB3_MouseEnter);
            this.crystalPB3.MouseLeave += new System.EventHandler(this.crystalPB3_MouseLeave);
            // 
            // cancelPB
            // 
            this.cancelPB.Enabled = false;
            this.cancelPB.Image = global::WindowsForms_Task4.Properties.Resources.cancelColorless;
            this.cancelPB.InitialImage = global::WindowsForms_Task4.Properties.Resources.cancelColorful;
            this.cancelPB.Location = new System.Drawing.Point(1187, 33);
            this.cancelPB.Name = "cancelPB";
            this.cancelPB.Size = new System.Drawing.Size(37, 37);
            this.cancelPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cancelPB.TabIndex = 38;
            this.cancelPB.TabStop = false;
            this.cancelPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelPB_MouseClick);
            this.cancelPB.MouseEnter += new System.EventHandler(this.cancelPB_MouseEnter);
            this.cancelPB.MouseLeave += new System.EventHandler(this.cancelPB_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1251, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 57);
            this.textBox1.TabIndex = 39;
            // 
            // StudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelPB);
            this.Controls.Add(this.crystalPB3);
            this.Controls.Add(this.crystalPB2);
            this.Controls.Add(this.crystalPB1);
            this.Controls.Add(this.NotInclassRBtn);
            this.Controls.Add(this.YellowBtn);
            this.Controls.Add(this.InclassRBtn);
            this.Controls.Add(this.LastLoginLbl);
            this.Controls.Add(this.ClassWorkGradesCB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FullnameLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.InspectionWorkGradesCB);
            this.Name = "StudentUC";
            this.Size = new System.Drawing.Size(1480, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalPB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label FullnameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ClassWorkGradesCB;
        private System.Windows.Forms.Label LastLoginLbl;
        private Guna.UI2.WinForms.Guna2CustomRadioButton YellowBtn;
        private Guna.UI2.WinForms.Guna2CustomRadioButton NotInclassRBtn;
        private Guna.UI2.WinForms.Guna2CustomRadioButton InclassRBtn;
        private Guna.UI2.WinForms.Guna2ComboBox InspectionWorkGradesCB;
        private Guna.UI2.WinForms.Guna2CirclePictureBox crystalPB1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox crystalPB2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox crystalPB3;
        private System.Windows.Forms.PictureBox cancelPB;
        private System.Windows.Forms.TextBox textBox1;
    }
}
