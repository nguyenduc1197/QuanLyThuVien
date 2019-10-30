using System;
using System.Collections.Generic;
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
using System.Data.Entity;
using THKiemDinh.Models;

namespace THKiemDinh
{
    /// <summary>
    /// Interaction logic for UTimKiem.xaml
    /// </summary>
    public partial class UTimKiem : UserControl
    {
        public UTimKiem()
        {
            InitializeComponent();

            using (var db = new Model1())
            {

            }
        }

        private void Btn_timkiem_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem items = (ComboBoxItem)cbDieuKien_TK.SelectedItem;
            using (var db = new Model1())
            {
                if (items.Content.ToString() == "Theo mượn")
                {
                    datagrid_timkiem.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                        .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.datra == false &&
                        m.PHIEUMUONSACH.THETHANHVIEN.tenkh.Contains(txtThongTin_TK.Text)).ToList();
                }
                else if (items.Content.ToString() == "Theo trả")
                {
                    datagrid_timkiem.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                        .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.datra == true &&
                          m.PHIEUMUONSACH.THETHANHVIEN.tenkh.Contains(txtThongTin_TK.Text)).ToList();
                }

                else if (items.Content.ToString() == "Tên sách")
                {
                    datagrid_timkiem.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                        .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.SACH.tensach.Contains(txtThongTin_TK.Text)).ToList();
                }
            }
        }



        private void Btn_xoarow_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem items = (ComboBoxItem)cbDieuKien_TK.SelectedItem;
            using (var db = new Model1())
            {
                if (items.Content.ToString() == "Theo mượn")
                {
                    if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        var index = (MUONSACH)datagrid_timkiem.SelectedItem;
                        var se = db.MUONSACHes.Where(m => m.id_muonsach == index.id_muonsach).FirstOrDefault();
                        db.MUONSACHes.Remove(se);
                        db.SaveChanges();
                        datagrid_timkiem.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                            .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.datra == false &&
                            m.PHIEUMUONSACH.THETHANHVIEN.tenkh.Contains(txtThongTin_TK.Text)).ToList();
                    }
                }
                else if (items.Content.ToString() == "Theo trả")
                {
                    if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButton.YesNo,
               MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        var index = (MUONSACH)datagrid_timkiem.SelectedItem;
                        var se = db.MUONSACHes.Where(m => m.id_muonsach == index.id_muonsach).FirstOrDefault();
                        db.MUONSACHes.Remove(se);
                        db.SaveChanges();
                        datagrid_timkiem.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                            .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.datra == true &&
                              m.PHIEUMUONSACH.THETHANHVIEN.tenkh.Contains(txtThongTin_TK.Text)).ToList();
                    }
                }

                else if (items.Content.ToString() == "Tên sách")
                {
                    if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButton.YesNo,
               MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        var index = (MUONSACH)datagrid_timkiem.SelectedItem;
                        var se = db.MUONSACHes.Where(m => m.id_muonsach == index.id_muonsach).FirstOrDefault();
                        db.MUONSACHes.Remove(se);
                        db.SaveChanges();
                        datagrid_timkiem.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                            .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.SACH.tensach.Contains(txtThongTin_TK.Text)).ToList();
                        if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButton.YesNo,
               MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                        }



                    }
                }
            }
        }
    }
}
