using System.Collections.Generic;
using NbCloud.Common.Security.Roles;
using NbCloud.Common.Security.Users;

namespace NbCloud.Common.Security.Sessions
{
    public interface INbSession
    {
        INbUser CurrentUser { get; set; }
        IList<NbRole> CurrentRoles { get; set; }
    }
}
