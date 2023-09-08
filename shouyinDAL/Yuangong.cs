using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shouyinModel;

namespace shouyinDAL
{
    public class Yuangong:SysqlHelp
    {
        //添加员工表

        public bool insertYG(shouyinEntity YH)     {

            string sql= "insert into 收银员表 values('"+YH.Sy员工编号+"','"+YH.Sy员工姓名+"','"+YH.Sy员工电话+"','"+YH.Sy员工登录密码+"','"+YH.Sy员工性别+"')";

            return zengaishan(sql);

        } 

        //获取所有的员工信息
        public DataSet GetYGlistAll()
        {
            string sql = "select * from 收银员表";
            return sql_DataSet(sql);

        }

        public bool deleteYglist(string YGID)
        {
           
            string sql="delete from 收银员表 where 员工编号= "+ YGID;
            return zengaishan(sql);

        }

    }
}
