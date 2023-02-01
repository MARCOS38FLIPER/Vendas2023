using VendasWebMvc.Models.Enums;
using System;

namespace VendasWebMvc.Models
{
    public class RecordeDeVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public StatusDeVendas Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public double Amount { get; internal set; }

        public RecordeDeVendas()
        {
        }

        public RecordeDeVendas(int id, DateTime data, double valor, StatusDeVendas status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
