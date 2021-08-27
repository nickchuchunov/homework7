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
        public void EmployeCreateController([FromRoute] float Rate) { EmployeDatabase _employe = new EmployeDatabase { Rate = Rate }; _employeeService.EmployeCreate(_employe);  } // метод создания Employe 

        [HttpPost("POST/api/task/{Amount}")]
        public void TaskCreateController([FromRoute] float Amount) {TaskDatabase _task = new TaskDatabase { Amount = Amount };  _employeeService.TaskCreate(_task); }  // метод создания Task 



        [HttpPost("POST/api/TaskEmployee/employee/{EmployeId}/task/{TaskId}/startdata/{StartData}/enddata/{EndData}")]
        public void TaskEmployeeCreateContriller([FromRoute] int EmployeId, [FromRoute] int TaskId, [FromRoute] DateTime StartData, [FromRoute] DateTime EndData) { TaskEmployeeDatabase _taskEmployee = new TaskEmployeeDatabase { EmployeId = EmployeId, TaskId = TaskId, StartData = StartData, EndData = EndData };  _employeeService.TaskEmployeeCreate(_taskEmployee); } //создание TaskEmployee 
                                                                                                                                                                                                                                                                                                 

       
         [HttpPost("POST/api/InvoiceTask/taskId/{TaskId}/invoiceId/{InvoiceId}")]
        public void InvocieTaskCreateController([FromRoute]  int TaskId, [FromRoute]  int InvoiceId) { InvoiceTaskDatabase _invocieTask = new InvoiceTaskDatabase { TaskId = TaskId, InvoiceId = InvoiceId };  _employeeService.InvocieTaskCreate(_invocieTask);   }  //метод создания InvoiceTask   

        [HttpGet("GET/api/Task")]
        public List<TaskDatabase> TaskReadingController() { return _employeeService.TaskReading(); }  // Метод чтения всех Task




    }
}
