using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpAssignments
{
    public class EmployeeManagementApplication
    {

        public static void main()
        {
           Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            emp1.setEmpDetails(1, "tulasi", 5000);
            emp1.setEmpDetails(2, "rahul", 50000);
            emp1.setEmpDetails(3, "virat", 58000);

            ArrayList myList = new ArrayList();
            myList.Add(emp1);
            myList.Add(emp2);
            myList.Add(emp3);
            Console.WriteLine("displaying employee details from employee arraylist /n");
            foreach (Employee employee in myList)
            {
                Console.WriteLine($"salary :{employee._salary}");
            }
        }
    }
}
