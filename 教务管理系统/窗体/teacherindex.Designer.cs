
namespace 教务管理系统.窗体
{
    partial class teacherindex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.qrmima = new System.Windows.Forms.TextBox();
            this.mima = new System.Windows.Forms.TextBox();
            this.xuehao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tijiao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "确认密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "密码";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 37);
            this.button3.TabIndex = 15;
            this.button3.Text = "确定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // qrmima
            // 
            this.qrmima.Location = new System.Drawing.Point(251, 296);
            this.qrmima.Name = "qrmima";
            this.qrmima.Size = new System.Drawing.Size(241, 25);
            this.qrmima.TabIndex = 13;
            // 
            // mima
            // 
            this.mima.Location = new System.Drawing.Point(251, 157);
            this.mima.Name = "mima";
            this.mima.Size = new System.Drawing.Size(241, 25);
            this.mima.TabIndex = 12;
            // 
            // xuehao
            // 
            this.xuehao.Location = new System.Drawing.Point(251, 39);
            this.xuehao.Name = "xuehao";
            this.xuehao.Size = new System.Drawing.Size(241, 25);
            this.xuehao.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "工号";
            // 
            // tijiao
            // 
            this.tijiao.Location = new System.Drawing.Point(567, 34);
            this.tijiao.Name = "tijiao";
            this.tijiao.Size = new System.Drawing.Size(121, 31);
            this.tijiao.TabIndex = 9;
            this.tijiao.Text = "提交";
            this.tijiao.UseVisualStyleBackColor = true;
            this.tijiao.Click += new System.EventHandler(this.tijiao_Click);
            // 
            // teacherindex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.qrmima);
            this.Controls.Add(this.mima);
            this.Controls.Add(this.xuehao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tijiao);
            this.Name = "teacherindex";
            this.Text = "教师_登陆";
            this.Load += new System.EventHandler(this.teacherindex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox qrmima;
        private System.Windows.Forms.TextBox mima;
        private System.Windows.Forms.TextBox xuehao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tijiao;
    }
}