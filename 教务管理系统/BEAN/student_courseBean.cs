using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 教务管理系统.BEAN
{
    class student_courseBean
    {
        public int Id { get; set; }
        public int Courseid { get; set; }
        public int Major { get; set; }

        public student_courseBean()
        {
        }

        public student_courseBean(int id)
        {
            Id = id;
        }

        public student_courseBean(int courseid, int major)
        {
            Courseid = courseid;
            Major = major;
        }
    }
}
