using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangdoibenhvien
{
    public partial class Form1 : Form
    {
        private DanhSachBN ds = new DanhSachBN();
        private DanhSachBN dsut=new DanhSachBN();
        int viTri = -1;
       
        private HangDoiUT hd = new HangDoiUT();
        public Form1()
        {
            InitializeComponent();
        }

        private void hienthi(DataGridView dgvdanhsachBn,List<BenhNhan>dsbenhnhan)
        {
            dgvdanhsachBn.DataSource = null;
            dgvdanhsachBn.DataSource=dsbenhnhan.ToList();
        }
        private void hienthiut(DataGridView dgvdsUuTien, List<BenhNhanUT> dsbenhnhanut)
        {
            dgvdsUuTien.DataSource = null;
            //dgvdsUuTien.DataSource = dsbenhnhanut.ToList();
            dgvdsUuTien.DataSource = hd.ToList();// lay ds tu hang doi
        }

        private void them_Click(object sender, EventArgs e)
        {
            string mabn = txtmaBn.Text;
            string hoten = txthoTen.Text;
            int tuoi = Convert.ToInt32(txtTuoi.Text);
            DateTime ngaysinh = dtpngaysinh.Value;
            string Quequan= ccbqueQuan.SelectedItem.ToString();
            string khoaKham=txtkhoaKham.Text;
            string gioiTinh = "";
            string tenbs = txttenbs.Text;
            string benhcd = txtbenhCd.Text;
            if (rbtnam.Checked)
            { gioiTinh = "Nam"; }
            else
            {  gioiTinh = "Nu"; }
            int doUuTien =Convert.ToInt32( txtdouutien.Text);
            BenhNhan a = new BenhNhan(mabn,hoten,tuoi,ngaysinh,Quequan,khoaKham,gioiTinh,doUuTien,benhcd, tenbs);
                     
            BenhNhanUT b = new BenhNhanUT(mabn,hoten,doUuTien);
            ds.Them(a);
            dsut.Themut(b);
            hd.Enqueue(b);
            hienthi(dgvdanhsachBn, ds.bn);
            hienthiut(dgvdsUuTien, dsut.bnut);
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string mabn = txtmaBn.Text;
            string hoten = txthoTen.Text;
            int tuoi = Convert.ToInt32(txtTuoi.Text);
            DateTime ngaysinh = dtpngaysinh.Value;
            string Quequan = ccbqueQuan.SelectedItem.ToString();
            string khoakham = txtkhoaKham.Text;
            string gioitinh = "";
            string tenbs = txttenbs.Text;
            string benhcd = txtbenhCd.Text;
            if(rbtnam.Checked)
            { gioitinh = "Nam"; }
            else
            { gioitinh = "Nu"; }
            int doUuTien =Convert.ToInt32(txtdouutien.Text);
            BenhNhan a = new BenhNhan(mabn, hoten, tuoi, ngaysinh, Quequan, khoakham, gioitinh, doUuTien,benhcd, tenbs);
            BenhNhanUT b = new BenhNhanUT(mabn, hoten, doUuTien);
            ds.Sua(a);
            dsut.Suaut(b);
            hienthi(dgvdanhsachBn,ds.bn);
            hienthiut(dgvdsUuTien, ds.bnut);
        }

        private void dgvdanhsachBn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            try
            {
               
                    if ( viTri > -1&& viTri <ds.bn.Count)
                    {
                        
                        BenhNhan b =ds.bn[viTri];
                        txtmaBn.Text = b.Mabn;
                        txthoTen.Text = b.Hoten;
                        txtTuoi.Text =b.Tuoi.ToString();
                        dtpngaysinh.Value=b.Ngaysinh;
                        if (b.Gioitinh == "Nam")
                            rbtnam.Checked = true;
                        else rbtnu.Checked = false;
                        ccbqueQuan.Text = b.Quequan;
                        txtkhoaKham.Text=b.Khoakham;
                        txttenbs.Text=b.Tenbs;
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi khi chon benh nhan.");
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            
            if(rbttimmabn.Checked)
            {
                string ma=txttimma.Text;
                BenhNhan bn = ds.Timma(ma);
                if(bn!=null)
                {
                    List<BenhNhan>timthayma= new List<BenhNhan> { bn };//tao 1 ds moi va ptu dau la bn
                    dgvdanhsachBn.DataSource = null;
                    dgvdanhsachBn.DataSource = timthayma;
                }
                else
                {
                    MessageBox.Show("khong tim thay ma??");
                }
            }
            else
            {
                return;
            }
        }

        private void btnxulybn_Click(object sender, EventArgs e)
        {
            BenhNhanUT bnut = hd.Dequeue();// lay bn tu hang doi uu tien
            if (bnut == null)
                return;
            MessageBox.Show($"Dang xu ly benh nhan: (HoTen: {bnut.Hoten} ) (DoUT: {bnut.Douutien} )");
          
            hienthiut(dgvdsUuTien, dsut.bnut);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            hienthi(dgvdanhsachBn, ds.bn);
        }
    }
}
