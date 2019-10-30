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
    /// Interaction logic for UBaoCaoSach.xaml
    /// </summary>
    public partial class UBaoCaoSach : UserControl
    {
        public UBaoCaoSach()
        {
            InitializeComponent();
        }

        private void ButLoc_BCS_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                datagrid_bcsach.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                    .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).OrderBy(m => m.SACH.tensach).ToList();

            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            using (var db = new Model1())
            {
                datagrid_bcsach.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                    .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.SACH.tensach.Contains(txt_tensach.Text)).OrderBy(m => m.SACH.tensach).ToList();

            }
        }
    }
}
