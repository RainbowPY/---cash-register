using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shouyinModel
{
    public class mingxiEntity
    {

        private string li流水编号;
        private int li商品编号;
        private string li商品名称;
        private float li商品单价;
        private int li商品数量;
        private float li小计;
        private string li所属账单编号;

        public string Li流水编号 { get => li流水编号; set => li流水编号 = value; }
        public int Li商品编号 { get => li商品编号; set => li商品编号 = value; }
        public string Li商品名称 { get => li商品名称; set => li商品名称 = value; }
        public int Li商品数量 { get => li商品数量; set => li商品数量 = value; }
        
        public float Li小计 { get => li小计; set => li小计 = value; }
        public float Li商品单价 { get => li商品单价; set => li商品单价 = value; }
        public string Li所属账单编号 { get => li所属账单编号; set => li所属账单编号 = value; }
    }
}
