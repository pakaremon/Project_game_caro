using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PROJECT_CARO_GAME
{
    class ConnectLanNetwork
    {
        bool isConnected;
        public ConnectLanNetwork()
        {
            isConnected = false;
        }

        //Tạo server
        public Socket createServer(int port)
        {
            try
            {
                IPEndPoint ipe = new IPEndPoint(IPAddress.Any, port);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(ipe);
                isConnected = true;
                return socket;
            }
            catch (Exception)
            {
                isConnected = false;
                return null;
            }
        }

        //Kết nối đến Server
        public Socket connectServer(string ipaddress, int port)
        {
            try
            {
                IPAddress ipa = IPAddress.Parse(ipaddress);
                IPEndPoint ipe = new IPEndPoint(ipa, port);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipe);
                isConnected = true;
                return socket;
            }
            catch (Exception)
            {
                isConnected = false;
                return null;
            }
        }

        //Hàm truyền dữ liệu
        public void sentData(Socket socket, string[] data)
        {
            try
            {
                if (isConnected)
                    socket.Send(objToByte(data));
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
        }

        //Hàm chuyển obj sang byte
        public byte[] objToByte(object obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                return stream.ToArray();
            }
        }

        //Hàm chuyển byte sang obj
        public object byteToObj(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(stream);
            }
        }
    }
}
