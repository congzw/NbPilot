using System.Collections.Generic;

namespace NbCloud.Common.Security.Permissions {
    public interface IPermissionProvider : IDependency {
        //Feature Feature { get; }
        IEnumerable<Permission> GetPermissions();
        IEnumerable<PermissionStereotype> GetDefaultStereotypes();
    }

    public class PermissionStereotype {
        public string Name { get; set; }
        public IEnumerable<Permission> Permissions { get; set; }
    }
}