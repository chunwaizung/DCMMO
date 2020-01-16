using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using UnityEngine;

namespace DC.Net
{
    public abstract class NormalClient
    {
        private TcpClient mClient;

        public async void Send(byte[] buf)
        {
            var lenBytes = BitConverter.GetBytes(buf.Length);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(lenBytes);
            }

            await mClient.GetStream().WriteAsync(lenBytes, 0, 4);
            await mClient.GetStream().WriteAsync(buf, 0, buf.Length);
        }

        public async void Receive()
        {
            var buf = new byte[1024 * 512];

            var readCnt = await mClient.GetStream().ReadAsync(buf, 0, buf.Length);

        }
    }

    public class CRes
    {
        protected bool mDisposed;

        public virtual void DisposeRes()
        {
            mDisposed = true;
        }
    }

    public class NetworkClient : CRes
    {
        public static readonly int max_send_buf_len = 1024 * 512;

        public static readonly int max_rec_buf_len = 1024 * 512;

//        private NormalClient mClient;

        private TcpClient mClient;

        CircularBuffer mSendBuf = new CircularBuffer();

        CircularBuffer mRecvBuf = new CircularBuffer();

        public void Init(string host, int port)
        {
        }

        public void Send(byte[] buf)
        {

        }

        public async void StreamToByteBuf(Stream stream, ByteBuf byteBuf)
        {
            
        }

        public async void Receive()
        {
            /*
             tcp 确保收到服务器下发的所有数据
             为了减少丢包导致的损失减少每次数据的发送量
            */

            /*
             udp 不保证包一定送达 不保证顺序
             需要实现拼接
             */
            try
            {
                while (true)
                {
                    if (mDisposed)
                    {
                        return;
                    }

                    var stream = mClient.GetStream();
                    if (!stream.CanRead)
                    {
                        return;
                    }

                    var cnt = await mRecvBuf.WriteAsync(stream);
                    if (cnt == 0)
                    {
                        //SocketError.NetworkReset
                        //todo send reconnect msg
                        return;
                    }
                }
            }
            catch (IOException e)
            {
                
            }
            catch (ObjectDisposedException e)
            {
            }
            catch (Exception e)
            {
            }
            
        }

        public void AddListener(Action<byte[]> onReceive)
        {

        }
    }
}
