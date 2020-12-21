using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教务管理系统.窗体
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new teacherindex().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new studentindex().Show();
            this.Hide();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }
    }
}
