using LeaveManagmentWeb.Data;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagmentWeb.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM>  LeaveAllocations { get; set; }
    }
}
