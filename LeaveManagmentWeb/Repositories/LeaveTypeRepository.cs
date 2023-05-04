using LeaveManagmentWeb.Contracts;
using LeaveManagmentWeb.Data;

namespace LeaveManagmentWeb.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
