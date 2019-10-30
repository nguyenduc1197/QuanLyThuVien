using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using THKiemDinh.Models;

namespace THKiemDinh
{
    /// <summary>
    /// Interaction logic for UPhieuMuon.xaml
    /// </summary>
    public partial class UPhieuMuon : UserControl
    {

        public UPhieuMuon()
        {
            InitializeComponent();
            using (var db = new Model1())
            {
                cb_thethanhvien.ItemsSource = db.THETHANHVIENs.ToList();
                cb_thethanhvien.SelectedValuePath = "id_thethanhvien";
                cb_thethanhvien.DisplayMemberPath = "tenkh";
                cb_thethanhvien.SelectedIndex = 0;

                cb_nv.ItemsSource = db.NHANVIENs.ToList();
                cb_nv.SelectedValuePath = "id_nv";
                cb_nv.DisplayMemberPath = "tennv";
                cb_nv.SelectedIndex = 0;

                cb_sach.ItemsSource = db.SACHes.ToList();
               cb_sach.SelectedValuePath = "id_sach";
               cb_sach.DisplayMemberPath = "tensach";
               cb_sach.SelectedIndex = 0;


                //var result = (from m in db.MUONSACHes
                //              join p in db.SACHes on m.id_sach equals p.id_sach
                //              join t in db.TINHTRANGs on p.id_tinhtrangsach equals t.id_tinhtrang
                //              join pm in db.PHIEUMUONSACHes on m.id_phieumuon equals pm.id_phieumuonsach
                //              join tt in db.THETHANHVIENs on pm.id_the equals tt.id_thethanhvien
                //              join l in db.LOAISACHes on p.id_loai equals l.id_loaisach
                //              where p.id_sach != null
                //              select new
                //              {
                //                  m.soluong,
                //                  p.tensach,
                //                  l.tenloaisach,
                //                  tt.tenkh,
                //                  t.tentinhtrang,
                //                  p.giagoc
                //              }).ToList();


              



                var listphieumuonsach = db.PHIEUMUONSACHes.Where(m => m.id_the == cb_thethanhvien
                .SelectedValue.ToString() && m.saved == false).ToList();
              foreach(var c in listphieumuonsach)
                {
                    var listmuonsach = db.MUONSACHes.Where(m => m.id_phieumuon == c.id_phieumuonsach)
                        .ToList();
                    foreach(var cc in listmuonsach)
                    {
                        db.MUONSACHes.Remove(cc);
                    }
                    db.PHIEUMUONSACHes.Remove(c);
                    db.SaveChanges();
                }

            }
        }

        private void Btn_Huy_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                cb_nv.ItemsSource = db.NHANVIENs.ToList();


                cb_sach.ItemsSource = db.SACHes.ToList();

