using shouyinBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 收银机项目
{
    public partial class 收银员管理表 : Form
    {
        public 收银员管理表()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void 收银员管理表_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cashierDataSet3.收银员表”中。您可以根据需要移动或移除它。
            this.收银员表TableAdapter.Fill(this.cashierDataSet3.收银员表);
            // TODO: 这行代码将数据加载到表“cashierDataSet2.收银员表”中。您可以根据需要移动或移除它。
            //  this.收银员表TableAdapter.Fill(this.cashierDataSet2.收银员表);

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("确认要删除吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Yuanggongbll yb = new Yuanggongbll();

                string yuangongid = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (yuangongid != "")
                {

                    yb.deleteYglist(yuangongid);
                    

                }
                else
                {
                    MessageBox.Show("删除失败！！");

                }

            }
            收银员管理表_Load(sender, e);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            new 员工注册表().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
