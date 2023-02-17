using VendasWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Data;

namespace VendasWebMvc.Serviços
{
    public class ServiçoVendedor
    {
        private readonly VendasWebMvcContext _context;
       

        public ServiçoVendedor(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
     }
}
