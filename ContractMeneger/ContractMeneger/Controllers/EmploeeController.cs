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

        EmployeeService _employeeService;
        EmploeeController(EmployeeService _employeeService) { this._employeeService = _employeeService; }


        [HttpPost("POST/api/emploee/{Rate}")]
        public Employe EmployeCreateController([FromRoute] double Rate) { Employe _employe = new Employe { Rate = Rate }; return _employeeService.EmployeCreate(_employe);  } // метод создания Employe 

        [HttpPost("POST/api/task/{Amount}")]
        public Task TaskCreateController([FromRoute] double Amount) { Task _task = new Task { Amount = Amount }; return _employeeService.TaskCreate(_task); }  // метод создания Task 



        [HttpPost("POST/api/TaskEmployee/employee/{EmployeId}/task/{TaskId}/startdata/{StartData}/enddata/{EndData}")]
        public TaskEmployee TaskEmployeeCreateContriller([FromRoute] int EmployeId, [FromRoute] int TaskId, [FromRoute] DateTimeOffset StartData, [FromRoute] DateTimeOffset EndData) { TaskEmployee _taskEmployee = new TaskEmployee { EmployeId = EmployeId, TaskId = TaskId, StartData = StartData, EndData = EndData }; return _employeeService.TaskEmployeeCreate(_taskEmployee); } //создание TaskEmployee 
                                                                                                                                                                                                                                                                                                 

       
         [HttpPost("POST/api/InvoiceTask/taskId/{TaskId}/invoiceId/{InvoiceId}")]
        public InvocieTask InvocieTaskCreateController([FromRoute]  int TaskId, [FromRoute]  int InvoiceId) { InvocieTask _invocieTask = new InvocieTask { TaskId = TaskId, InvoiceId = InvoiceId }; return _employeeService.InvocieTaskCreate(_invocieTask)   }  //метод создания InvoiceTask   

        [HttpGet("GET/api/Task")]
        public List<Task> TaskReadingController() { return _employeeService.TaskReading(); }  // Метод чтения всех Task




    }
}
