using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace simpleapp
{
    internal class RFIDReaderInterop
    {
        // Define the delegate for the callback function
        public delegate void GetInterfaceReturnDataDelegate(int fd, int canId, byte cmd, int errCode, int len, IntPtr responseData);

        // Import the DLL and its functions
        private const string DLLPath = @"F:\office\csharp\simpleapp\simpleapp\r101l_api.dll";

        [DllImport(DLLPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void sdk_init(int mode, GetInterfaceReturnDataDelegate callback);

        [DllImport(DLLPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int openNetPort(string targetIP, int targetPort, int[] canId, int canNum);

        [DllImport(DLLPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int closeNetPort(int fd);

        [DllImport("r101l_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int getReaderVersion(int fd, int address);

        [DllImport("r101l_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int setCanId(int fd, int canID, int address);

        [DllImport("r101l_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int setCanBaudRate(int fd, int baudRate, int address);

        [DllImport("r101l_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int getCanId(int fd, int address);

        [DllImport("r101l_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int getCanBaudRate(int fd, int address);

        [DllImport("r101l_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int inventoryOnce(int fd, int address);

        [DllImport("r101l_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int inventoryStart(int fd, int address);

        [DllImport("r101l_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int readTagData(int fd, int epclen, string epc, string password, int bank, int offset, int len, int address);
        /*
        internal static int readTagData(int fd, int v1, byte[] epc, string v2, int v3, int v4, int v5, double v6, double v7, double v8)
        {
            throw new NotImplementedException();
        }*/
    }
}


/*
 
 
 public class RFIDReaderManager
{
    private string configFile = "F:/office/csharp/simpleapp/simpleapp/config.ini"; // Replace with your actual INI file path
    private RFIDReaderInterop rfidReader;

    public RFIDReaderManager()
    {
        rfidReader = new RFIDReaderInterop();
    }

    public string ReadRFIDTag()
    {
        // Use RFIDReaderInterop to read RFID tags
        // Replace the following line with your actual RFID reading logic
        string tagData = rfidReader.ReadRFIDTag();

        // Read configuration settings based on the tag data
        string section = "YourSection"; // Replace with your actual INI section
        string key = "YourKey"; // Replace with your actual INI key
        string configValue = ReadString(section, key);

        // Do something with the RFID tag data and configuration value
        string result = $"Tag Data: {tagData}, Config Value: {configValue}";

        return result;
    }

    public string ReadString(string section, string key)
    {
        // Your existing code for reading from the INI file
        // ...

        // For example, you might use it like this:
        // string configValue = ReadString("YourSection", "YourKey");

        return string.Empty; // Placeholder, replace with the actual value
    }
}
 
 
 
 
 
 */