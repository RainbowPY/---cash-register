using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shouyinDAL;
using shouyinModel;

namespace shouyinDAL
{
    public class addgoods: SysqlHelp
    {
        
        
        //查找添加商品
       /* public DataSet addgood(string good)
        {
            string sql = "select * from 商品表 where (商品编号= '" + good + "' or o 商品编号 like '%" + good + "% ')";
            return sql_DataSet(sql);
        }*/


        //查询商品列表信息
        public DataSet selgoods(string good)
        {
            string sql = "select * from 商品表 where (商品编号= '" + good + "' or 商品名称 like '%" + good + "%')";
            return sql_DataSet(sql);
        }


        //查看选中的商品信息
        public DataSet selgoods2(string good)
        {
            string sql = "select * from 商品表 where 商品编号='"+good+"'  ";
            return sql_DataSet(sql);
        }




       // 添加商品数量
        public DataSet addnum(string good , string num) {
            int nums = int.Parse(num);
            string sql = "update 商品表 set 商品数量="+nums+"+(select 商品数量 from 商品表 where 商品编号= "+ good + " ) where 商品编号= "+ good + "";
            return sql_DataSet(sql);
        }




        //把商品添加到明细表中
        public DataSet addmingxi(mingxiEntity Li)
        {
            string sql = "insert into 明细表 values ('" + Li.Li流水编号 + "','"+Li.Li商品编号+"','" + Li.Li商品名称 + "','" + Li.Li商品单价 + "','" + Li.Li商品数量 + "','" + Li.Li小计 + "','"+Li.Li所属账单编号+"')";
            return sql_DataSet(sql);
        }


        //查询明细表

        public DataSet selectmingxi(string uid)
        {
            string sql = "select * from  明细表 where 所属账单编号='" + uid + "' ";
            return sql_DataSet(sql);
        }

        //查询明细表
        public DataSet selectjiezhang(string uid)
        {
            string sql = "select * from  结帐表 where 账单编号='" + uid + "' ";
            return sql_DataSet(sql);
        }


        //挂单查询
        public bool selectguadan(string uid)
        {
            string sql = "select * from 明细表  where 所属账单编号 in   (select  账单编号 from  结帐表 where 结账状态='1' )";
            return zengaishan(sql);
        }


        //查询结账表
        public bool jiezhangdan (string uid) 
        {
            string sql = "select * from 结帐表 where 账单编号='" + uid + "'";
            return zengaishan(sql);
        }

    }
}
