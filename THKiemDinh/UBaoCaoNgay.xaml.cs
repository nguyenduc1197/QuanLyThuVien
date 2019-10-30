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
using THKiemDinh.Models;
using System.Data.Entity;
namespace THKiemDinh
{
    /// <summary>
    /// Interaction logic for UBaoCaoNgay.xaml
    /// </summary>
    public partial class UBaoCaoNgay : UserControl
    {
        public UBaoCaoNgay()
        {
            InitializeComponent();
        }

        private void ButLoc_BCN_Click(object sender, RoutedEventArgs e)
        {
           string a = dp_tungay.ToString();
            string aa = dp_denngay.ToString();

            DateTime b = Convert.ToDateTime(a);
            DateTime bb = Convert.ToDateTime(aa);
            int c = DateTime.Compare(DateTime.Parse(dp_tungay.Text),bb);
            using (var db = new Model1())
            {   
                datagrid_bcn.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                    .Include(m => m.SACH)
                    .Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.PHIEUMUONSACH.ngaymuon >= b && m.PHIEUMUONSACH.ngaymuon <= bb).ToList();

            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string a = dp_tungay.ToString();
            string aa = dp_denngay.ToString();
            if (a == null || aa == null)
            {
                txt_tenkh.IsEnabled = false;
            }
            DateTime b = Convert.ToDateTime(a);
            DateTime bb = Convert.ToDateTime(aa);
            int c = DateTime.Compare(DateTime.Parse(dp_tungay.Text), bb);
            using (var db = new Model1())
            {
                datagrid_bcn.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                    .Include(m => m.SACH)
                    .Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.PHIEUMUONSACH.ngaymuon >= b && m.PHIEUMUONSACH.ngaymuon <= bb && 
                   m.PHIEUMUONSACH.THETHANHVIEN.tenkh.Contains(txt_tenkh.Text)).ToList();

            }
        }
    }
}
