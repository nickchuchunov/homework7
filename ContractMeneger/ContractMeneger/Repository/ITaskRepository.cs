using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
   public interface ITaskRepository
    {


        public void InvocieTaskCreate(InvoiceTaskDatabase _invocieTask);  //метод создания InvoiceTask   



        public List<TaskDatabase> TaskReading();  // Метод чтения всех Task 




        public void TaskCreate(TaskDatabase _task);  // метод создания Task 



    }
}
