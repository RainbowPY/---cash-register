using shouyinDAL;
using shouyinModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shouyinBLL
{
    public class Jiezhangbll
    {

        Jiezhang j = new Jiezhang();    
        public DataSet getjiezhang(jiezhangEntity gtjiezhang)
        {

            return j.getjiezhang(gtjiezhang);

        }


        //插入账单号


        public DataSet instjiezhang(jiezhangEntity num)
        {

            return j.instjiezhang(num);
        }

        //现金支付
        public DataSet instjiezhang2(string zhang ,string shifu ,string zhaoling ,string sum)
        {
           
            return j.instjiezhang2(zhang, shifu, zhaoling, sum);
        }

        //在线支付
        public DataSet instjiezhang3(string zhang, string shifu, string sum)
        {
            
            return  j.instjiezhang3(zhang, shifu, sum);
        }


        public jiezhangEntity selsctzhangdan(string zhang)
        {
           


            DataSet ds = j.selsctzhangdan(zhang);
            //判断ds数据集中是否存在数据， ds.Tables[0].Rows.Count 获取条数
            if (ds != null && ds.Tables[0].Rows.Count == 1)
            {

                jiezhangEntity j = new jiezhangEntity();

                j.Sy账单编号 = ds.Tables[0].Rows[0]["账单编号"].ToString();
                if (ds.Tables[0].Rows[0]["支付方式"].ToString() != "") 
                {
                    j.Sy支付方式 = ds.Tables[0].Rows[0]["支付方式"].ToString();
                    j.Sy用户实付 = ds.Tables[0].Rows[0]["用户实付"].ToString();
                    j.Sy找零 = ds.Tables[0].Rows[0]["找零"].ToString();
                    j.Sy员工编号 = int.Parse(ds.Tables[0].Rows[0]["员工编号"].ToString());
                    j.Sy购买数量 = ds.Tables[0].Rows[0]["商品购买数量"].ToString();
                    j.Sy支付时间 = DateTime.Parse(ds.Tables[0].Rows[0]["支付时间"].ToString());
                    j.Sy结账状态 = int.Parse(ds.Tables[0].Rows[0]["结账状态"].ToString());
                    return j;
                }
                return null;
            }

            return null;
        }

        //删除

        public bool deletejiezhang(string zandanid)
        {

            return j.deletejiezhang(zandanid);


        }


        //刷新

        public DataTable getjiezhang()
        {

            return j.getjiezhang();

        }
    }
 }
