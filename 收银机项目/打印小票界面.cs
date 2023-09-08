using shouyinBLL;
using shouyinModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 收银机项目
{
    public partial class 打印小票界面 : Form
    {



        string zhang;
        public 打印小票界面(string code2)
        {
            InitializeComponent();
            
            zhang = code2;
        }
       
        private void 打印小票界面_Load(object sender, EventArgs e)
        {

            

                Jiezhangbll jie = new Jiezhangbll();
                jiezhangEntity j = jie.selsctzhangdan(zhang);

            if (j != null ) {
                lab账单编号.Text = j.Sy账单编号;
                lab支付方式.Text = j.Sy支付方式;
                lab实付.Text = j.Sy用户实付;
                lab找零.Text = j.Sy找零;
                lab员工编号.Text = j.Sy员工编号.ToString();
                lab数量.Text = j.Sy购买数量;
                lab时间.Text = j.Sy支付时间.ToString();


            }










        }
    }
}
