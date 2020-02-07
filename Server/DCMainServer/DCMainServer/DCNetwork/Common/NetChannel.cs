using System;
using System.IO;
using System.Net.Sockets;
using Dcgameprotobuf;

namespace DC.Net
{
    /// <summary>
    /// 发送byte数组
    /// 返回packet
    /// </summary>
    public class NetChannel : ManualRes
    {
//        private NormalClient mClient;

        private TcpClient mClient;

        CircularBuffer mSendBuf = new CircularBuffer();

        CircularBuffer mRecvBuf = new CircularBuffer();

        private PacketParser mPacketParser;

        private event Action<Packet> mOnRecvListener; 

        public void Init(TcpClient client)
        {
            mClient = client;
            mPacketParser = new PacketParser(mRecvBuf);
        }

        public void Send(byte[] buf)
        {
            Send(buf,0,buf.Length);
        }

        public void Send(byte[] buf, int off, int len)
        {
            var lenBuf = DCGameProtocol.GetUshortBuf((ushort)len);
            mSendBuf.Write(lenBuf, 0, lenBuf.Length);

            mSendBuf.Write(buf, off, len);

            StartSend();
        }

        public void Send(params SendBuf[] bufs)
        {
            if (bufs.Length == 0) return;

            var len = 0;
            foreach (var buf in bufs)
            {
                len += buf.len;
            }

            var lenBuf = DCGameProtocol.GetUshortBuf((ushort)len);
            mSendBuf.Write(lenBuf, 0, lenBuf.Length);
            foreach (var buf in bufs)
            {
                mSendBuf.Write(buf.buf,buf.off,buf.len);
            }

            StartSend();
        }

        public async void StartSend()
        {
            while (mSendBuf.Length > 0)
            {
                if (mDisposed) return;

                var stream = mClient.GetStream();
                if (!stream.CanWrite)
                {
                    return;
                }

                await mSendBuf.ReadAsync(stream);
            }
        }

        public async void StartReceive()
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
                        //todo s send reconnect msg
                        
                        return;
                    }

                    var suc = mPacketParser.Parse();
                    if (suc)
                    {
                        var packet = mPacketParser.GetPacket();
                        if (null != mOnRecvListener)
                        {
                            mOnRecvListener(packet);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                DCLog.Err(e.Message);
                DCLog.Err(e.StackTrace);
            }
            catch (ObjectDisposedException e)
            {
                DCLog.Err(e.Message);
                DCLog.Err(e.StackTrace);
            }
            catch (Exception e)
            {
                DCLog.Err(e.Message);
                DCLog.Err(e.StackTrace);
            }
        }

        public void AddListener(Action<Packet> onReceive)
        {
            mOnRecvListener += onReceive;
        }

        public void RemvListener(Action<Packet> onReceive)
        {
            mOnRecvListener -= onReceive;
        }

        public void Close()
        {
            mClient.Close();
        }
    }

}
