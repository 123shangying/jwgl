using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 教务管理系统.BEAN;

namespace 教务管理系统.DAO
{
    class TeacherDao : BaseDao<TeacherBean>
    {
        //查询工号是否存在
        public TeacherBean FindByTCode(string tCode)
        {
            TeacherBean teacher = null;
            try
            {
                //连接数据库
                conn = new SqlConnection(connStr); //数据库连接对象
                conn.Open();
                //SQL
                string sqlStr = "SELECT * FROM [teacher] WHERE tCode=@tCode";//占位符
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@tCode", tCode.ToString());
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                //dataTable转模型
                teacher = ConvertToModel(dt);
                return teacher;
            }
            catch (Exception ex)
            {
                Console.WriteLine("【Execption】" + ex.Message.ToString());
                // MessageBox.Show(ex.Message.ToString());
              //  MessageBox.Show(ex.Message.ToString() + "查询工号是否存在");
                return teacher;
            }
            finally
            {
                //关闭连接
                conn.Close();
                conn.Dispose();
            }
        }

        public override bool Add(TeacherBean bean)
        {
            //throw new NotImplementedException();
            return false;
        }

        public override TeacherBean FindById(TeacherBean bean)
        {
            TeacherBean teacher = null;
            try
            {
                //连接数据库
                conn = new SqlConnection(connStr); //数据库连接对象
                conn.Open();
                //SQL
                String sqlStr = "SELECT * FROM [teacher] WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@id", bean.Id);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                //cmd.ExecuteNonQuery();

                //dataTable转模型
                teacher = ConvertToModel(dt);
                return teacher;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
             //   MessageBox.Show(ex.Message.ToString()+"id");

                return teacher;
            }
            finally
            {
                //关闭连接
                conn.Close();
                conn.Dispose();
            }

        }
        //查询工号+密码
        public TeacherBean FindBygh(string TCode, string pwd) 
        {
            TeacherBean teacher = null;
            try
            {
                //连接数据库
                conn = new SqlConnection(connStr); //数据库连接对象
                conn.Open();
                //SQL
                string sqlStr = "SELECT * FROM [teacher] WHERE TCode=@TCode and pwd=@pwd";//占位符
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@TCode", TCode);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                //dataTable转模型
                teacher = ConvertToModel(dt);
                return teacher;
            }
            catch (Exception ex)
            {
                Console.WriteLine("【Execption】" + ex.Message.ToString());
             //     MessageBox.Show(ex.Message.ToString()+ "查询工号+密码");
                return teacher;
            }
            finally
            {
                //关闭连接
                conn.Close();
                conn.Dispose();
            }
        }
        //
        //查询状态
        /// <summary>
        /// 查：根据zhuangtai
        //
        public TeacherBean FindByzhuangtai(string TCode)
        {
            TeacherBean teacher = null;
            try
            {
                //连接数据库
                conn = new SqlConnection(connStr); //数据库连接对象
                conn.Open();
                //SQL
                string sqlStr = "SELECT * FROM [teacher] WHERE zhuangtai=0 and Tcode=@code";//占位符
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@Code", TCode);
                //   cmd.Parameters.AddWithValue("@zhuangtai");
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                //dataTable转模型
                teacher = ConvertToModel(dt);
                return teacher;
            }
            catch (Exception ex)
            {
                Console.WriteLine("【Execption】" + ex.Message.ToString());
                // MessageBox.Show(ex.Message.ToString());
            //     MessageBox.Show(ex.Message.ToString()+"状态");
                return teacher;
            }
            finally
            {
                //关闭连接
                conn.Close();
                conn.Dispose();
            }
        }
        //
        //
        //
        //
        //状态更改
        ///
        public TeacherBean zhuangtai(string Tcode)
        {
            TeacherBean teacher = null;
            try
            {
                //连接数据库
                conn = new SqlConnection(connStr); //数据库连接对象
                conn.Open();
                //SQL

                string sqlStr = "UPDATE  [teacher] set zhuangtai=1 where TCode=@TCode";//占位符

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@TCode", Tcode);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                //dataTable转模型
                teacher = ConvertToModel(dt);
                return teacher;
            }
            catch (Exception ex)
            {
                Console.WriteLine("【Execption】" + ex.Message.ToString());
             //    MessageBox.Show(ex.Message.ToString()+"状态更改");
                //  MessageBox.Show("132544676");
                return teacher;
            }
            finally
            {
                //关闭连接
                conn.Close();
                conn.Dispose();
            }
        }

        //
        //密码更改，有初始密码
        //
        public TeacherBean password(string Tcode, string Pwd)
        {
            TeacherBean teacher = null;
            try
            {
                //连接数据库
                conn = new SqlConnection(connStr); //数据库连接对象
                conn.Open();
                //SQL

                string sqlStr = "UPDATE  [teacher] set pwd=@pwd where TCode=@TCode";//占位符

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@TCode", Tcode);
                cmd.Parameters.AddWithValue("@pwd", Pwd);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                //dataTable转模型
                teacher = ConvertToModel(dt);
                return teacher;
            }
            catch (Exception ex)
            {
                Console.WriteLine("【Execption】" + ex.Message.ToString());
             //   MessageBox.Show(ex.Message.ToString()+ "密码更改，有初始密码");
                // MessageBox.Show("ok");
                return teacher;
            }
            finally
            {
                //关闭连接
                conn.Close();
                conn.Dispose();
            }
        }
    }
}

