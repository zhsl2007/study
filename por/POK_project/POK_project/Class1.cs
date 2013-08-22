using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace POK_project
{
    class SendSocket
    {
        public SendSocket(String strIPAdress, int port)
        {
            m_strIP = strIPAdress;
            m_nPort = port;
        }
        private Socket senderSock;
        private String m_strIP;
        private int m_nPort;
        byte[] bytes = new byte[1024];

        public bool ConnnectServer()
        {
            try
            {
                // Create one SocketPermission for socket access restrictions 
                SocketPermission permission = new SocketPermission(
                    NetworkAccess.Connect,    // Connection permission 
                    TransportType.Tcp,        // Defines transport types 
                    m_strIP,                       // Gets the IP addresses 
                    m_nPort // All ports 
                    );

                // Ensures the code to have permission to access a Socket 
                permission.Demand();

                // Resolves a host name to an IPHostEntry instance            
                //IPHostEntry ipHost = Dns.GetHostEntry(m_strIP);

                // Gets first IP address associated with a localhost 
                //IPAddress ipAddr = ipHost.AddressList[0];
                IPAddress ipAddr = IPAddress.Parse(m_strIP);

                // Creates a network endpoint 
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, m_nPort);

                // Create one Socket object to setup Tcp connection 
                senderSock = new Socket(
                    ipAddr.AddressFamily,// Specifies the addressing scheme 
                    SocketType.Stream,   // The type of socket  
                    ProtocolType.Tcp     // Specifies the protocols  
                    );

                senderSock.NoDelay = false;   // Using the Nagle algorithm 

                // Establishes a connection to a remote host 
                senderSock.Connect(ipEndPoint);
                //tbStatus.Text = "Socket connected to " + senderSock.RemoteEndPoint.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return true;
        }

        public void SendMsg(String strMsg)
        {
            try
            {
                // Sending message 
                //<Client Quit> is the sign for end of data 
                //string theMessageToSend = tbMsg.Text;
                byte[] msg = Encoding.ASCII.GetBytes(strMsg);

                // Sends data to a connected Socket. 
                int bytesSend = senderSock.Send(msg);

                ReceiveDataFromServer();

            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        public void ReceiveDataFromServer()
        {
            try
            {
                // Receives data from a bound Socket. 
                int bytesRec = senderSock.Receive(bytes);

                // Converts byte array to string 
                String theMessageToReceive = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                // Continues to read the data till data isn't available 
                while (senderSock.Available > 0)
                {
                    bytesRec = senderSock.Receive(bytes);
                    theMessageToReceive += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }

                //tbReceivedMsg.Text = "The server reply: " + theMessageToReceive;
                Console.WriteLine(String.Format("The server reply: {0}", theMessageToReceive));
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        public void Disconnect()
        {
            try
            {
                // Disables sends and receives on a Socket. 
                senderSock.Shutdown(SocketShutdown.Both);

                //Closes the Socket connection and releases all resources 
                senderSock.Close();

            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        } 


    }
}
