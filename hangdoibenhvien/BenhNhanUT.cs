using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangdoibenhvien
{
    internal class BenhNhanUT
    {
        private string m_mabn;
        private string m_hoten;
        private int m_douutien;

        public string Mabn { get => m_mabn; set => m_mabn = value; }
        public string Hoten { get => m_hoten; set => m_hoten = value; }
        public int Douutien { get => m_douutien; set => m_douutien = value; }

        public BenhNhanUT()
        {
            Mabn = "";
            Hoten = "";
            Douutien = 0;
        }
        public BenhNhanUT(string mabn, string hoten, int douutien)
        {
            Mabn = mabn;
            Hoten = hoten;
            Douutien = douutien;
        }

    }
}
