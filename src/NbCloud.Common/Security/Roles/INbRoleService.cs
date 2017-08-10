using System.Collections.Generic;

namespace NbCloud.Common.Security.Roles
{
    public interface INbRoleService
    {
        IList<INbRole> GetAllRoles();
        IList<INbRole> GetRolesForUser(string userId);
    }
}