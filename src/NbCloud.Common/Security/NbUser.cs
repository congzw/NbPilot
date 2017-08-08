﻿using System;

namespace NbCloud.Common.Security
{
    public class NbUser : INbUser
    {
        public Guid UserId { get; set; }
        public string LoginName { get; set; }

        #region helpers

        public bool IsLogin()
        {
            //return this == Empty;
            return string.IsNullOrWhiteSpace(this.LoginName);
        }

        private static INbUser _empty = new NbUser() { LoginName = string.Empty, UserId = Guid.Empty };
        public static INbUser Empty
        {
            get { return _empty; }
            set { _empty = value; }
        }

        #endregion
    }
}