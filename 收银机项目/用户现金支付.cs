using shouyinBLL;
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

    
    public partial class txt现金支付 : Form
    {
        Jiezhangbll jie = new Jiezhangbll();
        string num1;
        string num2;
        double num3;
        string num4;
        string num5;

        private string _number2;
        public txt现金支付(string  num ,string  jj,string sum)
        {
            InitializeComponent();
            num1 =  num;
            num4 = jj; 
            num5 = sum;
            lab总价 .Text = num1;
        }

        public string Number2 { get => _number2; set => _number2 = value; }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tet实付.Text != "") {


                num3 = int.Parse(lab找零.Text);

                


                if (int.Parse(num2) > int.Parse(num1))
                {

                    MessageBox.Show("钱柜已弹出，请找零" + lab找零.Text + "");

                    Number2 = num3.ToString();
                    jie.instjiezhang2(num4, num2, num3.ToString(), num5);
                    Close();
                }
                else {

                    MessageBox.Show("现金不足");

                }
                
            }
         
        }

        private void tet实付_KeyDown(object sender, KeyEventArgs e)
        {
            //判断用户摁的是否为 Enter键
            if (e.KeyCode == Keys.Enter)
            {
                num2 = tet实付.Text;
               

                lab找零.Text = (double.Parse(num2) - double.Parse(num1)).ToString();
                Number2 = num3.ToString();
                //直接调用查询按钮函数
            }
        }

        private void tet实付_MouseLeave(object sender, EventArgs e)
        {
            num2 = tet实付.Text;
            if (num2 != "") { lab找零.Text = (double.Parse(num2) - double.Parse(num1)).ToString();
                Number2 = num3.ToString();
            }
            
        }
    }
}
