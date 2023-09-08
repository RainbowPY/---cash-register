using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shouyinModel
{
    public class shangpinEntity
    {
        private string sy商品名称;
        private string sy商品编号;
        private string sy商品价格;
        private string sy商品照片;
        private int sy商品数量;

        public string Sy商品名称 { get => sy商品名称; set => sy商品名称 = value; }
        public string Sy商品编号 { get => sy商品编号; set => sy商品编号 = value; }
        public string Sy商品价格 { get => sy商品价格; set => sy商品价格 = value; }
        public string Sy商品照片 { get => sy商品照片; set => sy商品照片 = value; }
        public int Sy商品数量 { get => sy商品数量; set => sy商品数量 = value; }
    }
}
