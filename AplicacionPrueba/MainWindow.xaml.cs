using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AplicacionPrueba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        // DependencyProperty para Ejercicio 5
        public static readonly DependencyProperty PuntuacionProperty =
            DependencyProperty.Register("Puntuacion", typeof(int), typeof(MainWindow),
                new PropertyMetadata(50));

        public int Puntuacion
        {
            get { return (int)GetValue(PuntuacionProperty); }
            set { SetValue(PuntuacionProperty, value); }
        }
    }
}
