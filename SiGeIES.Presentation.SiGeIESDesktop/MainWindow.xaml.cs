using SiGeIES.Aplication.Mapper;
using SiGeIES.Aplication.Services;
using SiGeIES.Domain.Common;
using SiGeIES.Domain.Contracts;
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

namespace SiGeIES.Presentation.SiGeIESDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IInasistenciaService _repository;
        

        public MainWindow(IInasistenciaService repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            
            try
            {

                var lista = _repository.TodasInasistencia();

                gridInasistencias.ItemsSource = InasistenciaMapper.ToDto(lista);
                
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message);
                
            }

            
        }
    }
}
