using System.ComponentModel.DataAnnotations;

namespace LeaveManagmentWeb.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name ="Number Of Days")]
        [Required]
        [Range(1, 5, ErrorMessage = "Invalid number entered.")]
        public int NumberOfDays  { get; set; }
        [Display(Name = "Allocation period")]
        [Required]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}