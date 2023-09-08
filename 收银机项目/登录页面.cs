using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 收银机项目
{
    public partial class 登录页面 : Form
    {
        public 登录页面()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {//使页面打开时最大化
           // this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
            
        {
            string ygtel = this.textBox1.Text.Trim();
            string password = this.textBox2.Text.Trim();

            //验证账号和密码长度
            if (ygtel != "" && ygtel.Length > 0)
            {
                if (password.Length > 6 && password.Length <= 15)
                {

                    //验证账号和密码是否正确   到数据库查询
                    try
                    {


                        string connectionString = "Data Source=127.0.0.1;Initial Catalog=Cashier;Persist Security Info=True;User ID=sa;Password=123456";

                        SqlConnection connect = new SqlConnection(connectionString);

                        connect.Open();

                        string sql = "select * from 收银员表 where 员工电话='" + ygtel + "' and 员工登陆密码='" + password + "';";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connect);

                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds, "table");


                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            //登陆成功   隐藏自身
                            this.Hide();
                            //弹出主页面
                            this.Hide();
                            new AddGoods().Show();

                        }
                        else
                        {

                            MessageBox.Show("密码和员工电话错误", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        }

                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show("数据库连接失败!" + excep.ToString());
                        Console.WriteLine("数据库打开失败！" + excep.ToString());

                    }

                }
                else
                {

                    MessageBox.Show("密码长度错误", "登录失败请重新输入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //  MessageBox.Show("密码长度错误，登录失败请重新输入！",MessageBoxIcon.Warning, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("员工电话不能为空！", "员工电话错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ygtel = this.textBox1.Text.Trim();
            string password = this.textBox2.Text.Trim();


            if (ygtel != "" && ygtel.Length > 0)
            {
                if (password.Length > 6 && password.Length <= 15)
                {

                    //验证账号和密码是否正确   到数据库查询
                    try
                    {


                        string connectionString = "Data Source=127.0.0.1;Initial Catalog=Cashier;Persist Security Info=True;User ID=sa;Password=123456";

                        SqlConnection connect = new SqlConnection(connectionString);

                        connect.Open();

                        string sql = "select * from 收银员表 where 员工电话='" + ygtel + "' and 员工登陆密码='" + password + "';";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connect);

                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds, "table");


                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            //登陆成功   隐藏自身
                            this.Hide();
                            //弹出主页面
                            this.Hide();
                            new 管理员1().Show();

                        }
                        else
                        {

                            MessageBox.Show("密码和员工电话错误", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        }

                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show("数据库连接失败!" + excep.ToString());
                        Console.WriteLine("数据库打开失败！" + excep.ToString());

                    }

                }
                else
                {

                    MessageBox.Show("密码长度错误", "登录失败请重新输入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //  MessageBox.Show("密码长度错误，登录失败请重新输入！",MessageBoxIcon.Warning, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("员工电话不能为空！", "员工电话错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        
    }
}
