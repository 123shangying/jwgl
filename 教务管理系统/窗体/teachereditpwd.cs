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
    public partial class teachereditpwd : Form
    {
        /// <summary>
        /// 当前登录的学生信息
        /// </summary>
        public TeacherBean student;
        /// <summary>
        /// 当前登录的班级信息
        /// </summary>
        public ClassBean classname;

        public teachereditpwd(TeacherBean student, ClassBean classname)
        {
            InitializeComponent();
            this.ControlBox = false;   // 设置不出现关闭按钮
                                       //
            this.student = new TeacherDao().FindById(new TeacherBean(student.Id));
        }

        private void studenteditpsw_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string sqlStr = "SELECT pwd FROM [dbo].[teacher] WHERE pwd='" + textBox1.Text + "' and id=" + student.Id;
            //  string sqlStr = "UPDATE student_course SET courseid=(select id from course WHERE Cname='" + comboBox1.Text + "'),studentid=" + student.Id + " WHERE studentid=" + student.Id;
            DataTable dataTable = BaseDao<object>.FindDataTable(sqlStr);


            if (dataTable.Rows.Count > 0)
            {
                if (textBox2.Text == String.Empty || textBox3.Text == String.Empty)
                {
                    System.Windows.Forms.MessageBox.Show("！请输入！！！");
                }

                else if (textBox2.Text != textBox3.Text)
                {
                    System.Windows.Forms.MessageBox.Show("两次输入密码不一致！！！请重新输入！！！");
                }
                else if ((textBox2.Text != String.Empty || textBox3.Text != String.Empty) || (textBox2.Text != textBox3.Text))
                {
                    string sqlStr1 = "UPDATE teacher SET pwd='" + textBox2.Text + "' WHERE id=" + student.Id;
                    DataTable dataTable1 = BaseDao<object>.FindDataTable(sqlStr1);
                    System.Windows.Forms.MessageBox.Show("密码修改成功！");
                }
            }
            else
            {

                System.Windows.Forms.MessageBox.Show("原密码输入错误！");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                this.Close();
        }

        private void teachereditpwd_Load(object sender, EventArgs e)
        {

        }
    }
}
