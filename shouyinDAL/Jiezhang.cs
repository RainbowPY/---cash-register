using shouyinModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shouyinDAL
{
    public class Jiezhang:SysqlHelp
    {

        jiezhangEntity js = new jiezhangEntity();
        public DataSet getjiezhang(jiezhangEntity gtjiezhang)
        {
            string sql = "select * from 结帐表 where 流水编号='"+js.Sy账单编号+"'";
            return sql_DataSet(sql);

        }


        public DataSet instjiezhang(jiezhangEntity zz)
        {
            string sql = "insert into 结帐表(账单编号) values('"+zz.Sy账单编号+"')";
            return sql_DataSet(sql);
        }

        //现金结账 

        public DataSet instjiezhang2(string zhang, string shifu, string zhaoling, string sum)
        {
            string sql = "update 结帐表  set 支付方式 = '现金支付', 用户实付 = '" + shifu+"',找零='"+zhaoling+"',员工编号='1',商品购买数量 ='"+sum+"',结账状态='2' where 账单编号='"+zhang+"'";
            return sql_DataSet(sql);
        }


        //在线结账 

        public DataSet instjiezhang3(string zhang, string shifu,  string sum)
        {
            string sql = "update 结帐表  set 支付方式 = '在线支付', 用户实付 = '" + shifu + "',找零='0',员工编号='1',商品购买数量 ='" + sum + "',结账状态='2' where 账单编号='" + zhang + "'";
            return sql_DataSet(sql);
        }


        //打印小票
        public DataSet selsctzhangdan(string zhang)
        {
            string sql = "select * from 结帐表 where  账单编号= '" + zhang + "'";
            return sql_DataSet(sql);
        }


        //删除明细表
        public bool deletejiezhang(string zandanid)
        {

            DataSet ds = sql_DataSet("select * from  [dbo].[明细表] where 所属账单编号='" + zandanid + "'");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {

                string sql = "delete from 明细表 where 所属账单编号='" + zandanid + "'";
                if (zengaishan(sql))
                {
                    return zengaishan("delete from 结帐表 where 账单编号='" + zandanid + "'");
                }

            }
            else
            {
                //如果结账明细表中没有此账单明细的话  直接删除账单
                return zengaishan("delete from 结帐表 where 账单编号='" + zandanid + "'");
            }




            return false;
        }

        //刷新

        public DataTable getjiezhang()
        {
            string sql = "select * from 结帐表 order by 支付时间 desc";
            return sql_DataSet(sql).Tables[0];

        }

        

    }
}
