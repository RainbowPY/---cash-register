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
    public partial class 用户在线支付 : Form
    {
        Jiezhangbll jie = new Jiezhangbll();
        public 用户在线支付(string num, string jj, string sum)
        {
            InitializeComponent();
            jie.instjiezhang3(jj,num,sum);
            lab总价.Text = num;
            lab总数.Text = sum;
        }
    }
}
