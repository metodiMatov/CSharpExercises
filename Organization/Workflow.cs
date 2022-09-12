using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organization;
namespace Organization;

public class Workflow
{
    public void SetWorkflow()
    {
        var organization = new Organization("Webspector", "QA company that ensure your Web project is in tune", new ChiefExecutive(), new Department("Development Department", new DepartmentManager()), new Department("HumanResourcesDepartment", new DepartmentManager()));
        organization.CreateEmloyees();
    }
}
