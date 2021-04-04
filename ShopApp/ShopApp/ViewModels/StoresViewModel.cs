using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using ShopApp.Libraries.Enums;
using ShopApp.Models;
using ShopApp.Services;
using Xamarin.Forms;

namespace ShopApp.ViewModels
{
    public class StoresViewModel
    {
        public string SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }
        public List<Establishment> Establishments { get; set; }

        public StoresViewModel()
        {
            SearchCommand = new Command(Search);
            var allEstablishment = new EstablishmentService().GetEstablishment();
            var allStores = allEstablishment.Where(a=>a.Type == EstablishmentType.Store).ToList();
            Establishments = allStores;
        }

        private void Search()
        {

        }
    }
}
