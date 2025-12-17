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

namespace MiLibreriaWPF
{
    /// <summary>
    /// Lógica de interacción para CampoDeTextoDP.xaml
    /// </summary>
    public partial class CampoDeTextoDP : UserControl
    {
        public CampoDeTextoDP()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty EtiquetaProperty =
            DependencyProperty.Register("Etiqueta", typeof(string), typeof(CampoDeTextoDP),
                new PropertyMetadata("Etiqueta"));

        public string Etiqueta
        {
            get { return (string)GetValue(EtiquetaProperty); }
            set { SetValue(EtiquetaProperty, value); }
        }

        public static readonly DependencyProperty ValorProperty =
            DependencyProperty.Register("Valor", typeof(string), typeof(CampoDeTextoDP),
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string Valor
        {
            get { return (string)GetValue(ValorProperty); }
            set { SetValue(ValorProperty, value); }
        }
    }
}
