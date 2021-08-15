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

        [HttpPost("POST/api/contract/{id}/invoice")]
        public Invoice InvoiceCreateOfIdContract([FromRoute] int Id) { return new Invoice { ContactId = Id }; } //метод создания Invoice с Id Contract



        [HttpGet("GET/api/contract/{id}/invoice")]
        public List<Invoice> InvoiceReadingOfIdContract([FromRoute] int Id) { return new List<Invoice>(); } //метод чтения invoice по id contracta

       
       


    }
}
