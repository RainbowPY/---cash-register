using shouyinDAL;
using shouyinModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shouyinBLL
{
    public class Yuanggongbll
    {

        Yuangong yy = new Yuangong();

        public bool insertYG(shouyinEntity YH)
        {
            return yy.insertYG(YH);
            
        }


        public List<shouyinEntity> GetYGlistAll()
        {
            DataSet ds = yy.GetYGlistAll();
            List<shouyinEntity> list = new List<shouyinEntity>();

            for (int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                shouyinEntity se=new shouyinEntity();
                se.Sy员工编号 = ds.Tables[0].Rows[i]["员工编号"].ToString();
                se.Sy员工姓名 = ds.Tables[0].Rows[i]["员工姓名"].ToString();
                se.Sy员工电话 = ds.Tables[0].Rows[i]["员工电话"].ToString();
                se.Sy员工登录密码 = ds.Tables[0].Rows[i]["员工登陆密码"].ToString();
                se.Sy员工性别 = ds.Tables[0].Rows[i]["员工性别"].ToString();
                
                list .Add(se);


            }
            return list;



            
        }
        public bool deleteYglist(string YGID)
        { 
            return yy.deleteYglist(YGID); 
        }


        }
}
