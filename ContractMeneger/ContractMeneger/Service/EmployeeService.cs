using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class EmployeeService : ITaskRepository, IEmployeeRepository
    {
        ContractMenegerDatabaseContext _contractMenegerDatabaseContext;
       public  EmployeeService(ContractMenegerDatabaseContext _contractMenegerDatabaseContext) { this._contractMenegerDatabaseContext = _contractMenegerDatabaseContext; }



        public void EmployeCreate(EmployeDatabase _employe) // метод создания Employe
        {
            _contractMenegerDatabaseContext.EmployeDatabases.Add(_employe);
            _contractMenegerDatabaseContext.SaveChanges();
        }

        public void InvocieTaskCreate(InvoiceTaskDatabase _invocieTask) //метод создания InvoiceTask   
        {
            _contractMenegerDatabaseContext.InvoiceTaskDatabases.Add(_invocieTask);
            _contractMenegerDatabaseContext.SaveChanges();
        }

        public void TaskCreate(TaskDatabase _task) // метод создания Task 
        {
            _contractMenegerDatabaseContext.TaskDatabases.Add(_task);
            _contractMenegerDatabaseContext.SaveChanges();
        }

        public void TaskEmployeeCreate(TaskEmployeeDatabase _taskEmployee) //создание TaskEmployee
        {
            _contractMenegerDatabaseContext.TaskEmployeeDatabases.Add(_taskEmployee);
            _contractMenegerDatabaseContext.SaveChanges();
        }

        public List<TaskDatabase> TaskReading() // Метод чтения всех Task 
        {
          return  _contractMenegerDatabaseContext.TaskDatabases.ToList<TaskDatabase>();
        }
    }
}
