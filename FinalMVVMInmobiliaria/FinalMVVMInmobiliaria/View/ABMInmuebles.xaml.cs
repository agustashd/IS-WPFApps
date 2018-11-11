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
using FinalMVVMInmobiliaria.ViewModel;

namespace FinalMVVMInmobiliaria.View
{
    /// <summary>
    /// Interaction logic for ABMInmuebles.xaml
    /// </summary>
    public partial class ABMInmuebles : Window
    {
        public ABMInmuebles()
        {
            //DataContext = new InmueblesViewModel();
            InitializeComponent();
        }
    }
}
