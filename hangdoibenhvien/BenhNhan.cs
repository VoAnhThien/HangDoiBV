using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangdoibenhvien
{
    internal class BenhNhan
    {

        private string m_mabn;
        private string m_hoten;
        private int m_tuoi;
        private DateTime m_ngaysinh;
        private string m_gioitinh;
        private string m_quequan;
        private string m_khoakham;
        private int m_douutien;
        private string m_tenbs;
        private string m_benhcd;
        public string Mabn { get => m_mabn; set => m_mabn = value; }
        public string Hoten { get => m_hoten; set => m_hoten = value; }
        public int Tuoi { get => m_tuoi; set => m_tuoi = value; }
        public DateTime Ngaysinh { get => m_ngaysinh; set => m_ngaysinh = value; }
        public string Quequan { get => m_quequan; set => m_quequan = value; }
        public string Khoakham { get => m_khoakham; set => m_khoakham = value; }
        public string Gioitinh { get => m_gioitinh; set => m_gioitinh = value; }
        public int Douutien { get => m_douutien; set => m_douutien = value; }
        public string Tenbs { get => m_tenbs; set => m_tenbs = value; }
        public string Benhcd { get => m_benhcd; set => m_benhcd = value; }

        public BenhNhan() 
        {
            Mabn = "";
            Hoten = "";
            Tuoi = 0;
            DateTime Ngaysinh = DateTime.Now;
            Gioitinh = "";
            Quequan = "";
            Khoakham = "";
            Douutien = 0;
            Tenbs = "";
            Benhcd = "";
        }
        public BenhNhan(string mabn, string hoten, int tuoi, DateTime ngaysinh, string noio, string khoakham,string gioitinh,int douutien,string benhcd,string tenbs)
        {
            Mabn = mabn;
            Hoten = hoten;
            Tuoi = tuoi;
            Ngaysinh = ngaysinh;
            Gioitinh = gioitinh;
            Quequan = noio;
            Khoakham = khoakham;
            Douutien = douutien;
            Tenbs=tenbs;
            Benhcd = benhcd;
        }
    }
}
