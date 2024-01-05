using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    class CD
    {
        private int maCD;
        private string TuaCD;
        private string CaSy;
        private int SoBaiHat;
        private int GiaThanh;

        public CD(int maCD)
        {
            this.maCD = maCD;
        }
        public CD(int maCD,string TuaCD,string CaSy,int SoBaiHat,int GiaThanh)
        {
            this.maCD = maCD;
            this.TuaCD = TuaCD;
            this.CaSy = CaSy;
            this.SoBaiHat = SoBaiHat;
            this.GiaThanh = GiaThanh;
        }
        public int MaCD
        {
            set { this.maCD = value;  }
            get { return maCD; }
        }
        public string tuaCD
        {
            set { this.tuaCD = value; }
            get { return TuaCD; }
        }
        public string casy
        {
            set { this.casy = value; }
            get { return casy; }
        }
        public int sobaihat
        {
            set { this.SoBaiHat = value; }
            get { return SoBaiHat; }
        }
        public int giathanh
        {
            set { this.GiaThanh = value; }
            get { return GiaThanh; }
        }
        public string ToString()
        {
            return string.Format("{0, 10} {1,30} {2,30} {3,10} {4, 15:#,##0}", MaCD, TuaCD, casy, sobaihat, GiaThanh);
        }
    }
}
