using System;

namespace NbCloud.BaseLib
{
    public interface IAppService
    {
        
    }

    public class NbEntity<T>
    {
        public virtual Guid Id { get; set; }
    }

    public class MessageResult
    {
    }
}
