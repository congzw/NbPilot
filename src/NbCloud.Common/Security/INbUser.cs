using System;

namespace NbCloud.Common.Security
{
    public interface INbUser
    {
        Guid UserId { get; set; }
        string LoginName { get; set; }
    }
}
