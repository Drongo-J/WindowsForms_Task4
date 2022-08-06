using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WindowsForms_Task4.Properties;

namespace WindowsForms_Task4
{
    public partial class StudentUC : UserControl
    {
        public string ID
        {
            get { return IdLbl.Text; }
            set { IdLbl.Text = value; }
        }

        public string Fullname
        {
            get { return FullnameLbl.Text; }
            set { FullnameLbl.Text = value; }
        }

        public string LastLogin
        {
            get { return LastLoginLbl.Text; }
            set { LastLoginLbl.Text = value; }
        }

        public Guna2CustomRadioButton InClass
        {
            get { return InclassRBtn; }
            set { InclassRBtn = value; }
        }

        public Guna2CustomRadioButton NotInClass
        {
            get { return NotInclassRBtn; }
            set { NotInclassRBtn = value; }
        }

        public StudentUC()
        {
            InitializeComponent();
            InitializeComboBoxes();

            crystalPB2.Click += crystalPB1_Click;
            crystalPB3.Click += crystalPB1_Click;
        }


        private void InitializeComboBoxes()
        {
            int max_grade = 12;
            for (int x = max_grade; x > 0; x--)
            {
                InspectionWorkGradesCB.Items.Add(x);
                ClassWorkGradesCB.Items.Add(x);
            }
        }

        bool clicked = false;

        private void ResetCrystals()
        {
            crystalPB1.Image = Resources.crystalColorless;
            crystalPB2.Image = Resources.crystalColorless;
            crystalPB3.Image = Resources.crystalColorless;
            clicked = false;
        }

        private void crystalPB1_MouseEnter(object sender, EventArgs e)
        {
            if (clicked)
            {
                ResetCrystals();
            }

            crystalPB1.Image = Resources.crystal;
        }

        private void crystalPB1_MouseLeave(object sender, EventArgs e)
        {
            if (!clicked)
            {
                crystalPB1.Image = Resources.crystalColorless;
            }
        }

        private void crystalPB2_MouseEnter(object sender, EventArgs e)
        {
            if (clicked)
            {
                ResetCrystals();
            }
            crystalPB1_MouseEnter(sender, e);
            crystalPB2.Image = Resources.crystal;
        }

        private void crystalPB2_MouseLeave(object sender, EventArgs e)
        {
            if (!clicked)
            {
                crystalPB1_MouseLeave(sender, e);
                crystalPB2.Image = Resources.crystalColorless;
            }
        }

        private void crystalPB3_MouseEnter(object sender, EventArgs e)
        {
            if (clicked)
            {
                ResetCrystals();
            }
            crystalPB2_MouseEnter(sender, e);
            crystalPB3.Image = Resources.crystal;
        }

        private void crystalPB3_MouseLeave(object sender, EventArgs e)
        {
            if (!clicked)
            {
                crystalPB2_MouseLeave(sender, e);
                crystalPB3.Image = Resources.crystalColorless;
            }
        }

        private void crystalPB1_Click(object sender, EventArgs e)
        {
            clicked = true;
            var pictureBox = sender as PictureBox;
            pictureBox.Image = Resources.crystal;
        }

        private void cancelPB_MouseEnter(object sender, EventArgs e)
        {
            cancelPB.Image = Resources.cancelColorful;
        }

        private void cancelPB_MouseLeave(object sender, EventArgs e)
        {
            cancelPB.Image = Resources.cancelColorless;
        }

        private void cancelPB_MouseClick(object sender, MouseEventArgs e)
        {
            ResetCrystals();
        }

        private void InclassRBtn_CheckedChanged(object sender, EventArgs e)
        {
            bool enable = true;

            if (!InClass.Checked)
            {
                enable = false;
            }

            foreach (var item in Controls)
            {
                if (item is Guna2ComboBox cb)
                {
                    cb.Enabled = enable;
                }
                else if (item is TextBox tb)
                {
                    tb.Enabled = enable;
                }
                else if (item is PictureBox pb)
                {
                    pb.Enabled = enable;
                }
            }
        }
    }
}
