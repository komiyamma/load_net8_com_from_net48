using System.Runtime.InteropServices;

namespace ClassLibrary12
{
    [ComVisible(true)]
    [Guid("941B0C20-BF28-4A46-860E-80F8AD85C6A3")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface INET8COMServer
    {
        public string str_add(string a, string b);

        public int int_add(int a, int b);
    }


    [ComVisible(true)]
    [Guid("3880F33D-0FE2-4C18-BD54-2CA063C0984B")]
    public class NET8COMServer : INET8COMServer
    {
        public string str_add(string a, string b)
        {
            return a + b;
        }

        public int int_add(int a, int b)
        {
            return a + b;
        }
    }
}
