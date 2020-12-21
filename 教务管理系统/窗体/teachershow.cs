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
    public partial class teachershow : Form
    {
        /// <summary>
        /// 当前登录的学生信息
        /// </summary>
        public TeacherBean student;
        /// <summary>
        /// 当前登录的学生信息
        /// </summary>
        public ClassBean classname;
        public teachershow(TeacherBean student)
        {
           
            InitializeComponent();
            //this.ControlBox = false;   // 设置不出现关闭按钮
            this.student = student;
            label1.Text = "[姓  名]:" + student.Name+ "[工  号]:" + student.TCode;
            label2.Text = "[学  位]:" + student.Degree;
            label3.Text = "[职  务]:" + student.Title;
            this.student = new TeacherDao().FindById(new TeacherBean(student.Id));
            QueryAllCourse1();

            QueryAllCourse2();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;

        }
        private void QueryAllCourse1()
        {
            string sqlStr = "SELECT DISTINCT [teacher].tcode AS '工号',[teacher].Name AS '姓名',[teacher].Gender AS '性别',teacher.Title AS '职务',teacher.Degree AS '学位',teacher.Introduction AS '座右铭' FROM [teacher] WHERE teacher.tcode=" + student.TCode;

            DataTable dataTable = BaseDao<object>.FindDataTable(sqlStr);

            if (dataTable != null)
            {

                //dataTable.Rows[1].Delete();
                //将数据集合的首张表绑定到dataGridView1的数据源
                this.dataGridView1.DataSource = dataTable;
            }
            else if (dataTable == null)
            {
                System.Windows.Forms.MessageBox.Show("首次使用");
            }
        }
        private void QueryAllCourse2()
        {
            string sqlStr = "SELECT DISTINCT class.name AS 班级,class.Major AS 专业,student.name AS 学生姓名,student.scode AS 学生学号,student.Gender AS 学生性别 FROM [dbo].[teacher_class],class,teacher,student WHERE teacher_class.classid=class.id AND class.id=student.Class_id AND teacher_class.teacherid=teacher.id AND teacher.id=" + student.Id;

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

        private void teachershow_Load(object sender, EventArgs e)
        {

            if (student.Gender == "男")
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/n.jpg";
            }
            else 
            {
                pictureBox1.ImageLocation = @"https://shangying.xyz/img/v.jpg";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }

        private void 修改密码_Click(object sender, EventArgs e)
        {
            new teachereditpwd(student,classname).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
            string sqlStr = "SELECT DISTINCT class.name AS 班级,class.Major AS 专业,student.name AS 学生姓名,student.scode AS 学生学号,student.Gender AS 学生性别 FROM [dbo].[teacher_class],class,teacher,student WHERE teacher_class.classid=class.id AND class.id=student.Class_id AND teacher_class.teacherid=teacher.id AND teacher.id=" + student.Id;

            DataTable dataTable = BaseDao<object>.FindDataTable(sqlStr);
            if (dataTable.Rows.Count > 0)
            {

                //dataTable.Rows[1].Delete();
                //将数据集合的首张表绑定到dataGridView1的数据源
                this.dataGridView1.DataSource = dataTable;

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("抱歉，暂时没有学生选择您的课程！！！");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
