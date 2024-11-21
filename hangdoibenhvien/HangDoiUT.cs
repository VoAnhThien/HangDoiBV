using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangdoibenhvien
{
    internal class HangDoiUT
    {
        private List<BenhNhanUT> queue=new List<BenhNhanUT> ();
        public void Enqueue(BenhNhanUT bn)
        {
            queue.Add(bn);// them bn vao hang doi
            queue=queue.OrderBy(x=> x.Douutien).ToList();// sap xep bn theo muc uu tien
        }

        public BenhNhanUT Dequeue()// Lay bn ut ra khoi hang doi
        {
            if(queue.Count == 0)
            {
                MessageBox.Show("hang doi trong.");
                return null;
            }
            BenhNhanUT bn = queue[0];
            queue.RemoveAt(0);
            return bn;
        }
        public BenhNhanUT xembn()
        {
            if(queue.Count == 0)
            {
                MessageBox.Show("hang doi trong.");
                return null;
            }
            return queue.First();
        }
        public int Count =>queue.Count;// so luong benh nhan trong hang doi
        public bool isEmpty =>queue.Count == 0;
        public List<BenhNhanUT>ToList()// ds benh nhan hien tai de hien thi len.
        {
            return queue;
        }
        

    }
}
