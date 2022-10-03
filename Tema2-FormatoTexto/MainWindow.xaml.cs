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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AzulButton.IsChecked = true;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TituloTextBlock.FontWeight = FontWeights.Bold;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TituloTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CuadroTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TituloTextBlock.Text = CuadroTextBox.Text;
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TituloTextBlock.FontStyle = FontStyles.Italic;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TituloTextBlock.FontStyle = FontStyles.Normal;
        }

        private void AzulButton_Checked(object sender, RoutedEventArgs e)
        {
            TituloTextBlock.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void RojoButton_Checked(object sender, RoutedEventArgs e)
        {
            TituloTextBlock.Foreground = new SolidColorBrush(Colors.Red);

        }

        private void VerdeButton_Checked(object sender, RoutedEventArgs e)
        {
            TituloTextBlock.Foreground = new SolidColorBrush(Colors.Green);
        }

    }
}
