﻿using System;
using System.Windows.Forms;
using 教务管理系统.BEAN;
using 教务管理系统.DAO;

namespace 教务管理系统.窗体
{
    public partial class studentindex : Form
    {
        public studentindex()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
            mima.Visible = false;
            qrmima.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            xuehao.Focus();
        }

        private void studentindex_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentBean student = new StudentDao().FindByxh(xuehao.Text);//查学号是否存在
            if (student != null)//学号存在
            {
                button2.Visible = true;//登陆按钮
                button3.Visible = true;
                label2.Visible = true;//密码提示
                //label3.Visible = true;//确认密码提示
                mima.Visible = true;//密码框
                xuehao.Visible = true;//确认密码框
                tijiao.Visible = false;//提交按钮
               // button2.Visible = true;
                //button3.Visible = true;
                //  System.Windows.Forms.MessageBox.Show("首次使用");

                StudentBean students = new StudentDao().FindByzhuangtai(xuehao.Text);//查询账号状态
                if (students != null)//状态为0
                                     //提示首次并修改状态
                {
                    tijiao.Visible = true;//登陆按钮
                    label2.Visible = true;//密码提示
                    label3.Visible = true;//确认密码提示
                    mima.Visible = true;//密码框
                    qrmima.Visible = true;
                    xuehao.Visible = true;//确认密码框
                    tijiao.Visible = false;//提交按钮
                    button2.Visible = false;
                    System.Windows.Forms.MessageBox.Show("系统检测到您是首次登陆，请设置一个密码！！！");
                  //  StudentBean studentss = new StudentDao().zhuangtai(xuehao.Text);//修改状态
                                                                                        // System.Windows.Forms.MessageBox.Show("状态以修改");
                                                                                        // System.Windows.Forms.MessageBox.Show("请修改密码");
                    if (mima.Text == String.Empty || xuehao.Text == String.Empty)
                    {
                        //  System.Windows.Forms.MessageBox.Show("没有输入！请输入");


                    }
                    else if (mima.Text != xuehao.Text)
                    {
                        System.Windows.Forms.MessageBox.Show("两次输入密码不一致！！！请重新输入！！！");

                    }
                }
                else if (students == null)
                {//状态为1
                    //学号检查
                    tijiao.Visible = true;
                    button2.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    xuehao.Visible = true;
                    mima.Visible = true;
                    tijiao.Visible = false;
                    button3.Visible = false;
                    //学号检查
                    StudentBean studentt = new StudentDao().FindBySCode(xuehao.Text, mima.Text);
                    if (student != null)
                    {
                     
                        // new StudentHomeForm(studentt, this).Show();
                        // this.Hide();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("对不起，没有查询到对应工号或密码错误，请核对后重试或联系老师解决！");
                        //this.Error("错误！不存在此学号");
                    }

                }
                //System.Windows.Forms.MessageBox.Show("状态以修改");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("对不起，没有查询到对应工号或密码错误，请核对后重试或联系老师解决！");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //学号+密码检查
         ClassBean classname;
        StudentBean student = new StudentDao().FindBySCode(xuehao.Text, mima.Text);
            if (student != null)
            {
                //System.Windows.Forms.MessageBox.Show("对不起，没有查询到");
                ClassBean classname1 = null;
                new studentshow(student, classname1).Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("对不起，没有查询到对应工号或密码错误，请核对后重试或联系老师解决！");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentBean pwd = new StudentDao().password(xuehao.Text, mima.Text);//修改密码
            StudentBean studentss = new StudentDao().zhuangtai(xuehao.Text);//修改状态
            System.Windows.Forms.MessageBox.Show("密码以修改,请点击登陆！");
            tijiao.Visible = false;
            button3.Visible = false;
            button2.Visible = true;
            
        }
    }
}
