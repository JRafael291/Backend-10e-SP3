using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHpet.Models;

namespace LHpet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.050-41", "arthur.antunes@ro.senai.br", "Ozzy");
        Cliente cliente2 = new Cliente(02, "Maria A. Lopes", "931.032.051-41", "maria.lopes@ro.senai.br", "Bob");
        Cliente cliente3 = new Cliente(03, "Sandra Moreira", "457.032.050-41", "sandra.moreira@ro.senai.br", "Liza");
        Cliente cliente4 = new Cliente(04, "Lis Souza", "757.032.050-41", "lis.souza@ro.senai.br", "Bill");
        Cliente cliente5 = new Cliente(05, "Rosa Silva", "657.032.050-41", "rosa.silva@ro.senai.br", "Madruga");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "C# Pet", "14.182.102/0001-80", "csharp@gmai.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Virgula Pet", "15.182.102/0001-80", "virgulapet@gmai.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Ponto Pet", "13.182.102/0001-80", "pontopet@gmai.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Bit Pet", "12.182.102/0001-80", "bitpet@gmai.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Log Pet", "11.182.102/0001-80", "logpet@gmai.com");                     

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add (fornecedor1);
        listaFornecedores.Add (fornecedor2);
        listaFornecedores.Add (fornecedor3);
        listaFornecedores.Add (fornecedor4);
        listaFornecedores.Add (fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;        


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
