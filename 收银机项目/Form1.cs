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
    public partial class Form1 : Form
    {
        string good = string.Empty;
        addgoodsbll bal = new addgoodsbll();

        private string _number;//接收新数量

        string goodsnum;
        public Form1(string goods ,string num)
        {
            InitializeComponent();
            good = goods;
            goodsnum = num;
        }

        public string Number { get => _number; set => _number = value; }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string num = textBox1.Text.Trim();
           //  bool.Parse(int.Parse(num)); 
            if (num != "")
            {
                this.Number = num;//把最新获取的商品数量放入到 NUmber属性中
                //bal.addnum(good, num);
                //textBox1.Text = "";
                //MessageBox.Show("修改成功！");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = goodsnum;
            string num = textBox1.Text.Trim();
            if (goodsnum == num) {
                this.Number = num;
            }

            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key =Convert.ToInt32(e.KeyChar);
            if ((key < 48 || key > 57) && key != 8) 
            { e.Handled = true; }
            else { e.Handled = false;
                
            }

           
        }
    }
}
