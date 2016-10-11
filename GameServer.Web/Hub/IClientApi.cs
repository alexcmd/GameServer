namespace GameServer.Web.Hub
{
    public interface IClientApi
    {
        void Hello();
        void Send(string name, string text);
    }
}