using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 教务管理系统.BEAN
{
    public class ClassBean
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Major{ get; set; }

        public ClassBean()
        {
        }

        public ClassBean(int id)
        {
            Id = id;
        }

        public ClassBean(string name, int major)
        {
            Name = name;
            Major = major;
        }
    }
}
