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

namespace THKiemDinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UPhieuMuon pm = new UPhieuMuon();
            MainGrid.Children.Clear();
            pm.Margin = new Thickness(0);
            MainGrid.Children.Add(pm);
            string whiteBrush = (string)Application.Current.Resources["ApplicationScopeResource"];
            temp.Content = whiteBrush;
        }

        private void Btn_PhieuMuon_Click(object sender, RoutedEventArgs e)
        {
            UPhieuMuon pm = new UPhieuMuon();
            MainGrid.Children.Clear();
            pm.Margin = new Thickness(0);
            MainGrid.Children.Add(pm);
        }

        private void Btn_PhieuTra_Click(object sender, RoutedEventArgs e)
        {
            UPhieuTra pm = new UPhieuTra();
            MainGrid.Children.Clear();
            pm.Margin = new Thickness(0);
            MainGrid.Children.Add(pm);
        }

        private void Btn_TimKiem_Click(object sender, RoutedEventArgs e)
        {
            UTimKiem pm = new UTimKiem();
            MainGrid.Children.Clear();
            pm.Margin = new Thickness(0);
            MainGrid.Children.Add(pm);
        }

        private void Btn_BaoCaoNgay_Click(object sender, RoutedEventArgs e)
        {
            UBaoCaoNgay pm = new UBaoCaoNgay();
            MainGrid.Children.Clear();
            pm.Margin = new Thickness(0);
            MainGrid.Children.Add(pm);
        }

        private void Btn_BaoCaoMuonTra_Click(object sender, RoutedEventArgs e)
        {
            UBaoCaoMuonTra pm = new UBaoCaoMuonTra();
            MainGrid.Children.Clear();
            pm.Margin = new Thickness(0);
            MainGrid.Children.Add(pm);
        }

        private void Btn_BaoCaoSach_Click(object sender, RoutedEventArgs e)
        {
            UBaoCaoSach pm = new UBaoCaoSach();
            MainGrid.Children.Clear();
            pm.Margin = new Thickness(0);
            MainGrid.Children.Add(pm);
        }

        private void BtnThoat_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
