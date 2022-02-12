using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Zadatak.Models;
using Zadatak.Utils;
using Zadatak.ViewModels;

namespace Zadatak
{
    /// <summary>
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPersonPage : FramedPage<PersonViewModel>
    {
        private const string Filter = "All supported graphics|*.jpg;*.jpeg;*.png|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|Portable Network Graphic (*.png)|*.png";
        private readonly ZanimanjeViewModel zanimanjeViewModel;
        private readonly Person person;
        public EditPersonPage(PersonViewModel personViewModel, ZanimanjeViewModel zanimanjeViewModel, Person person = null) : base(personViewModel)
        {
            InitializeComponent();

            this.zanimanjeViewModel = zanimanjeViewModel;
            this.person = person ?? new Person();
            this.person.zanimanjeOsobe = this.person.zanimanjeOsobe ?? new Zanimanje();

            this.zanimanjeViewModel.Zanimanje = this.zanimanjeViewModel.popisZanimanja.FirstOrDefault(k => k.IDZanimanje == this.person.zanimanjeOsobe.IDZanimanje);

            DataContext = new
            {
                person = this.person,
                zanimanja = zanimanjeViewModel
            };

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e) => Frame.Navigate(new ListPeoplePage(ViewModel, zanimanjeViewModel) { Frame = Frame });


        private void BtnCommit_Click(object sender, RoutedEventArgs e)
        {
            if (FormValid())
            {
                person.Age = int.Parse(TbAge.Text.Trim());
                person.Email = TbEmail.Text.Trim();
                person.FirstName = TbFirstName.Text.Trim();
                person.LastName = TbLastName.Text.Trim();
                person.Picture = ImageUtils.BitmapImageToByteArray(Picture.Source as BitmapImage);

                person.zanimanjeOsobe = cbKlub.SelectedItem as Zanimanje;

                if (person.IDPerson == 0)
                {
                    ViewModel.People.Add(person);

                }
                else
                {
                    ViewModel.Update(person);
                }

                Frame.Navigate(new ListPeoplePage(ViewModel, zanimanjeViewModel) { Frame = Frame });
            }
        }



        private bool FormValid()
        {
            bool valid = true;
            GridContainter.Children.OfType<TextBox>().ToList().ForEach(e =>
            {
                if (string.IsNullOrEmpty(e.Text.Trim())
                    || ("Int".Equals(e.Tag) && !int.TryParse(e.Text, out int age))
                    || ("Email".Equals(e.Tag) && !ValidationUtils.isValidEmail(TbEmail.Text.Trim())))
                {
                    e.Background = Brushes.LightCoral;
                    valid = false;
                }
                else
                {
                    e.Background = Brushes.White;
                }
            });
            if (Picture.Source == null)
            {
                PictureBorder.BorderBrush = Brushes.LightCoral;
                valid = false;
            }
            else
            {
                PictureBorder.BorderBrush = Brushes.WhiteSmoke;
            }
            return valid;
        }

        private void BtnUpload_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = Filter
            };
            if (openFileDialog.ShowDialog() == true)
            {
                Picture.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
            person.Picture = ImageUtils.BitmapImageToByteArray(Picture.Source as BitmapImage);
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            if (zanimanjeViewModel.popisZanimanja.Count == 0)
            {
                MessageBox.Show("Svaka osoba mora imati zanimanje!");
                Frame.Navigate(new ListZanimanjaPage(zanimanjeViewModel, ViewModel) { Frame = Frame });


            }
        }
    }
}
