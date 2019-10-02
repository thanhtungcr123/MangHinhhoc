using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangHinhHoc
{
    class HinhTron:HinhHoc
    {
        private float BK;
        private const float PI = 3.14f;
        public float bk
        {
            get { return BK; }
            set { BK = value; }
        }
        public HinhTron(float stBK)
        {
            BK = stBK;
        }
        public override float CV()
        {
            return base.CV() + bk * 3.14f;
        }
        public override float DT()
        {
            return base.DT() + bk * bk * 3.14f;
        }

    }
}
