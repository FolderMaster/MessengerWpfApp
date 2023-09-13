using Model.Messenger.Contacts;

namespace Model.Messenger.Authentications
{
    public interface IAuthentication
    {
        public IContact Contact { get; set; }
    }
}