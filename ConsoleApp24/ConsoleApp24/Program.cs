using ConsoleApp24;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{

    internal class Program
    {

        [ComVisible(true)]
        [Guid("748E442C-6820-4935-A3B1-586830B42723")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public interface INET6COMServer
        {
            int int_add(int a, int b);
            string str_add(string a, string b);
        }

        [ComImport]
        [CoClass(typeof(NET6COMServer))]
        [Guid("748E442C-6820-4935-A3B1-586830B42723")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        internal interface IClientNET6COMServer : INET6COMServer
        {
        }

        [ComImport]
        [Guid("2956C8A3-6A98-421B-9484-AF2C16B01261")]
        internal class NET6COMServer
        {
        }


        static void Main(string[] args)
        {
            // COMオブジェクトのGUIDを指定
            IClientNET6COMServer server = (IClientNET6COMServer)new NET6COMServer();
            var add = server.int_add(1, 2);
            Console.WriteLine(add);


        }
    }
}
