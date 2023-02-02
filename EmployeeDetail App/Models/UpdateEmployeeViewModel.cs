namespace EmployeeDetail_App.Models
{
    public class UpdateEmployeeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; } = string.Empty;

    }
}
