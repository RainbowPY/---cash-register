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
using shouyinBLL;
using shouyinDAL;

namespace 收银机项目
{
    public partial class 添加商品 : Form
    {

        addgoodsbll bll = new addgoodsbll();
        shangpinEntity goodsinfo = new shangpinEntity();
        AddgoodsDAL dal = new AddgoodsDAL();
        private string id = string.Empty;
        addgoodsbll add = new addgoodsbll();
        List<shangpinEntity> list;
        string good = string.Empty;
        string goodsnum = string.Empty;
        double total = 0.00;
        Jiezhangbll jie = new Jiezhangbll();
        string code2 = string.Empty;
        int sum = 0;
        public 添加商品()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            shangpinEntity info = new shangpinEntity();
            if (tid.Text.Trim() != null && tprice.Text.Trim() != null)
            {
                info.Sy商品照片 = tpicture.Text.Trim();
                info.Sy商品名称 = tname.Text.Trim();
                info.Sy商品编号 = tid.Text.Trim();
                info.Sy商品价格 = tprice.Text.Trim();
            }
            else
            {
                MessageBox.Show("商品编号和商品价格不能为空");
            }
            bool bl = bll.Addgoods(info);
            if (bl == true)
            {
                MessageBox.Show("添加成功");

                添加商品_Load(sender, e);
            }
            else
            {
                MessageBox.Show("添加失败");
            }


        }



        private void btupdate_Click(object sender, EventArgs e)
        {
            //非空验证
            if (tid.Text.Trim() != "" && tprice.Text.Trim() != "")
            {
                #region  封装数据到实体类中

                id = tid.Text.Trim();
                //接收用户输入的所有基本信息
                shangpinEntity info = new shangpinEntity();
                info.Sy商品照片 = tpicture.Text.Trim();
                info.Sy商品名称 = tname.Text.Trim();
                info.Sy商品编号 = tid.Text.Trim();
                info.Sy商品价格 = tprice.Text.Trim();

                #endregion
                //调用QQUserBLL类中的Admin_UpdateQQUserInfo方法，把数据 修改到数据库中
                bool bl = bll.Updategoods(info, id);
                if (bl == true)
                {
                    MessageBox.Show("修改成功！", "修改提示");
                    添加商品_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("售价、编号不能为空!", "非空验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.tid.Focus();
            }


        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult drt = MessageBox.Show("确认要删除商品吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drt == DialogResult.Yes)
            {
                string id = tid.Text.Trim();
                //删除好友 

                if (id != "")
                {
                    if (bll.Deletegoods(id))
                    {
                        MessageBox.Show("删除成功！");
                        //刷新数据
                        
                    }
                    添加商品_Load(sender, e);
                }
                
                
            }

           





        }

        private void 添加商品_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cashierDataSet5.商品表”中。您可以根据需要移动或移除它。
            this.商品表TableAdapter.Fill(this.cashierDataSet5.商品表);
            //this.商品表TableAdapter.Fill(this.cashierDataSet2.商品表);
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void btselect_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
