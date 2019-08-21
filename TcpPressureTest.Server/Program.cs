using System;
using BeetleX;
using BeetleX.EventArgs;

namespace TcpPressureTest.Server
{
    class Program : ServerHandlerBase
    {
        private static IServer server;
        private static int left;
        private static int top;
        private static object obj=new object();
        public static void Main(string[] args)
        {
            server = SocketFactory.CreateTcpServer<Program>();
            server.Options.DefaultListen.Port = 8888;
            //server.Options.BufferPoolSize = 20000;
            server.Open();
            left = Console.CursorLeft;
            top = Console.CursorTop;
            Console.Write(server);
            Console.Read();
        }

        public void SetPoint()
        {
            lock (obj)
            {
                Console.SetCursorPosition(left, top);
                Console.Write(server);
            }
        }

        public override void Connected(IServer server, ConnectedEventArgs e)
        {
            SetPoint();
            base.Connected(server, e);
        }

        public override void Disconnect(IServer server, SessionEventArgs e)
        {
            SetPoint();
            base.Disconnect(server, e);
        }

        public override void Error(IServer server, ServerErrorEventArgs e)
        {
            base.Error(server, e);
        }

        public override void SessionReceive(IServer server, SessionReceiveEventArgs e)
        {
            try
            {
                string data = e.Stream.ToPipeStream().ReadToEnd();
                e.Session.Stream.ToPipeStream().WriteLine(data);
                e.Session.Stream.Flush();
                SetPoint();
                base.SessionReceive(server, e);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
        }
    }
}
