using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleapp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello, World!");
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Form2 helloWorldForm = new Form2();
            helloWorldForm.Show();
        }


            /*
            private void btnlogin_Click_1(object sender, EventArgs e)
            {       

                string username = txtusername.Text;
                string password = txtpassword.Text;
                string userType = "";

                // Determine the selected user type based on the selected radio button
                if (rbtnadmin.Checked)
                {
                    userType = "Admin";
                }
                else if (rbtnemp.Checked)
                {
                    userType = "User";
                }


                string ConnectionString = "Server=localhost;Database=nupurdb;User ID=root;Password=nupursqlgo;";

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password AND userType = @userType";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@userType", userType);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // Authentication successful
                            if (userType == "Admin")
                            {
                                Form2 helloWorldForm = new Form2();
                                helloWorldForm.Show();
                            }
                            else if (userType == "User")
                            {
                                MessageBox.Show("User login successful!");
                            }
                        }
                        else
                        {
                            // Authentication failed
                            MessageBox.Show("Invalid username, password, or user type. Please try again.");
                        }


                    }
                }
            }*/
        }
}

/*


using System;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private RFIDReader.GetInterfaceReturnData callback;
    private int fd; // File descriptor or handle for the open network port

    public MainForm()
    {
        InitializeComponent();

        // Initialize the callback
        callback = new RFIDReader.GetInterfaceReturnData(OnDataReceived);

        // Initialize the SDK
        RFIDReader.sdk_init(1, callback); // Assuming network mode (1)

        // Open the network port
        int canId = 0; // or any other suitable value
        int canNum = 1; // or any other suitable value

        // Replace "192.168.131.220" with your RFID reader's actual IP address
        fd = RFIDReader.openNetPort("192.168.131.220", 8088, ref canId, canNum);

        if (fd >= 0)
        {
            // Connection successful, proceed with your application logic
            // For example, enable UI controls or start reading tags
        }
        else
        {
            // Handle connection error
            MessageBox.Show("Failed to open network port. Error code: " + fd, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void OnDataReceived(int fd, int canId, byte cmd, int errCode, int len, IntPtr responseData)
    {
        // Handle the received data here
        // You can use Marshal.Copy to convert the IntPtr to a managed array

        // Example:
        byte[] data = new byte[len];
        Marshal.Copy(responseData, data, 0, len);

        // Your processing logic...
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Clean up resources, close connections, etc.
        // Make sure to close the network port
        RFIDReader.closeNetPort(fd);
    }

    // Your other form methods and event handlers...
}



*/
