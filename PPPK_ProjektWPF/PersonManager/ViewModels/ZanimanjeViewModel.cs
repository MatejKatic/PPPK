using System.Collections.ObjectModel;
using System.Linq;
using Zadatak.Dal;
using Zadatak.Models;


namespace Zadatak.ViewModels
{
    public class ZanimanjeViewModel
    {
        private Zanimanje zanimanjeOsobe;


        public Zanimanje Zanimanje
        {
            get => zanimanjeOsobe;
            set
            {
                zanimanjeOsobe = value ?? popisZanimanja.FirstOrDefault();

            }
        }

        public ObservableCollection<Zanimanje> popisZanimanja { get; }
        public ZanimanjeViewModel()
        {
            popisZanimanja = new ObservableCollection<Zanimanje>(RepositoryFactory.GetRepository<Zanimanje>().GetAll());
            popisZanimanja.CollectionChanged += popisZanimanja_CollectionChanged;

        }

        private void popisZanimanja_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    RepositoryFactory.GetRepository<Zanimanje>().Add(popisZanimanja[e.NewStartingIndex]);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    RepositoryFactory.GetRepository<Zanimanje>().Delete(e.OldItems.OfType<Zanimanje>().ToList()[0]);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    RepositoryFactory.GetRepository<Zanimanje>().Update(e.NewItems.OfType<Zanimanje>().ToList()[0]);
                    break;
            }
        }

        internal void Update(Zanimanje klub) => popisZanimanja[popisZanimanja.IndexOf(klub)] = klub;
    }
}
