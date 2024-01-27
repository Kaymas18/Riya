using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace simpleapp
{
    public partial class Form2 : Form
    {
        private static byte READ_TAG_CMD = 0x85;
        private static byte GET_VERSION_CMD = 0x01;

        private TcpClient tcpClient;
        private NetworkStream stream;

        public Form2()
        {
            InitializeComponent();
            RFIDReaderInterop.sdk_init(0, GetInterfaceReturnDataCallback);

            try
            {
                tcpClient = new TcpClient("192.168.131.220", 8088);
                stream = tcpClient.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to RFID reader: {ex.Message}");
            }
        }

        //write button   

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world1! Write please!!!!!!!!!!");
        }



        private async void btnread_Click(object sender, EventArgs e)
        {
            if (tcpClient != null && tcpClient.Connected)
            {
                int fd = RFIDReaderInterop.openNetPort("192.168.131.220", 8088, new[] { 0 }, 1);
                try
                {
                    //int fd = RFIDReaderInterop.openNetPort("192.168.131.220", 8088, new[] { 0 }, 1);

                    if (fd != -1)
                    {
                        int version = RFIDReaderInterop.getReaderVersion(fd, 0);

                        if (version < 0)
                        {
                            MessageBox.Show("Error getting reader version.");
                        }
                        else
                        {
                            MessageBox.Show($"Reader Version: {version}");
                            MessageBox.Show("You'll se reader version");
                        }

                        int inventoryResult = RFIDReaderInterop.inventoryOnce(fd, 0);

                        if (inventoryResult == 0)
                        {
                            MessageBox.Show("Inventory operation successful.");
                            // Process detected tags, read data, etc.

                        }
                        else
                        {
                            Console.WriteLine("Inventory operation failed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to connect to the RFID reader.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing RFID reader: {ex.Message}");
                }
                finally
                {
                    if (fd != -1)
                    {
                        RFIDReaderInterop.closeNetPort(fd);
                    }
                }

                try
                {
                    await SendReadCommandAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending command: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Connection to RFID reader NOT established.");
            }
        }

        private async Task SendReadCommandAsync()
        {
            byte[] commandBytes = { READ_TAG_CMD };
            await stream.WriteAsync(commandBytes, 0, commandBytes.Length);

            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

            if (bytesRead > 0)
            {
                string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                MessageBox.Show($"Received RFID data: {receivedData}");
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct Version
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string HardVer;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string FirmVer;

            public int ReaderType;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct EPC
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] id;

            public int len;
            public int rssi;
            public int count;
        }

        private void GetInterfaceReturnDataCallback(int fd, int canId, byte cmd, int errCode, int len, IntPtr responseData)
        {
            byte[] byteArray = new byte[len];
            Marshal.Copy(responseData, byteArray, 0, len);

            string dataAsString = Encoding.ASCII.GetString(byteArray);
            txtLen.Invoke((MethodInvoker)(() => txtLen.Text = dataAsString));

            EPC EPCinfo = Marshal.PtrToStructure<EPC>(responseData);

            byte[] id_info = EPCinfo.id;
            int len_info = EPCinfo.len;
            int rssi_info = EPCinfo.rssi;
            int count_info = EPCinfo.count;

            // Convert the byte array to a hexadecimal string
            string idHex = BitConverter.ToString(id_info).Replace("-", "");

            // Print or use the hexadecimal string
            Console.WriteLine("Hexadecimal ID: " + idHex);


            MessageBox.Show($"ID Info edited: {BitConverter.ToInt64(id_info, 0)}\n LEN Info: {len_info}\n RSSI Info: {rssi_info}\n COUNT Info: {count_info}");
            txtEpc.Invoke((MethodInvoker)(() => txtEpc.Text = idHex.ToString()));
            txtLen.Invoke((MethodInvoker)(() => txtLen.Text = len_info.ToString()));
            txtRssi.Invoke((MethodInvoker)(() => txtRssi.Text = rssi_info.ToString()));
            txtCount.Invoke((MethodInvoker)(() => txtCount.Text = count_info.ToString()));

            if (cmd == READ_TAG_CMD)
            {
                MessageBox.Show("Congratulations! You're in read cmd!!!!!");

                // Convert the IntPtr to a byte array
                byte[] tagData = new byte[len];
                Marshal.Copy(responseData, tagData, 0, len);

                // Convert the byte array to a string (assuming ASCII encoding)
                string tagDataString = Encoding.ASCII.GetString(tagData);

                // Display the tag information in the TextBox
                txtLen.Invoke((MethodInvoker)(() => txtLen.Text = tagDataString));
            }

            if (cmd == GET_VERSION_CMD)
            {
                MessageBox.Show("Inside the GetVersionCommand");
                // Assuming responseData contains version_t structure
                Version versionInfo = Marshal.PtrToStructure<Version>(responseData);

                // Now you can access the version information
                string hardwareVersion = versionInfo.HardVer;
                string firmwareVersion = versionInfo.FirmVer;
                int readerType = versionInfo.ReaderType;

                byte[] hardwareVersionBytes = Encoding.ASCII.GetBytes(hardwareVersion);
                stream.Write(hardwareVersionBytes, 0, hardwareVersionBytes.Length);

                byte[] firmwareVersionBytes = Encoding.ASCII.GetBytes(firmwareVersion);
                stream.Write(firmwareVersionBytes, 0, firmwareVersionBytes.Length);

                txtHardwareVersion.Invoke((MethodInvoker)(() => txtHardwareVersion.Text = hardwareVersion));

                MessageBox.Show($"Hardware Version: {hardwareVersion}\nFirmware Version: {firmwareVersion}\nReader Type: {readerType}");

                // You can use these variables as needed, for example:
                // Update UI elements with these values
                // Display in text boxes, labels, etc.
                txtHardwareVersion.Invoke((MethodInvoker)(() => txtHardwareVersion.Text = hardwareVersion));
                txtFirmwareVersion.Invoke((MethodInvoker)(() => txtFirmwareVersion.Text = firmwareVersion));
                txtReaderType.Invoke((MethodInvoker)(() => txtReaderType.Text = readerType.ToString()));
            }
            else
            {
                // Handle other commands if needed
                MessageBox.Show("Error found");
            }
        }

        // Remember to close the connection when your form is closed
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Close the TCP/IP connection
            if (tcpClient != null)
            {
                stream?.Dispose();
                tcpClient.Close();
            }

            base.OnFormClosing(e);
        }

        
    }
}