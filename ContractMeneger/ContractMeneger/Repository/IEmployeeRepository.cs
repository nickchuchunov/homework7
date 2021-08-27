using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public interface IEmployeeRepository 
    {


        public void EmployeCreate(EmployeDatabase _employe); // метод создания Employe


        public void TaskEmployeeCreate(TaskEmployeeDatabase _taskEmployee); //создание TaskEmployee
                                                                                                                                                                                                                                                                                              //



    }
}
