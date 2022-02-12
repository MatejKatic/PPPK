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
    /// Interaction logic for ListZanimanjaPage.xaml
    /// </summary>
    public partial class ListZanimanjaPage : FramedPage<ZanimanjeViewModel>
    {
        public PersonViewModel PersonViewModel { get; }
        public ListZanimanjaPage(ZanimanjeViewModel zanimanjeViewModel, PersonViewModel personViewModel) : base(zanimanjeViewModel)
        {
            InitializeComponent();
            LvZanimanja.ItemsSource = zanimanjeViewModel.popisZanimanja;
            PersonViewModel = personViewModel;
        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new EditZanimanjePage(ViewModel) { Frame = Frame });
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (LvZanimanja.SelectedItem != null)
            {
                Frame.Navigate(new EditZanimanjePage(ViewModel, LvZanimanja.SelectedItem as Zanimanje) { Frame = Frame });
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (LvZanimanja.SelectedItem != null)
            {
                PersonViewModel.People.Where(p => p.zanimanjeOsobe.IDZanimanje == (LvZanimanja.SelectedItem as Zanimanje).IDZanimanje).ToList().ForEach(o => PersonViewModel.People.Remove(o));
                ViewModel.popisZanimanja.Remove(LvZanimanja.SelectedItem as Zanimanje);
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e) => Frame.Navigate(new ListPeoplePage(PersonViewModel, ViewModel) { Frame = Frame });
    }
}
