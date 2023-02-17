using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models.ViewModels;
using VendasWebMvc.Models;
using VendasWebMvc.Serviços;


namespace VendasWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly ServiçoVendedor _serviçoVendedor;
        private readonly DepartamentoServiço _departamentoServiço;

        public VendedoresController(ServiçoVendedor serviçoVendedor, DepartamentoServiço departamentoServiço)
        {
            _serviçoVendedor = serviçoVendedor;
            _departamentoServiço = departamentoServiço;
        }
        public IActionResult Index()
        {
            var list = _serviçoVendedor.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departamentos = _departamentoServiço.FindAll();
            var viewModel = new VendedorFormVIewModel { Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _serviçoVendedor.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _serviçoVendedor.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _serviçoVendedor.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int?id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _serviçoVendedor.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        }
    }


