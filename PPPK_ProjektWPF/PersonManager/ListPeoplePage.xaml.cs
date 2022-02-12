using System.Windows;
using System.Windows.Controls;
using Zadatak.Models;
using Zadatak.ViewModels;

namespace Zadatak
{
    /// <summary>
    /// Interaction logic for ListPersonsPage.xaml
    /// </summary>
    public partial class ListPeoplePage : FramedPage<PersonViewModel>
    {

        public ZanimanjeViewModel ZanimanjeViewModel { get; }

        public ListPeoplePage(PersonViewModel personViewModel, ZanimanjeViewModel zanimanjeViewModel) : base(personViewModel)
        {
            InitializeComponent();
            LvUsers.ItemsSource = personViewModel.People;

            DataContext = personViewModel;
            ZanimanjeViewModel = zanimanjeViewModel;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e) => Frame.Navigate(new EditPersonPage(ViewModel, ZanimanjeViewModel) { Frame = Frame });

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (LvUsers.SelectedItem != null)
            {
                Frame.Navigate(new EditPersonPage(ViewModel, ZanimanjeViewModel, LvUsers.SelectedItem as Person) { Frame = Frame });

            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (LvUsers.SelectedItem != null)
            {
                ViewModel.People.Remove(LvUsers.SelectedItem as Person);
            }
        }

        private void BtnZanimanja_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new ListZanimanjaPage(ZanimanjeViewModel, ViewModel) { Frame = Frame });
        }
    }
}
