using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DisappearingWindow
{
  /// <summary>
  /// Interaction logic for ConfigPage.xaml
  /// </summary>
  public partial class ConfigPage : Page, INotifyPropertyChanged
  {
    public ConfigPage()
    {
      
      InitializeComponent();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private async void AddConnectorClick(object sender, RoutedEventArgs e)
    {

      var dialog = new DialogPopup();

      var result = (bool)await DialogHost.Show(dialog, "ConfigPageDialogHost");
      if(result)
      {
        return;
      }
      else
      {
        return;
      }
    }

    private void PageInitialized(object sender, EventArgs e)
    {

    }


  }
}
