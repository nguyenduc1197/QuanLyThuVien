using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Data.Entity;

namespace THKiemDinh
{
    /// <summary>
    /// Interaction logic for UPhieuTra.xaml
    /// </summary>
    public partial class UPhieuTra : UserControl
    {
        public UPhieuTra()
        {
            InitializeComponent();
            using (var db = new Model1())
            {
                cb_tinhtrangsachtra.ItemsSource = db.TINHTRANGs.ToList();
                cb_tinhtrangsachtra.SelectedValuePath = "id_tinhtrang";
                cb_tinhtrangsachtra.DisplayMemberPath = "tentinhtrang";

               if (datagrid_listphieutra.SelectedValue == null)
                {
                    btn_huyListPhieu.IsEnabled = false;
                    butThem_P.IsEnabled = false;
                }
               if (datagrid_listsachmuon.SelectedValue == null)
                {
                    btn_tratungcuon.IsEnabled = false;
                }
            }
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void ButThoat_PT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtTraCuu_PT_KeyUp(object sender, KeyEventArgs e)
        {
            using (var db = new Model1())
            {
                List<PHIEUMUONSACH> listpm = new List<PHIEUMUONSACH>();
                if (IsNumber(txtTraCuu_PT.Text))
                {
                    listpm = db.PHIEUMUONSACHes.Include(m => m.NHANVIEN).
                        Include(m => m.THETHANHVIEN).Where(m => m.THETHANHVIEN.sdt.Contains(txtTraCuu_PT.Text)
                        && m.datrasachhet == false).ToList();
                }
                else
                {
                    listpm = db.PHIEUMUONSACHes.Include(m => m.NHANVIEN).
                        Include(m => m.THETHANHVIEN).Where(m => m.THETHANHVIEN.tenkh.Contains(txtTraCuu_PT.Text)
                        && m.datrasachhet == false).ToList();
                }
                datagrid_listphieutra.ItemsSource = listpm;
            }
        }

        private void Btn_chonpm_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                var index = (PHIEUMUONSACH)datagrid_listphieutra.SelectedItem;
                var se = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                    .Include(m => m.SACH).Include(m => m.SACH.TINHTRANG)
                    .Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.id_phieumuon == index.id_phieumuonsach
                    && m.datra == false).ToList();
                datagrid_listsachmuon.ItemsSource = se;
                btn_huyListPhieu.IsEnabled = false;
                butThem_P.IsEnabled = true;
            }
        }

        public int TraVePhanTram(string id)
        {
            if (id == "tt1")
                return 100;
            else if (id == "tt2")
                return 70;
            else if (id == "tt3")
                return 50;
            else if (id == "tt4")
                return 49;
            return 0;
        }



        private void Btn_tratungcuon_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                var index = (MUONSACH)datagrid_listsachmuon.SelectedItem;
                var sach = db.SACHes.Where(m => m.id_sach == index.id_sach).FirstOrDefault();
                var phieumuon = db.PHIEUMUONSACHes.Where(m => m.id_phieumuonsach == index.id_phieumuon).FirstOrDefault();

                var tinhtrangsachtra = TraVePhanTram(cb_tinhtrangsachtra.SelectedValue.ToString());
                var muonsach = db.MUONSACHes.Where(m => m.id_muonsach == index.id_muonsach).FirstOrDefault();

                if (cb_tinhtrangsachtra.SelectedValue.ToString() == "tt3")
                {
                    phieumuon.tiendienbu += sach.giagoc / 2;
                   muonsach.datra = true;
                
                }
                else if (cb_tinhtrangsachtra.SelectedValue.ToString().Equals("tt2"))
                {
                    phieumuon.tiendienbu += (sach.giagoc * 30)/100;
                    muonsach.datra = true;
                }
                else if (cb_tinhtrangsachtra.SelectedValue.ToString().Equals("tt4"))
                {
                    phieumuon.tiendienbu += sach.giagoc;
                    muonsach.datra = true;
                }

                else if (cb_tinhtrangsachtra.SelectedValue.ToString().Equals("tt1"))
                {
                    muonsach.datra = true;
                }
                muonsach.ngaytra = DateTime.Now;
                db.Entry(muonsach).State = EntityState.Modified;
                db.Entry(phieumuon).State = EntityState.Modified;
                db.SaveChanges();
                var muonsach1 = db.MUONSACHes.Where(m => m.id_phieumuon == phieumuon.id_phieumuonsach &&
            m.datra == false).FirstOrDefault();
                if (muonsach1 == null)
                {
                    phieumuon.datrasachhet = true;
                    datagrid_listphieutra.ItemsSource = null;
                    MessageBox.Show("Khách hàng đã trả sách hết !");
                }
         
                db.Entry(phieumuon).State = EntityState.Modified;
                db.SaveChanges();
                lb_tienden.Content = "Tổng tiền đền" + phieumuon.tiendienbu.ToString();
                db.Entry(sach).State = EntityState.Modified;
                db.SaveChanges();
                var se = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                .Include(m => m.SACH).Include(m => m.SACH.TINHTRANG)
                .Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.id_phieumuon == phieumuon.id_phieumuonsach
                && m.datra == false).ToList();


                datagrid_listsachmuon.ItemsSource = se;
            }
        }

        private void ButThem_P_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                var index = (PHIEUMUONSACH)datagrid_listphieutra.SelectedItem;
                var muonsach = db.MUONSACHes.Where(m => m.id_phieumuon == index.id_phieumuonsach).ToList();
                foreach (var c in muonsach)
                {
                    c.ngaytra = DateTime.Now;
                    c.datra = true;
                }
                index.datrasachhet = true;
                db.Entry(index).State = EntityState.Modified;
                db.SaveChanges();

                var se = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
          .Include(m => m.SACH).Include(m => m.SACH.TINHTRANG)
          .Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.id_phieumuon == index.id_phieumuonsach
          && m.datra == false).ToList();


                datagrid_listsachmuon.ItemsSource = se;
                MessageBox.Show("Khách hàng đã trả sách hết !");

            }
        }

        private void Btn_huyListPhieu_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                cb_tinhtrangsachtra.ItemsSource = db.TINHTRANGs.ToList();
                datagrid_listsachmuon.ItemsSource = null;
            }
        }

        private void Datagrid_listsachmuon_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (datagrid_listsachmuon.SelectedValue == null)
            {
                btn_tratungcuon.IsEnabled = false;
                btn_huyListPhieu.IsEnabled = false;
            }
            else

            {
                btn_huyListPhieu.IsEnabled = true;
                btn_tratungcuon.IsEnabled = true;
            }
        }

        private void Btn_HuyChon_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                datagrid_listphieutra.ItemsSource = db.PHIEUMUONSACHes.ToList();
                cb_tinhtrangsachtra.ItemsSource = db.TINHTRANGs.ToList();
                txtTraCuu_PT.Text = "";
                datagrid_listphieutra.ItemsSource = null;
                datagrid_listsachmuon.ItemsSource = null;
            }
        }
    }
}
