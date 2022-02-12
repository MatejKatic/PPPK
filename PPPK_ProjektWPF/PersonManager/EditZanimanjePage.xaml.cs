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
using Zadatak.Models;
using Zadatak.ViewModels;

namespace Zadatak
{
    /// <summary>
    /// Interaction logic for EditZanimanjePage.xaml
    /// </summary>
    public partial class EditZanimanjePage : FramedPage<ZanimanjeViewModel>
    {

        private readonly Zanimanje Zanimanje;
        public EditZanimanjePage(ZanimanjeViewModel ZanimanjeViewModel, Zanimanje Zanimanje = null) : base(ZanimanjeViewModel)
        {
            InitializeComponent();
            this.Zanimanje = Zanimanje ?? new Zanimanje();
            DataContext = Zanimanje;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e) => Frame.NavigationService.GoBack();

        private void BtnCommit_Click(object sender, RoutedEventArgs e)
        {
            if (FormValid())
            {

                Zanimanje.Naziv = TbName.Text.Trim();

                if (Zanimanje.IDZanimanje == 0)
                {
                    ViewModel.popisZanimanja.Add(Zanimanje);
                }
                else
                {
                    ViewModel.Update(Zanimanje);
                }
                Frame.NavigationService.GoBack();
            }
        }

        private bool FormValid()
        {
            bool valid = true;
            GridContainter.Children.OfType<TextBox>().ToList().ForEach(e =>
            {
                if (string.IsNullOrEmpty(e.Text.Trim()))
                {
                    e.Background = Brushes.LightCoral;
                    valid = false;
                }
                else
                {
                    e.Background = Brushes.White;
                }
            });

            return valid;
        }
    }
}
