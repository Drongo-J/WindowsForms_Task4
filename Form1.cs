using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Task4
{
    public partial class Form1 : Form
    {
        public readonly List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            InitilaizeStudents();

        }

        private void InitilaizeStudents()
        {
            Student student1 = new Student("1", "Abbasov Hüseyn", new DateTime(2022, 3, 6));
            Student student2 = new Student("2", "Əli Əhmədov", new DateTime(2022, 7, 24));
            Student student3 = new Student("3", "Ayxan Əhmədzadə", new DateTime(2022, 1, 11));
            Student student4 = new Student("4", "Məhəmməd Bayramov", new DateTime(2022, 8, 8));
            Student student5 = new Student("5", "Ömər Cavanşirli", new DateTime(2022, 7, 19));
            Student student6 = new Student("6", "Coşqun Gülməmmədli", new DateTime(2022, 6, 9));
            Student student7 = new Student("7", "Nurlan Şirinov", new DateTime(2022, 2, 9));
            Student student8 = new Student("8", "İlkin Süleymanov", new DateTime(2022, 4, 12));
            Student student9 = new Student("9", "Alirza Zaidov", new DateTime(2022, 6, 21));
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);
            students.Add(student8);
            students.Add(student9);

            int x = 0;
            int y = 0;

            foreach (Student student in students)
            {
                StudentUC studentUC = new StudentUC();
                studentUC.Location = new Point(x, y);
                y += 100;

                studentUC.ID = student.ID;
                studentUC.Fullname = student.Fullname;
                studentUC.LastLogin = student.LastLogin.ToShortDateString();

                StudentsPanel.Controls.Add(studentUC);
            }
        }

        private void NoteEverybodyBtn_Click(object sender, EventArgs e)
        {
            if (NoteEverybodyBtn.Checked)
            {
                NoteEverybodyBtn.FillColor = Color.Lime;
                foreach (StudentUC studentUC in StudentsPanel.Controls)
                {
                    studentUC.InClass.BackColor = Color.Lime;  // Bu 2 setir kod tekce cevrenin icini deyisir
                    studentUC.InClass.BackColor = Color.White; // Bu 2 setir kod tekce cevrenin icini deyisir

                    studentUC.InClass.Checked = true;
                }
            }
            else
            {
                NoteEverybodyBtn.FillColor = Color.White;
                foreach (StudentUC studentUC in StudentsPanel.Controls)
                {
                    studentUC.InClass.BackColor = Color.White;

                    studentUC.NotInClass.Checked = true;
                }
            }
        }

        private void RefuseBtn_Click(object sender, EventArgs e)
        {
            LessonTopicTextB.Text = String.Empty;
        }
    }
}
