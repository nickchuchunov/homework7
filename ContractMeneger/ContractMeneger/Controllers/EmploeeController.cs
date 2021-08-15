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
    [Route("api/EmploeeController/")]
    public class EmploeeController : Controller // Не все реализованы методы CRUD - Update и Delete будут реализованы в соответсвии с потребностями приложения
    {



        [HttpPost("POST/api/emploee/{Rate}")]
        public Employe EmployeCreate([FromRoute] double Rate) { return new Employe { Rate = Rate }; } // метод создания Employe

        [HttpPost("POST/api/task/{Amount}")]
        public Task TaskCreate([FromRoute] double Amount) { return new Task { Amount = Amount }; }  // метод создания Task



        [HttpPost("POST/api/TaskEmployee/employee/{EmployeId}/task/{TaskId}/startdata/{StartData}/enddata/{EndData}")]
        public TaskEmployee TaskEmployeeCreate([FromRoute] int EmployeId, [FromRoute] int TaskId, [FromRoute] DateTimeOffset StartData, [FromRoute] DateTimeOffset EndData) { return new TaskEmployee { EmployeId = EmployeId, TaskId = TaskId, StartData = StartData, EndData = EndData }; } //создание TaskEmployee
                                                                                                                                                                                                                                                                                                  //

       
         [HttpPost("POST/api/InvoiceTask/taskId/{TaskId}/invoiceId/{InvoiceId}")]
        public InvocieTask InvocieTaskCreate([FromRoute]  int TaskId, [FromRoute]  int InvoiceId) { return new InvocieTask { TaskId = TaskId, InvoiceId = InvoiceId }; }  //метод создания InvoiceTask   

        [HttpGet("GET/api/Task")]
        public List<Task> TaskReading() { return new List<Task>(); }  // Метод чтения всех Task




    }
}
