using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractMeneger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace ContractMeneger.Controllers
{
    [Route("api/InvoiceController/")]
    public class InvoiceController : Controller // Не все реализованы методы CRUD - Update и Delete будут реализованы в соответсвии с потребностями приложения
    {

        InvoiceService _invoiceService;
        InvoiceController(InvoiceService _invoiceService) { this._invoiceService = _invoiceService; }

        [HttpPost("POST/api/contract/{id}/invoice")]
        public Invoice InvoiceCreateOfIdContract([FromRoute] int Id) { return _invoiceService.InvoiceCreateOfIdContract(Id);      } //метод создания Invoice с Id Contract



        [HttpGet("GET/api/contract/{id}/invoice")]
        public List<Invoice> InvoiceReadingOfIdContract([FromRoute] int Id) { return _invoiceService.InvoiceReadingOfIdContract(Id); } //метод чтения invoice по id contracta

       
       


    }
}
