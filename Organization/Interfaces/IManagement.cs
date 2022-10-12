using Organization.Base;
using Organization.Utilities;

namespace Organization.Interfaces
{
    public interface IManagement
    {
        public Approval ApproveEmployee(Person person);
    }
}
