using UnityEngine;
using System.Net.Sockets;
using System;

public class Client : MonoBehaviour
{
    private TcpClient mySocket;
    private string host = "localhost";
    private Int32 port = 8080;

    [ContextMenu("VerifyMessageServer")]
    private void VerifyMessageServer()
    {
        try
        {
            mySocket = new TcpClient(host, port);

            byte[] myReadBuffer = new byte[100];

            var messageReceveid = mySocket.GetStream().Read(myReadBuffer, 0, myReadBuffer.Length);

            print("byte Receveid:: " + myReadBuffer.GetValue(0));
        }
        catch(Exception e)
        {
            print("Error:: " + e);
        }
    }
}