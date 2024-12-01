namespace HRApplication.Models
{
    public class Repository
    {
     private static List<Employees> employeeslist = new List<Employees>();
       
     public static IEnumerable<Employees> getEmployees()
        {
            return employeeslist;
        }
        public static void AddEmployees(Employees emp)
        {
            employeeslist.Add(emp);
        }
        
    }
    
}
