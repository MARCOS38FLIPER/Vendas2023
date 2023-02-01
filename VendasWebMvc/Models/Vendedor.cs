using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RecordeDeVendas> Vendas { get; set; } = new List<RecordeDeVendas>();
        
        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataAniversario, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(RecordeDeVendas rc)
        {
            Vendas.Add(rc);
        }

        public void RemoveVendas(RecordeDeVendas rc)
        {
            Vendas.Remove(rc);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(rc => rc.Data >= inicial && rc.Data <= final).Sum(rc => rc.Amount);
        }
    }
}
