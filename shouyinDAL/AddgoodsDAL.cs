using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shouyinModel;

namespace shouyinDAL
{
    public class AddgoodsDAL: SysqlHelp
    {
        public bool Addgoods(shangpinEntity info)
        {
            string sql = "insert into 商品表(商品编号,商品名称,商品价格,商品照片)"
                + "values('"+ info.Sy商品编号+"','"+ info.Sy商品名称 + "','"+ info.Sy商品价格 +
                "','"+ info.Sy商品照片 + "')";
            return zengaishan (sql);
        }
        public bool Deletegoods(string id) {
            string sql = "delete from 商品表 where 商品编号='"+id+"'";
            return zengaishan (sql);
        }
        public bool Updategoods(shangpinEntity info,string id) {
            string sql = "update 商品表 set 商品名称='" + info.Sy商品名称 + "'" +
                ",商品价格='" + info.Sy商品价格 + "',商品照片='" + info.Sy商品照片 + "',商品数量='" + info.Sy商品数量 + "' where 商品编号='"+id+"'"  ;
            return zengaishan (sql);
        }
    }
}
