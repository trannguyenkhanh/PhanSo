using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhanSo
{
    public class PhanSo
    {
        private int tu;
        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }
        private int mau;
        public int Mau
        {
            get { return mau; }
            set { tu = value; }
        }
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }
        public PhanSo(int x, int y)
        {
            tu = x;
            mau = y;
        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq;
            kq = new PhanSo();
            kq.tu = tu * p.mau + mau * p.tu;
            kq.mau = mau * p.mau;
            return kq;
        }
        public override string ToString()
        {
            return tu + "/" + mau;
        }

     
    }
}
