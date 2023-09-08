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
    public partial class 结账单查询 : Form
    {

        string uid;
        addgoodsbll add = new addgoodsbll();
        List<jiezhangEntity> list;
        public 结账单查询(string  id)
        {
            InitializeComponent();
            uid = id;
        }

        private void 结账单查询_Load(object sender, EventArgs e)
        {
            lab账单编号.Text = uid;

            string good = lab账单编号.Text.Trim();
            list = add.selectjiezhang(good);
           
            this.listView1.Items.Clear();
            if (good != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    jiezhangEntity Sy = list[i];//拆箱操作（从list中取出，实体类对象）
                                                //把对象中的值 添加到ListView 的Items集合中 
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(Sy.Sy账单编号);
                    item.SubItems.Add(Sy.Sy支付方式);
                    item.SubItems.Add(Sy.Sy用户实付);
                    item.SubItems.Add(Sy.Sy找零);
                    item.SubItems.Add (Sy.Sy员工编号.ToString());
                    item.SubItems.Add(Sy.Sy购买数量);
                    item.SubItems.Add(Sy.Sy支付时间.ToString());
                    item.SubItems.Add(Sy.Sy结账状态.ToString());


                    //把封装好的数据添加到每一行
                    this.listView1.Items.Add(item);
                    //   total += double.Parse(Sy.Sy商品价格) * Sy.Sy商品数量;
                    // sum += Sy.Sy商品数量;
                }


            }


        }

        private void listView1_Click(object sender, EventArgs e)
        {
            new 结账单详情(uid).Show();
        }
    }
}
