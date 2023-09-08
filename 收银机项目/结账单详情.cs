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
    public partial class 结账单详情 : Form
    {

        string zhang;
        addgoodsbll add = new addgoodsbll();
        public 结账单详情(string  id)
        {
            InitializeComponent();
            zhang = id;
        }

        private void 结账单详情_Load(object sender, EventArgs e)
        {

            Jiezhangbll jie = new Jiezhangbll();
            jiezhangEntity j = jie.selsctzhangdan(zhang);



            lab账单编号.Text = j.Sy账单编号;
            lab支付方式.Text = j.Sy支付方式;
            lab实付.Text = j.Sy用户实付;
            lab找零.Text = j.Sy找零;
            lab员工编号.Text = j.Sy员工编号.ToString();
            lab商品数量.Text = j.Sy购买数量;
            lab支付时间.Text = j.Sy支付时间.ToString();
            if (j.Sy结账状态.ToString() == "1") 
            {
                lab支付.Text = "挂单";
            }else if(j.Sy结账状态.ToString() == "2") 
            {
                lab支付.Text = "已结";
            }
            else if (j.Sy结账状态.ToString() == "3")
            {
                lab支付.Text = "退单";
            }

            List<mingxiEntity> list;
            string good = zhang;
            list = add.selectmingxi(good);
            // double total2 = 0.00;
            // this.listView1.Items.Clear();//清空原有数据
            if (good != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    mingxiEntity Sy = list[i];//拆箱操作（从list中取出，实体类对象）
                                                //把对象中的值 添加到ListView 的Items集合中 
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(Sy.Li流水编号.ToString());
                    item.SubItems.Add(Sy.Li商品编号.ToString());
                    item.SubItems.Add(Sy.Li商品名称.ToString());
                    item.SubItems.Add(Sy.Li商品单价.ToString());
                    item.SubItems.Add(Sy.Li商品数量.ToString());
                    item.SubItems.Add(Sy.Li小计.ToString());
                    item.SubItems.Add(Sy.Li所属账单编号.ToString());
                   
                    //把封装好的数据添加到每一行
                    this.listView1.Items.Add(item);
                    //   total += double.Parse(Sy.Sy商品价格) * Sy.Sy商品数量;
                    // sum += Sy.Sy商品数量;
                }


            }

        }

       

    }
}
