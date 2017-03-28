using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RakNet;
namespace RakNetServer
{
    public enum RPCErrorCodes
    {
        RPC_ERROR_FUNCTION_NOT_REGISTERED,
    }
  public   class RPC
    {
        RakPeerInterface peer;
        struct LocalCallback
        {
            string messageId;
            Dictionary<RakString, RakString> functions;
        };
        public RPC(RakPeerInterface peer)
        {
            this.peer = peer;
            peer.AllowConnectionResponseIPMigration(false);
        }
    }
}
