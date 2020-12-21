using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教务管理系统.BEAN;
using 教务管理系统.DAO;

namespace 教务管理系统.窗体
{
    public partial class studentshow : Form
    {

        /// <summary>
        /// 当前登录的学生信息
        /// </summary>
        public StudentBean student;

        /// <summary>
        /// 当前登录的班级信息
        /// </summary>
        public ClassBean classname;


        public studentshow(StudentBean student, ClassBean classname)
        {
            InitializeComponent();
            //this.ControlBox = false;   // 设置不出现关闭按钮
            this.student = student;
            label1.Text = "[姓  名]:" + student.Name;
            label2.Text = "[学  号]:" + student.SCode;
            label3.Text = "[性  别]:" + student.Gender;
            this.classname = new ClassDao().FindById(new ClassBean(student.Class_Id));
            QueryAllCourse1();
            QueryAllCourse3();
            QueryAllCourse2();
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;

        }

        private void studentshow_Load(object sender, EventArgs e)

        {
            // TODO: 这行代码将数据加载到表“s_tDataSet.course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.s_tDataSet.course);
            // TODO: 这行代码将数据加载到表“s_tDataSet.course”中。您可以根据需要移动或删除它。
            // this.courseTableAdapter.Fill(this.s_tDataSet.course);
            // TODO: 这行代码将数据加载到表“s_tDataSet.course”中。您可以根据需要移动或删除它。
            //  this.courseTableAdapter.Fill(this.s_tDataSet.course);


            if (student.Name == "程宁")
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/cn.jpg";
            }
            else if (student.Name == "王斌")
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/wb.jpg";
            }
            else if (student.Name == "马凯")
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/mk.jpg";
            }
            else if (student.Name == "冒小磊")
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/mxl.jpg";
            }
            else if (student.Name == "柳亮亮")
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/lll.jpg";
            }
            else if (student.Name == "王永贵")
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/wyg.jpg";
            }
            else if (student.Name == "马忠源")
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/mzy.jpg";
            }
            else if (student.Name == "沈孝伟")
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/sxw.jpg";
            }
        }

        private void QueryAllCourse1()
        {
            string sqlStr = "SELECT DISTINCT [student].scode AS '学号',[student].Name AS '姓名',[student].Gender AS '性别',[class].Name AS '班级名',[class].Major AS '专业',teacher.Name AS '教师',course.Cname AS '课程' FROM [student],[CLASS],[course],[student_course],[teacher],[teacher_class] WHERE [student].Class_id=[class].Id AND course.teacherid=teacher_class.teacherid AND teacher.ID=teacher_class.teacherid AND student_course.studentid=student.Id AND student_course.courseid=course.id AND student.Scode=" + student.SCode;
           
            DataTable dataTable = BaseDao<object>.FindDataTable(sqlStr);
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            if (dataTable.Rows.Count > 0)
            {
                
                //dataTable.Rows[1].Delete();
                //将数据集合的首张表绑定到dataGridView1的数据源
                this.dataGridView1.DataSource = dataTable;

            }

        }
        private void QueryAllCourse3()
        {
            string sqlStr = "SELECT Cname AS 课程名称,Ename AS 语言,score AS 学分,chour AS周理论学时,Lhour AS 周实验学时,Tchour AS 理论总学时,Tchour AS 实验总学时,teacher.Name AS 教师 FROM [dbo].[course],teacher WHERE course.teacherid=teacher.id";

            DataTable dataTable = BaseDao<object>.FindDataTable(sqlStr);

            if (dataTable != null)
            {

                //dataTable.Rows[1].Delete();
                //将数据集合的首张表绑定到dataGridView1的数据源
                this.dataGridView3.DataSource = dataTable;
            }
            else if (dataTable == null)
            {
                System.Windows.Forms.MessageBox.Show("首次使用");
            }
        }
        private void QueryAllCourse2()
        {
            string sqlStr = "SELECT DISTINCT [student].scode AS '学号',[student].Name AS '姓名',[student].Gender AS '性别',[class].Name AS '班级名',[class].Major AS '专业' FROM [student],[CLASS],[course],[student_course],[teacher],[teacher_class] WHERE [student].Class_id=[class].Id AND student.Scode=" + student.SCode;

            DataTable dataTable = BaseDao<object>.FindDataTable(sqlStr);

            if (dataTable != null)
            {

                //dataTable.Rows[1].Delete();
                //将数据集合的首张表绑定到dataGridView1的数据源
                this.dataGridView2.DataSource = dataTable;
            }
            else if (dataTable == null)
            {
                System.Windows.Forms.MessageBox.Show("首次使用");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            string sqlStr = "SELECT DISTINCT [student].scode AS '学号',[student].Name AS '姓名',[student].Gender AS '性别',[class].Name AS '班级名',[class].Major AS '专业',teacher.Name AS '教师',course.Cname AS '课程' FROM [student],[CLASS],[course],[student_course],[teacher],[teacher_class] WHERE [student].Class_id=[class].Id AND course.teacherid=teacher_class.teacherid AND teacher.ID=teacher_class.teacherid AND student_course.studentid=student.Id AND student_course.courseid=course.id AND student.Scode=" + student.SCode;

            DataTable dataTable = BaseDao<object>.FindDataTable(sqlStr);
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            if (dataTable.Rows.Count > 0)
            {

                //dataTable.Rows[1].Delete();
                //将数据集合的首张表绑定到dataGridView1的数据源
                this.dataGridView1.DataSource = dataTable;

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("暂时没有查询到选课信息！！！请尽快选课！！！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new studenteditpsw(student,classname).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

            string sqlStr = "UPDATE student_course SET courseid=(select id from course WHERE Cname='" + comboBox1.Text + "'),studentid=" + student.Id + " WHERE studentid=" + student.Id;
            DataTable dataTable = BaseDao<object>.FindDataTable(sqlStr);
            System.Windows.Forms.MessageBox.Show("选课成功，请点击学生选课信息按钮刷新！！！");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
