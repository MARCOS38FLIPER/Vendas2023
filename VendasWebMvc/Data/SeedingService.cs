using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models;
using VendasWebMvc.Models.Enums;


namespace VendasWebMvc.Data
{
    public class SeedingService
    {
        private VendasWebMvcContext _context;

        public SeedingService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departamento.Any() || 
                _context.Vendedor.Any() ||
                _context.RecordeDeVendas.Any())
            {
                return; // O Banco de Dados já foi Populado
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Celulares");
            Departamento d3 = new Departamento(3, "Placa Mãe");
            Departamento d4 = new Departamento(4, "Hds");

            Vendedor s1 = new Vendedor(1, "Marcos Soares", "mar-kym@hotmail.com", new DateTime(1982, 6, 11), 1800.0, d1);

            RecordeDeVendas r1 = new RecordeDeVendas(1, new DateTime(2018, 09, 25), 11000.0, StatusDeVendas.faturada, s1);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(s1);

            _context.RecordeDeVendas.AddRange(r1);

             _context.SaveChanges();
        }

    }
}
