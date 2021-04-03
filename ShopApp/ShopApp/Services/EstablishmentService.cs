using System;
using System.Collections.Generic;
using ShopApp.Libraries.Enums;
using ShopApp.Models;

namespace ShopApp.Services
{
    public class EstablishmentService
    {
        public List<Establishment> GetEstablishment()
        {
            var establishments = new List<Establishment>()
            {
                new Establishment()
                {
                    Id = 1,
                    Type = EstablishmentType.Store,
                    Name = "Renner",
                    Logo = "",
                    Description = "A Lojas Rener S.A. é uma rede de lojas de departamento brasileira.",
                    Address = "3 Andar - Loja 10 - Setor Norte",
                    Phone = "(61) 3333-3333",
                }
            };
            return establishments;
        }
    }
}
