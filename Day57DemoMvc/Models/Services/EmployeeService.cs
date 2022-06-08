namespace Day57DemoMvc.Models.Services;

public class EmployeeService
{
    readonly List<EmployeeModel> _employees = new()
    {
        new EmployeeModel
        {
            Id = 1,
            FirstName = "Akshay",
            LastName = "Kumar",
            DateOfBirth = new DateTime(1972, 4, 25),
            Pan = "ABCDE0000M",
            Address = "NULL",
            Gender = 'M',
            MobileNumber = "NULL",
            Email = "NULL",
            Comment = "NULL",
            DepartmentRefId = 3
        },
        new EmployeeModel
        {
            Id = 3,
            FirstName = "Raveena",
            LastName = "Tandon",
            DateOfBirth = new DateTime(1975, 10, 2),
            Pan = "UVWXY1234O",
            Address = "NULL",
            Gender = 'F',
            MobileNumber = "NULL",
            Email = "NULL",
            Comment = "NULL",
            DepartmentRefId = 2
        }
    };
    
    public List<EmployeeModel> GetAll()
    {
        return _employees;
    }

    public EmployeeModel GetById(int id)
    {
        // Single               - Only if 1 record found, else exception
        // SingleOrDefault      - Only if 1 record found or null, else exception
        // First                - Only if 1 or more record found, else exception (returns the 1st from the found items)
        // FirstOrDefault       - Only if 1 or more record found or null (returns the 1st from the found items)

        var employee = _employees.Single(e => e.Id == id);
        return employee;
    }
}