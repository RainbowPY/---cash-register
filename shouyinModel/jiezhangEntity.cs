using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shouyinModel
{
    public class jiezhangEntity
    {
        //结账实体类
        private string sy账单编号;
        private string sy支付方式;
        private string sy用户实付;
        private string sy找零;
        private DateTime sy支付时间;
       

        private int sy员工编号;
        private string sy购买数量;
        private int sy结账状态;

      
        public string Sy支付方式 { get => sy支付方式; set => sy支付方式 = value; }
        public string Sy用户实付 { get => sy用户实付; set => sy用户实付 = value; }
        public string Sy找零 { get => sy找零; set => sy找零 = value; }
        public DateTime Sy支付时间 { get => sy支付时间; set => sy支付时间 = value; }
 
        public int Sy员工编号 { get => sy员工编号; set => sy员工编号 = value; }
        public string Sy购买数量 { get => sy购买数量; set => sy购买数量 = value; }
        public int Sy结账状态 { get => sy结账状态; set => sy结账状态 = value; }
        public string Sy账单编号 { get => sy账单编号; set => sy账单编号 = value; }
    }
}
