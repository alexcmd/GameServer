using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace GameServer.Web.Hub
{
    public class MyHub1 : Hub<IClientApi>
    {
        public override Task OnConnected()
        {
            Debug.WriteLine(this.Context.ConnectionId);
            return base.OnConnected();
        }

        public void Hello()
        {
            Clients.All.Hello();
        }

        public void Send(string name, string text)
        {
            Clients.All.Send("13123123123","123123123123123123123");
            
        }
    }
}