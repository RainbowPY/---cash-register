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
    public partial class 管理员1 : Form
    {
        public 管理员1()
        {
            InitializeComponent();
        }

        private void 管理员1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cashierDataSet4.结帐表”中。您可以根据需要移动或移除它。
            this.结帐表TableAdapter1.Fill(this.cashierDataSet4.结帐表);
            // TODO: 这行代码将数据加载到表“cashierDataSet.结帐表”中。您可以根据需要移动或移除它。
            this.结帐表TableAdapter.Fill(this.cashierDataSet.结帐表);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           new 收银员管理表().Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new 添加商品().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Jiezhangbll shangchu = new Jiezhangbll();

                string zandanid = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                if (shangchu.deletejiezhang(zandanid))
                {

                    管理员1_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("删除失败！！");


                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            管理员1_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new 登录页面().Show();
            Close();
        }
    }
}