                txt_SoLuong.Text = "";
                cb_thethanhvien.ItemsSource = db.THETHANHVIENs.ToList();
                dp_ngaytra.Text = "";
                datagrid_listsachmuon.ItemsSource = null;
            }
        }

        private void ButThemSach_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                cb_thethanhvien.IsEnabled = false;
                cb_nv.IsEnabled = false;
                dp_ngaytra.IsEnabled = false;
                var find = db.PHIEUMUONSACHes.Where(m => m.id_the == cb_thethanhvien.SelectedValue.ToString()
                 && m.datrasachhet == false && m.saved == false && m.datrasachhet == false).FirstOrDefault();
                var count = db.PHIEUMUONSACHes.ToList();

                var countms = db.MUONSACHes.ToList();
              var id_phieu = "PMS_" + count.Count.ToString();
                var id_ms = "MS_" + countms.Count.ToString();
                if (find == null)
                {

                    db.PHIEUMUONSACHes.Add(new PHIEUMUONSACH
                    {
                        id_the = cb_thethanhvien.SelectedValue.ToString(),
                        id_phieumuonsach = id_phieu,
                        ngaytra = Convert.ToDateTime(dp_ngaytra.ToString()),
                        ngaymuon = DateTime.Now,
                        id_nv = cb_nv.SelectedValue.ToString(),
                        datrasachhet = false,
                        tiendienbu = 0,
                        saved = false
                    });
                    db.SaveChanges();
                }
                var find1 = db.PHIEUMUONSACHes.Where(m => m.id_the == cb_thethanhvien.SelectedValue.ToString()
                && m.datrasachhet == false && m.saved == false && m.datrasachhet == false).FirstOrDefault();

                var find_ctphieu = db.MUONSACHes.Where(m => m.id_sach == cb_sach.SelectedValue.ToString()
                && m.id_phieumuon == find1.id_phieumuonsach).FirstOrDefault();

                var sach = db.SACHes.Where(m => m.id_sach == cb_sach.SelectedValue.ToString()).FirstOrDefault();
                if (find_ctphieu == null)
                {
                    var muonsach = new MUONSACH
                    {
                        id_muonsach = id_ms,
                        id_sach = cb_sach.SelectedValue.ToString(),
                        id_phieumuon = find1.id_phieumuonsach,
                        soluong = 0,
                        datra = false
                        
                    
                    };

                    db.MUONSACHes.Add(muonsach);
                    db.SaveChanges();
                    find_ctphieu = muonsach;
                }

                find_ctphieu.soluong = find_ctphieu.soluong + int.Parse(txt_SoLuong.Text);
                db.Entry(find_ctphieu).State = EntityState.Modified;
                db.SaveChanges();
                cb_thethanhvien.ItemsSource = db.THETHANHVIENs.ToList();
                cb_thethanhvien.SelectedIndex = 0;

                cb_nv.ItemsSource = db.NHANVIENs.ToList();
                cb_nv.SelectedIndex = 0;

                cb_sach.ItemsSource = db.SACHes.ToList();
                cb_sach.SelectedIndex = 0;

                //var result = (from m in db.MUONSACHes
                //              join p in db.SACHes on m.id_sach equals p.id_sach
                //              join t in db.TINHTRANGs on p.id_tinhtrangsach equals t.id_tinhtrang
                //              join pm in db.PHIEUMUONSACHes on m.id_phieumuon equals pm.id_phieumuonsach
                //              join tt in db.THETHANHVIENs on pm.id_the equals tt.id_thethanhvien
                //              join l in db.LOAISACHes on p.id_loai equals l.id_loaisach
                //              where m.id_phieumuon == find1.id_phieumuonsach
                //              select new
                //              {
                //                  m.soluong,
                //                  p.tensach,
                //                  l.tenloaisach,
                //                  tt.tenkh,
                //                  t.tentinhtrang,
                //                  p.giagoc
                //              }).ToList();


                //datagrid_listsachmuon.ItemsSource = result;

                datagrid_listsachmuon.ItemsSource = db.MUONSACHes.Include(m => m.SACH.TINHTRANG).Include(m => m.SACH.LOAISACH).Where(m => m.id_phieumuon ==
               find1.id_phieumuonsach).ToList();
            }
        }

        private void Btn_Luu_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                var phieumuonsach = db.PHIEUMUONSACHes.Where(m => m.id_the == cb_thethanhvien
                .SelectedValue.ToString() && m.saved == false).FirstOrDefault();
                phieumuonsach.saved = true;
                db.Entry(phieumuonsach).State = EntityState.Modified;
                db.SaveChanges();
                cb_thethanhvien.ItemsSource = db.THETHANHVIENs.ToList();


                cb_nv.ItemsSource = db.NHANVIENs.ToList();
         

                cb_sach.ItemsSource = db.SACHes.ToList();

                cb_thethanhvien.IsEnabled = true;
                cb_sach.IsEnabled = true;
                cb_nv.IsEnabled = true;
                dp_ngaytra.IsEnabled = true;

                txt_SoLuong.Text = "";

                dp_ngaytra.Text = "";
                datagrid_listsachmuon.ItemsSource = null;
                MessageBox.Show("Bạn đã Lưu thành công !");
            }
        }


        private void Btn_xoarow_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                var index = (MUONSACH)datagrid_listsachmuon.SelectedItem;
                var se = db.MUONSACHes.Where(m => m.id_muonsach == index.id_muonsach).FirstOrDefault();
               db.MUONSACHes.Remove(se);
                db.SaveChanges();


                //          var result = (from m in db.MUONSACHes
                //                        join p in db.SACHes on m.id_sach equals p.id_sach
                //                        join t in db.TINHTRANGs on p.id_tinhtrangsach equals t.id_tinhtrang
                //                        join pm in db.PHIEUMUONSACHes on m.id_phieumuon equals pm.id_phieumuonsach
                //                        join tt in db.THETHANHVIENs on pm.id_the equals tt.id_thethanhvien
                //                        join l in db.LOAISACHes on p.id_loai equals l.id_loaisach
                //                        select new temp()
                //                        {
                //                            soluong = m.soluong,
                //                            tensach = p.tensach,
                //                            tenloaisach = l.tenloaisach,
                //                            tenkh = tt.tenkh,
                //                            tentinhtrang = t.tentinhtrang,
                //                            giagoc = p.giagoc
                //                        }).Distinct().ToList();


                //          var user = db.PHIEUMUONSACHes.Where(m => m.id_the == cb_thethanhvien.SelectedValue.ToString())
                //.FirstOrDefault();
                //          datagrid_listsachmuon.ItemsSource = result;

                var user = db.PHIEUMUONSACHes.Where(m => m.id_the == cb_thethanhvien.SelectedValue.ToString())
        .FirstOrDefault();
                datagrid_listsachmuon.ItemsSource = db.MUONSACHes.Include(m => m.SACH.TINHTRANG).Include(m => m.SACH.LOAISACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Include(m => m.SACH).Where(m => m.id_phieumuon == user.id_phieumuonsach).ToList();
            }
        }
    }
}
