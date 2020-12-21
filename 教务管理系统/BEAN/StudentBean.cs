using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 教务管理系统.BEAN
{

    public class StudentBean
    {
        public int Id { get; set; }
        public string SCode { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Zhuangtai { get; set; }
        public int Class_Id { get; set; }
        public string Pwd { get; set; }
        public StudentBean(int id)
        {
            Id = id;
        }

        public StudentBean(string sCode, string name, string gender, string zhuangtai, int class_Id, string pwd)
        {
            SCode = sCode;
            Name = name;
            Gender = gender;
            Zhuangtai = zhuangtai;
            Class_Id = class_Id;
            Pwd = pwd;
        }

        public StudentBean()
        {
        }
    }
}
