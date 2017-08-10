using System.Collections.Generic;
using NbCloud.Common.Security.Roles;
using NbCloud.Common.Security.Users;

namespace NbCloud.Common.Security.Sessions
{
    public class NbSession : INbSession
    {
        public NbSession()
        {
            CurrentUser = NbUser.Empty;
            CurrentRoles = new List<NbRole>();
        }

        public INbUser CurrentUser { get; set; }
        public IList<NbRole> CurrentRoles { get; set; }
        
        #region helpers

        public bool IsLogin()
        {
            //return this == Empty;
            return string.IsNullOrWhiteSpace(this.CurrentUser.LoginName);
        }

        private static INbSession _empty = new NbSession() { CurrentUser = NbUser.Empty, CurrentRoles = new List<NbRole>()};
        public static INbSession Empty
        {
            get { return _empty; }
            set { _empty = value; }
        }

        #endregion
    }
}