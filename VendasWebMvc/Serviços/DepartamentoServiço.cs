using VendasWebMvc.Models;
using System.Linq;
using VendasWebMvc.Data;
using System.Collections.Generic;

namespace VendasWebMvc.Serviços
{
    public class DepartamentoServiço
    {

        private readonly VendasWebMvcContext _context;


        public DepartamentoServiço(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Name).ToList();
        }
    }
}
