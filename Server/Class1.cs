using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Configuration;
using System.IO;

namespace Server
{
    public class Server
    {
        private TcpListener _listener;
        private UInt16 _portnumber;
        private IPAddress _ip;
        
    }

    public class Connection
    {
        private Socket _connection;
        private Stream _data;
        private StreamReader _reader;
        private StreamWriter _writer;
        

        public Connection(ref Socket s)
        {

        }
        
    }
}
