using shouyinBLL;
using shouyinModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 收银机项目
{
    public partial class 员工注册表 : Form
    {

        Yuanggongbll ygbll=new Yuanggongbll();
        public 员工注册表()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rd = new Random();
            shouyinEntity sy = new shouyinEntity();
            sy.Sy员工编号 = rd.Next(100000, 9999999).ToString();
            sy.Sy员工登录密码 = txt员工密码.Text.ToString().Trim();
            
            //判断密码是否一直
            if (txt确认登录密码.Text.ToString().Trim() == sy.Sy员工登录密码)
            {
                
                sy.Sy员工姓名 = txt员工姓名.Text.ToString().Trim();
                sy.Sy员工电话 = txt员工手机号.Text.ToString().Trim();
                sy.Sy员工性别 = rd男.Checked == true ? "男" : "女";

            }
            else
            {
                MessageBox.Show("两次输入的密码不一致！！");

            }
           bool b1=ygbll.insertYG(sy);
            if (b1 == true)
            {

                MessageBox.Show("注册成功！员工编号号为：" +sy.Sy员工编号  + "请牢记", "恭喜你注册成功");
                this.Close();

            }
            new 收银员管理表().Show();
            

        }

        private void 员工注册表_Load(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
