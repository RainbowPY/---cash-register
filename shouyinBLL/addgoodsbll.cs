using shouyinModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shouyinDAL;
using System.Data;
using System.Windows.Forms;

namespace shouyinBLL
{
    public class addgoodsbll
    {
        addgoods add = new addgoods();
        AddgoodsDAL dal = new AddgoodsDAL();
        //商品
        public List<shangpinEntity>  selgoods(string  good)
        {

            DataSet ds = add.selgoods(good);
            List<shangpinEntity> list = new List<shangpinEntity>();
            //通过循环遍历ds数据集中的所有数据 封装到List集合中 并返回出去
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                shangpinEntity Sy = new shangpinEntity();

                Sy.Sy商品编号 = ds.Tables[0].Rows[i]["商品编号"].ToString();
                Sy.Sy商品照片 = ds.Tables[0].Rows[i]["商品照片"].ToString();
                Sy.Sy商品名称 = ds.Tables[0].Rows[i]["商品名称"].ToString();
                Sy.Sy商品价格 = ds.Tables[0].Rows[i]["商品价格"].ToString();
                Sy.Sy商品数量 = int.Parse(ds.Tables[0].Rows[i]["商品数量"].ToString());
      
                list.Add(Sy);
            }
            return list;//返回数据

        }
        /// <summary>
        /// 把表一的数据家到
        /// </summary>
        /// <param name="good"></param>
        /// <returns></returns>
        public List<shangpinEntity> selgoods2(string good)
        {
            List<shangpinEntity> list = new List<shangpinEntity>();
            if (good != null && good != "商品编号/名称")
            {
                DataSet ds = add.selgoods(good);
                //List<shangpinEntity> list = new List<shangpinEntity>();
                //通过循环遍历ds数据集中的所有数据 封装到List集合中 并返回出去
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    shangpinEntity Sy = new shangpinEntity();

                    Sy.Sy商品编号 = ds.Tables[0].Rows[i]["商品编号"].ToString();
                    Sy.Sy商品照片 = ds.Tables[0].Rows[i]["商品照片"].ToString();
                    Sy.Sy商品名称 = ds.Tables[0].Rows[i]["商品名称"].ToString();
                    Sy.Sy商品价格 = ds.Tables[0].Rows[i]["商品价格"].ToString();
                    Sy.Sy商品数量 = int.Parse(ds.Tables[0].Rows[i]["商品数量"].ToString());

                    list.Add(Sy);
                }
              
            }
            else { MessageBox.Show("请选择要添加数量的商品"); }
                
            
            return list;//返回数据

        }


        /// <summary>
        /// 添加商品数量
        /// </summary>
        /// <param name="num"></param>
        /// <param name="good"></param>
        /// <returns></returns>
        public DataSet addnum(string num, string good)
        {
            return add.addnum(num, good);
           
        }


        //把商品加入 明细表

        public DataSet addmingxi(mingxiEntity Li)
        {
            
            return  add.addmingxi(Li);
        }

        // 结账单详细 明细 
        public List<mingxiEntity> selectmingxi(string uid)
        {
            DataSet ds = add.selectmingxi(uid);
            List<mingxiEntity> list = new List<mingxiEntity>();
            //通过循环遍历ds数据集中的所有数据 封装到List集合中 并返回出去
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                mingxiEntity Sy = new mingxiEntity();
                Sy.Li流水编号 = ds.Tables[0].Rows[i]["流水编号"].ToString();
                Sy.Li商品编号 = int.Parse(ds.Tables[0].Rows[i]["商品编号"].ToString());
                Sy.Li商品名称 = ds.Tables[0].Rows[i]["商品名称"].ToString();
                Sy.Li商品单价 = float.Parse( ds.Tables[0].Rows[i]["商品单价"].ToString());
                Sy.Li商品数量 =int.Parse( ds.Tables[0].Rows[i]["商品数量"].ToString());
                Sy.Li小计 = float.Parse(ds.Tables[0].Rows[i]["小计"].ToString());
                Sy.Li所属账单编号 = ds.Tables[0].Rows[i]["所属账单编号"].ToString();

                list.Add(Sy);
            }
            return list;//返回数据

        }

        // 结账表
        public List<jiezhangEntity> selectjiezhang(string uid)
        {
            DataSet ds = add.selectjiezhang(uid);
            List<jiezhangEntity> list = new List<jiezhangEntity>();
            //通过循环遍历ds数据集中的所有数据 封装到List集合中 并返回出去
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                jiezhangEntity Sy = new jiezhangEntity();
                Sy.Sy账单编号 = ds.Tables[0].Rows[i]["账单编号"].ToString();
                Sy.Sy支付方式 = ds.Tables[0].Rows[i]["支付方式"].ToString();
                Sy.Sy用户实付 = ds.Tables[0].Rows[i]["用户实付"].ToString();
                Sy.Sy找零 = ds.Tables[0].Rows[i]["找零"].ToString();
                Sy.Sy员工编号 = int.Parse(ds.Tables[0].Rows[i]["员工编号"].ToString());
                Sy.Sy购买数量 = ds.Tables[0].Rows[i]["商品购买数量"].ToString();
                Sy.Sy支付时间 = (DateTime)ds.Tables[0].Rows[i]["支付时间"];
                Sy.Sy结账状态 = int.Parse(ds.Tables[0].Rows[i]["结账状态"].ToString());

                list.Add(Sy);
            }
            return list;//返回数据

        }


        //挂单 
        public bool selectguadan()
        {
           
            return selectguadan();
        }



        //添加商品
        public bool Addgoods(shangpinEntity info)
        {
            return dal.Addgoods(info);

        }

        public bool Deletegoods(string id)
        {
            return dal.Deletegoods(id);
        }

        public bool Updategoods(shangpinEntity info, string id)
        {
            return dal.Updategoods(info, id);
        }


        //查询结账表
        public bool jiezhangdan(string uid)
        {
           
            return add.jiezhangdan(uid);
        }

    }
}
