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

namespace TELA
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string usuario = bt_usuario.Text;
            string senha = bt_senha1.Password;

           
            

            if (usuario == "admin" && senha == "123")
            {
                telaPrincipal tela = new telaPrincipal();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usário ou senha incorreta");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_senha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
