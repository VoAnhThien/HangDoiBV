using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace hangdoibenhvien
{

    internal class DanhSachBN
    {
        private List<BenhNhan> benhnhan;
        private List<BenhNhanUT> benhnhanut;
        public List<BenhNhan> bn
        {
            get { return benhnhan; }
        }
        public List<BenhNhanUT>bnut
        {
            get { return benhnhanut; }
        }
        public DanhSachBN()
        {
            this.benhnhan = new List<BenhNhan>();
            this.benhnhanut=new List<BenhNhanUT>();
        }
        public DanhSachBN(List<BenhNhan> benhnhan,List<BenhNhanUT>benhnhanut)
        {
            this.benhnhan = benhnhan;
            this.benhnhanut = benhnhanut;
        }
        
        public bool Them(BenhNhan bn)
        {
            if(ktrma(bn.Mabn))
            {
                MessageBox.Show("Ma da ton tai!!");
                return false;
            }
            else
            {
                this.benhnhan.Add(bn);
                return true;
            }
        }
        public bool Themut(BenhNhanUT bnut)
        {
            if(ktrmaut(bnut.Mabn))
            {
                MessageBox.Show("Ma da ton tai!!");
                return false;
            }
            else
            {
                this.benhnhanut.Add(bnut);
                return true;
            }
        }
        public bool ktrma(string ma)
        {
            foreach(BenhNhan a in benhnhan)
            {
                if(a.Mabn.Equals(ma))
                {
                    return true;
                }
            }
            return false;
        }
        public bool ktrmaut(string ma)
        {
            foreach (BenhNhanUT a in benhnhanut)
            {
                if (a.Mabn.Equals(ma))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Sua(BenhNhan bn)
        {
            this.benhnhan.Add(bn);
            return true;
        }
        public bool Suaut(BenhNhanUT bnut)
        {
            this.benhnhanut.Add(bnut);
            return true;
        }
        public BenhNhan Timma(string mabn)
        {
            foreach(BenhNhan a in benhnhan)
            {
                if(a.Mabn==mabn)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
