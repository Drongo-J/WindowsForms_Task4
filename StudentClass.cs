using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Task4
{
    public class Student
    {
        public Student(string _ID, string fullname, DateTime lastLogin)
        {
            ID = _ID;
            Fullname = fullname;
            LastLogin = lastLogin;
        }

        public string ID { get; set; }
        public string Fullname { get; set; }
        public DateTime LastLogin { get; set; }
        public int Grade { get; set; }
    }
}
