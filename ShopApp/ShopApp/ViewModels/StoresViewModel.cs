using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using ShopApp.Libraries.Enums;
using ShopApp.Libraries.Helpers.MVVM;
using ShopApp.Models;
using ShopApp.Services;
using Xamarin.Forms;

namespace ShopApp.ViewModels
{
    public class StoresViewModel : BaseViewModel
    {
        public string SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }
        private List<Establishment> _establishments;
        public List<Establishment> Establishments { get; set; }
        private List<Establishment> _allEstablishments;

        //Encapsulamentos
        public List<Establishment> Establishment
        {
            get
            {
                return _establishments;
            }
            set
            {
                SetProperty(ref _establishments, value);
            }
        }

        //Métod
        public StoresViewModel()
        {
            SearchCommand = new Command(Search);
            var allEstablishment = new EstablishmentService().GetEstablishment();
            var allStores = allEstablishment.Where(a=>a.Type == EstablishmentType.Store).ToList();
            Establishments = allStores;
            _allEstablishments = allStores;
        }

        private void Search()
        {
            Establishments = _allEstablishments.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
    }
}
