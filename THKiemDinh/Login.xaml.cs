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
using System.Windows.Shapes;
using THKiemDinh.Models;

namespace THKiemDinh
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        public ACCOUNT VerifyAccount(string username,string password)
        {
            ACCOUNT acc;
            using (var db = new Model1())
            {
                acc = db.ACCOUNTs.Where(m => m.username == username && m.password == password)
                    .FirstOrDefault();

            }
            return acc;
        }
        private void Btn_login_Click(object sender, RoutedEventArgs e)
        {
         
            using (var db = new Model1())
            {
                if (VerifyAccount(txt_username.Text, txt_password.Password.ToString()) != null)
                {
                    Application.Current.Resources["ApplicationScopeResource"] = txt_username.Text;
                    MainWindow main = new MainWindow();

                    main.Show();
        
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
                }
            }
        }
    }
}
