namespace NbCloud.Common.Security.Users
{
    public interface INbUser
    {
        string UserId { get; set; }
        string LoginName { get; set; }
    }
}
