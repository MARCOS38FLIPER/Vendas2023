using System.Collections.Generic;


namespace VendasWebMvc.Models.ViewModels
{
    public class VendedorFormVIewModel
    {
        public Vendedor vendedor { get; set; }
        public ICollection<Departamento> Departamentos{ get; set; }
    }
}
