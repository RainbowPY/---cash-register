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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 收银机项目
{

    public partial class AddGoods : Form
    {
        addgoodsbll add = new addgoodsbll();
        List<shangpinEntity> list;
        string good = string.Empty;
        string goodsnum = string.Empty;
       
        Jiezhangbll jie = new Jiezhangbll();
        string code2 = string.Empty;
        double zongjia = 0;
      int sum = 0;
        public AddGoods()
        {
            InitializeComponent();
        }

        private void tet商品编号_TextChanged(object sender, EventArgs e)
        {
            if (tet商品编号.Text == "商品编号/名称" && tet商品编号.Text != "")
            {
                tet商品编号.Text ="";

            }
        }

        private void but搜索_Click(object sender, EventArgs e)
        {
            string good = tet商品编号.Text.Trim();

            // double total2 = 0.00;
            // this.listView1.Items.Clear();//清空原有数据
            if (good != "" && good != "商品编号/名称")
            {
                list = add.selgoods2(good);
                for (int i = 0; i < list.Count; i++)
                {
                    shangpinEntity Sy = list[i];//拆箱操作（从list中取出，实体类对象）
                                                //把对象中的值 添加到ListView 的Items集合中 
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(Sy.Sy商品编号.ToString());
                    item.ImageIndex = int.Parse(Sy.Sy商品照片.ToString());//设置头像
                    item.SubItems.Add(Sy.Sy商品名称);
                    item.SubItems.Add(Sy.Sy商品价格);
                    item.SubItems.Add(Sy.Sy商品数量.ToString());
                    //把封装好的数据添加到每一行
                    item.SubItems.Add((double.Parse(Sy.Sy商品价格) * Sy.Sy商品数量).ToString());
                    this.listView1.Items.Add(item);
                    zongjia += double.Parse(Sy.Sy商品价格) * Sy.Sy商品数量;

                    sum += Sy.Sy商品数量;
                }
                lab总计.Text = zongjia.ToString();
                lab数量.Text = sum.ToString();

            }
            else { MessageBox.Show("请扫条形码"); }


            
        
        }

        //修改数量
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {

                string num1 = this.listView1.SelectedItems[0].SubItems[1].Text.Trim();
                string num2 = this.listView1.SelectedItems[0].SubItems[4].Text.Trim();
                Form1 f = new Form1(num1,num2);

                f.ShowDialog();
                this.listView1.SelectedItems[0].SubItems[4].Text = f.Number;
                double danjia = double.Parse(this.listView1.SelectedItems[0].SubItems[3].Text);
                if (f.Number != null) 
                { this.listView1.SelectedItems[0].SubItems[5].Text = (int.Parse(f.Number) * danjia).ToString(); }
                


                UpdateTotal();//更新总价

                updatesum();
               
            }

            else
            {
                MessageBox.Show("请选择要添加数量的商品");
            }
        }

        private void updatesum()
        {
            sum = 0;
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                if (this.listView1.Items[i].SubItems[4].Text.Trim() != "") 
                { sum += int.Parse(this.listView1.Items[i].SubItems[4].Text.Trim()); }
                

            }

            lab数量.Text = sum.ToString();
        }


        //总价 更新
        private void UpdateTotal()
        {
            zongjia = 0;
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {

                zongjia += double.Parse(this.listView1.Items[i].SubItems[5].Text.Trim());

            }

            lab总计.Text = zongjia .ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //先生成交易单据（交易单据号、总数量、应付金额、实付金额、找零、支付类型、结账状态（挂单，已结账、已退单）消费时间）

            if (this.listView1.Items.Count > 0)
            {
                Random rd = new Random();
                code2 = rd.Next(100000, 999999).ToString();
                jiezhangEntity jj = new jiezhangEntity();
                jj.Sy账单编号 = code2;
                jie.instjiezhang(jj);
                for (int i = 0; i < this.listView1.Items.Count; i++)
                {
                    mingxiEntity m = new mingxiEntity();

                    m.Li流水编号 = rd.Next(100000, 999999).ToString();
                    m.Li商品编号 = int.Parse(this.listView1.Items[i].SubItems[1].Text);
                    m.Li商品名称 = this.listView1.Items[i].SubItems[2].Text;
                    m.Li商品单价 = float.Parse(this.listView1.Items[i].SubItems[3].Text);
                    m.Li商品数量 = int.Parse(this.listView1.Items[i].SubItems[4].Text);
                    m.Li小计 = float.Parse(this.listView1.Items[i].SubItems[3].Text) * int.Parse(this.listView1.Items[i].SubItems[4].Text);
                    m.Li所属账单编号 = code2;
                    zongjia += m.Li商品单价 * m.Li商品数量;
                    sum += m.Li商品数量;
                    //调用BLL曾 添加数据
                    add.addmingxi(m);

                }
               

            }

            button3_Click(sender, e);
            AddGoods_Load(sender, e);


        }

        private void tet商品编号_MouseDown(object sender, MouseEventArgs e)
        {
            if (tet商品编号.Text == "商品编号/名称" && tet商品编号.Text != "")
            {
                tet商品编号.Text = "";

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();//清空原有数据
            zongjia = 0;
            sum = 0;
            this.lab总计.Text = zongjia.ToString();
            this.lab数量.Text = sum.ToString();
            tet商品编号.Text = "";
        }

        private void 删除_Click(object sender, EventArgs e)
        {


            if ( listView1.Items.Count >=1 )
            {
                this.listView1.SelectedItems[0].Remove();
            
            }
            
             UpdateTotal();//更新总价
            updatesum();

        }


        //页面加载全屏
        private void AddGoods_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cashierDataSet6.结帐表”中。您可以根据需要移动或移除它。
            this.结帐表TableAdapter.Fill(this.cashierDataSet6.结帐表);
            // TODO: 这行代码将数据加载到表“cashierDataSet1.结帐表”中。您可以根据需要移动或移除它。
            //this.结帐表TableAdapter1.Fill(this.cashierDataSet1.结帐表);
            // TODO: 这行代码将数据加载到表“cashierDataSet.结帐表”中。您可以根据需要移动或移除它。
            //this.结帐表TableAdapter.Fill(this.cashierDataSet.结帐表);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }


        /// <summary>
        /// 现金支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {

            if (code2 != "" && lab总计.Text != "0.00" && zongjia != 0) 
            {
                txt现金支付 tt = new  txt现金支付(lab总计.Text.Trim(), code2, sum.ToString());
                tt.ShowDialog();
                if ( tt.Number2 != null) { new 打印小票界面(code2).ShowDialog(); }
                
            }

            this.listView1.Items.Clear();//清空原有数据
            zongjia = 0;
            sum = 0;
            this.lab总计.Text = zongjia.ToString();
            this.lab数量.Text = sum.ToString();
      
           

            AddGoods_Load(sender, e);
        }


        //在线支付
        private void button6_Click(object sender, EventArgs e)
        {
            if (code2 != "" && lab总计.Text!="0.00" && zongjia != 0)
            {
                new 用户在线支付(lab总计.Text.Trim(), code2, sum.ToString()).ShowDialog();
                new 打印小票界面(code2).ShowDialog();
            }
            this.listView1.Items.Clear();//清空原有数据
            zongjia = 0;
            sum = 0;
            this.lab总计.Text = zongjia.ToString();
            this.lab数量.Text = sum.ToString();
          

            AddGoods_Load(sender, e);
        }



        //重新打印小票
        private void button8_Click(object sender, EventArgs e)
        {

            if (code2 != "") {
               
                new 打印小票界面(code2).ShowDialog(); }
                else {
                    string idd = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    code2 = idd;
                    new 打印小票界面(code2).ShowDialog();
                }

            
             
        }


        //搜索
        private void button4_Click(object sender, EventArgs e)
        {
            if (tet流水编号.Text != ""  )
            {
                if (add.jiezhangdan(tet流水编号.Text.Trim()))
                {

                    new 结账单查询(tet流水编号.Text.Trim()).ShowDialog();
                }

                else {

                    MessageBox.Show("账单错误！");
                }
               


            }
            else {
                MessageBox.Show("请输入查询账单号");




            }
           this.dataGridView1 = new DataGridView();
     

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Jiezhangbll shangchu = new Jiezhangbll();

                string zandanid = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                if (shangchu.deletejiezhang(zandanid))
                {

                    AddGoods_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("删除失败！！");


                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddGoods_Load(sender, e);
        }


        //双击 查看详情
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString() != "") {

                new 结账单详情(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();

            }
            
        }



        //挂单
        private void button7_Click(object sender, EventArgs e)
        {

            if (this.listView1.Items.Count > 0) {

                jiezhangEntity jj = new jiezhangEntity();
                jj.Sy账单编号 = code2;
                jie.instjiezhang(jj);
                for (int i = 0; i < this.listView1.Items.Count; i++)
                {
                    mingxiEntity m = new mingxiEntity();

                    m.Li流水编号 = this.dataGridView1.SelectedRows[0].Cells[1].ToString();
                    m.Li商品编号 = int.Parse(this.listView1.Items[i].SubItems[1].Text);
                    m.Li商品名称 = this.listView1.Items[i].SubItems[2].Text;
                    m.Li商品单价 = float.Parse(this.listView1.Items[i].SubItems[3].Text);
                    m.Li商品数量 = int.Parse(this.listView1.Items[i].SubItems[4].Text);
                    m.Li小计 = float.Parse(this.listView1.Items[i].SubItems[3].Text) * int.Parse(this.listView1.Items[i].SubItems[4].Text);
                    m.Li所属账单编号 = code2;
                    zongjia += m.Li商品单价 * m.Li商品数量;
                    sum += m.Li商品数量;
                    //调用BLL曾 添加数据
                    add.addmingxi(m);
                    this.listView1.Items.Clear();//清空原有数据
                    zongjia = 0.00;
                    sum = 0;
                    this.lab总计.Text = zongjia.ToString();
                    this.lab数量.Text = sum.ToString();

                }






                    this.listView1.Items.Clear();//清空原有数据
                zongjia = 0.00;
                sum = 0;
                this.lab总计.Text = zongjia.ToString();
                this.lab数量.Text = sum.ToString();

            } else {

                


                List<mingxiEntity> list;

                
                string good = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string aa = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


               if (good != null && aa != null) {

                    if (aa == "")
                    {
                        list = add.selectmingxi(good);

                        // this.listView1.Items.Clear();//清空原有数据
                        if (good != null)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                mingxiEntity Sy = list[i];//拆箱操作（从list中取出，实体类对象）
                                                          //把对象中的值 添加到ListView 的Items集合中 
                                ListViewItem item = new ListViewItem();
                                item.ImageIndex = i;//设置头像
                                item.SubItems.Add(Sy.Li商品编号.ToString());
                                item.SubItems.Add(Sy.Li商品名称.ToString());
                                item.SubItems.Add(Sy.Li商品单价.ToString());
                                item.SubItems.Add(Sy.Li商品数量.ToString());
                                item.SubItems.Add(Sy.Li小计.ToString());



                                //把封装好的数据添加到每一行
                                this.listView1.Items.Add(item);
                                zongjia += (Sy.Li商品单价) * Sy.Li商品数量;

                                sum += Sy.Li商品数量;
                                //   total += double.Parse(Sy.Sy商品价格) * Sy.Sy商品数量;
                                // sum += Sy.Sy商品数量;
                                code2 = good;
                            }
                            lab总计.Text = zongjia.ToString();
                            lab数量.Text = sum.ToString();

                        }
                    }

                }
                
                
            }
            AddGoods_Load(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new 登录页面().Show();
            Close();    
        }

        private void tet流水编号_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt32(e.KeyChar);
            if ((key < 48 || key > 57) && key != 8)
            { e.Handled = true; }
            else
            {
                e.Handled = false;

            }
        }
    }
}
