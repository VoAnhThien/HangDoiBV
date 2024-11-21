using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangdoibenhvien
{
    internal class DanhSachUuTien
    {
        private string m_mabnut;
        private string m_hotenbnut;
        private string m_douutien;
        public string Mabnut { get => m_mabnut; set => m_mabnut = value; }
        public string Hotenbnut { get => m_hotenbnut; set => m_hotenbnut = value; }
        public string Douutien { get => m_douutien; set => m_douutien = value; }

        public DanhSachUuTien()
        {
            Mabnut = "";
            Hotenbnut = "";
            Douutien = "";
        }
        public DanhSachUuTien(string mabnut,string hotenbnut,string douutien)
        {
            Mabnut = mabnut;
            Hotenbnut = hotenbnut;
            Douutien = douutien;
        }
        
    }
}
