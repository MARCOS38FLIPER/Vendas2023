using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMvc.Models.Enums
{
    public enum StatusDeVendas : int
    {
        pedente = 0,
        faturada = 1,
        cancelada = 2,
    }
}
