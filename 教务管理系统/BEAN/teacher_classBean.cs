using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 教务管理系统.BEAN
{
    class teacher_classBean
    {
        public int Id { get; set; }
        public int Classid { get; set; }
        public int Teacherid { get; set; }

        public teacher_classBean()
        {
        }

        public teacher_classBean(int id)
        {
            Id = id;
        }

        public teacher_classBean( int classid, int teacherid)
        {
            Classid = classid;
            Teacherid = teacherid;
        }
    }
}
