using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models;
using VendasWebMvc.Serviços;


namespace VendasWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly ServiçoVendedor _serviçoVendedor;
        
        public VendedoresController(ServiçoVendedor serviçoVendedor)
        {
            _serviçoVendedor = serviçoVendedor;
        }
        public IActionResult Index()
        {
            var list = _serviçoVendedor.FindAll();
            return View(list);
        }
        
          public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _serviçoVendedor.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
