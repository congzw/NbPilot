using System;

namespace NbCloud.Common.Security
{
    public interface INbUser
    {
        string UserId { get; set; }
        string LoginName { get; set; }
    }
}
