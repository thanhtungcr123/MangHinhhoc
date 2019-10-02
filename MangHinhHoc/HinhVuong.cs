using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangHinhHoc
{
    class HinhVuong:HinhHoc
    {
        private float Canh;
        public HinhVuong(float stCanh) : base()
        {
            Canh = stCanh;
        }
        public float canh
        {
            get { return Canh; }
            set { Canh = value; }
        }
        public override float CV()
        {
            return Canh * 2 * 2;
        }
        public override float DT()
        {
            return Canh * canh;
        }
    }
}
