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
    /// Interaction logic for UBaoCaoMuonTra.xaml
    /// </summary>
    public partial class UBaoCaoMuonTra : UserControl
    {
        public UBaoCaoMuonTra()
        {
            InitializeComponent();
        }

        private void ButLoc_BCMT_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Model1())
            {
                datagrid_bcmuontra.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                    .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m => m.datra == false || m.datra == true).ToList() ;
            }
        }

        private void Txt_tenkh_KeyUp(object sender, KeyEventArgs e)
        {
            using (var db = new Model1())
            {
                datagrid_bcmuontra.ItemsSource = db.MUONSACHes.Include(m => m.PHIEUMUONSACH)
                    .Include(m => m.SACH).Include(m => m.PHIEUMUONSACH.THETHANHVIEN).Where(m =>  
                    m.PHIEUMUONSACH.THETHANHVIEN.tenkh.Contains(txt_tenkh.Text)).ToList();
            }
        }
    }
}
