using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.CSharp;


namespace MT3Y
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ID2_Click(object sender, EventArgs e)
        {
            Int16 st;
            int icdev = 0;
            string result = null;

            try
            {
                int port = 0;//COM1
                int baud = 115200;

                icdev = mtx_32dll.device_open(port, baud);
                if ((int)icdev > 0)
                {
                    listBox1.Items.Add("设备打开:" + icdev);
                }
                else
                {
                    listBox1.Items.Add("打开失败" + icdev);
                    return;
                }
                //读取身份证信息*/
                byte[] message = new byte[1024];
                st = mtx_32dll.IDCard_ReadCard(icdev, message);

                result = Encoding.Default.GetString(message).TrimEnd('\0');

                if (st == 0)
                {
                    listBox1.Items.Add("执行信息:" + result);

                    int i;
                    for (i = 0; i < 9;i++ )
                    {
                        byte[] info = new byte[1024];
                        string infodata = null;
                        st = mtx_32dll.IDCard_GetCardInfo(icdev, i, info);
                        infodata = Encoding.Default.GetString(info).TrimEnd('\0');
                        listBox1.Items.Add(">>:" + infodata);
                    }
                }
                else
                {
                    listBox1.Items.Add("读取信息失败!"+result);
                }

                //关闭设备
                st = mtx_32dll.device_close(icdev);

                if (st == 0)
                {
                    listBox1.Items.Add("设备关闭:" + icdev);
                }
                else
                {
                    listBox1.Items.Add("设备关闭失败:" + icdev);
                }
            }
            catch (Exception ex)
            {
                if (icdev <= 0)
                {
                    listBox1.Items.Add(ex.Message);
                }
                else
                {
                    // 关闭设备
                    st = mtx_32dll.device_close(icdev);
                    if (st == 0)
                    {
                        listBox1.Items.Add("设备关闭:" + icdev);
                    }
                    else
                    {
                        listBox1.Items.Add("设备关闭失败:" + icdev);
                    }

                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void ID2BMP_Click(object sender, EventArgs e)
        {
            Int16 st;
            int icdev = 0;
            string result = null;

            try
            {
                int port = 0;//COM1
                int baud = 115200;

                icdev = mtx_32dll.device_open(port, baud);
                if ((int)icdev > 0)
                {
                    listBox1.Items.Add("设备打开:" + icdev);
                }
                else
                {
                    listBox1.Items.Add("打开失败" + icdev);
                    return;
                }
                //读取身份证信息*/
                byte[] message = new byte[1024];
                string bmpPath = @"D:\ZP.bmp";
                byte[] photoPath = Encoding.Default.GetBytes(bmpPath);
                st = mtx_32dll.IDCard_ReadCard_Extra(icdev,photoPath, message);

                result = Encoding.Default.GetString(message).TrimEnd('\0');

                if (st == 0)
                {
                    listBox1.Items.Add("执行信息:" + result);

                    int i;
                    for (i = 0; i < 9; i++)
                    {
                        byte[] info = new byte[1024];
                        string infodata = null;
                        st = mtx_32dll.IDCard_GetCardInfo(icdev, i, info);
                        infodata = Encoding.Default.GetString(info).TrimEnd('\0');
                        listBox1.Items.Add(">>:" + infodata);
                    }
                }
                else
                {
                    listBox1.Items.Add("读取信息失败!" + result);
                }

                //关闭设备
                st = mtx_32dll.device_close(icdev);

                if (st == 0)
                {
                    listBox1.Items.Add("设备关闭:" + icdev);
                }
                else
                {
                    listBox1.Items.Add("设备关闭失败:" + icdev);
                }
            }
            catch (Exception ex)
            {
                if (icdev <= 0)
                {
                    listBox1.Items.Add(ex.Message);
                }
                else
                {
                    // 关闭设备
                    st = mtx_32dll.device_close(icdev);
                    if (st == 0)
                    {
                        listBox1.Items.Add("设备关闭:" + icdev);
                    }
                    else
                    {
                        listBox1.Items.Add("设备关闭失败:" + icdev);
                    }

                }

            }
        }

        private void JRCPU_Click(object sender, EventArgs e)
        {
            Int16 st;
            int icdev = 0;
            string result = null;

            try
            {
                int port = 0;//COM1
                int baud = 115200;

                icdev = mtx_32dll.device_open(port, baud);
                if ((int)icdev > 0)
                {
                    listBox1.Items.Add("设备打开:" + icdev);
                }
                else
                {
                    listBox1.Items.Add("打开失败" + icdev);
                    return;
                }
                //读银行卡
                int cardType = 0xFF;//非接卡
                byte[] message = new byte[1024];
                byte[] cardNo= new byte[64];
                byte[] name = new byte[64];
                int st1 = mtx_32dll.iReadICCardNoAndName(icdev, cardType, cardNo,name,message);

                result = Encoding.Default.GetString(message).TrimEnd('\0');

                if (st1 == 0)
                {
                    string Sname = null;
                    string ScardNo = null;
                    Sname = Encoding.Default.GetString(name);
                    ScardNo = Encoding.Default.GetString(cardNo);

                    listBox1.Items.Add("姓名:" + Sname);
                    listBox1.Items.Add("卡号:" + ScardNo);
                }
                else
                {
                    listBox1.Items.Add("读卡失败!" + result);
                }

                //关闭设备
                st = mtx_32dll.device_close(icdev);

                if (st == 0)
                {
                    listBox1.Items.Add("设备关闭:" + icdev);
                }
                else
                {
                    listBox1.Items.Add("设备关闭失败:" + icdev);
                }
            }
            catch (Exception ex)
            {
                if (icdev <= 0)
                {
                    listBox1.Items.Add(ex.Message);
                }
                else
                {
                    // 关闭设备
                    st = mtx_32dll.device_close(icdev);
                    if (st == 0)
                    {
                        listBox1.Items.Add("设备关闭:" + icdev);
                    }
                    else
                    {
                        listBox1.Items.Add("设备关闭失败:" + icdev);
                    }

                }

            }
        }

        private void CPU_Click(object sender, EventArgs e)
        {
            int icdev = 0;
            Int16 st;
            byte atrLen;
            int rlen;
            byte[] atrData = new byte[200];
            byte[] atrAsc = new byte[200];
            byte[] snr = new byte[100];

            byte[] senddata = new byte[6];   //{0x00,0x84,0x00,0x00,0x08,0};   //获取随机数
            byte[] datarecv = new byte[300];
            byte[] datarecvasc = new byte[600];
            //mt_32dll.rf_card(icdev, 0, recdata,cardinfolen);

            int port = 0;//COM1
            int baud = 115200;

            icdev = mtx_32dll.device_open(port, baud);
            if ((int)icdev > 0)
            {
                listBox1.Items.Add("设备打开:" + icdev);
            }
            else
            {
                listBox1.Items.Add("打开失败" + icdev);
                return;
            }

            st = mtx_32dll.sam_slt_reset(icdev, 0, 0,out atrLen, atrData);
            if (st != 0)
            {
                listBox1.Items.Add("接触CPU卡打开失败!");
                return;
            }
            else
            {
                st = mtx_32dll.hex_asc(atrData, atrAsc, atrLen);
                listBox1.Items.Add("接触CPU卡打开成功,复位信息:");
                listBox1.Items.Add(Encoding.Default.GetString(atrAsc));
            }

            //获取随机数
            senddata[0] = 0;
            senddata[1] = 132;
            senddata[2] = 0;
            senddata[3] = 0;
            senddata[4] = 8;
            senddata[5] = 0;
            st = mtx_32dll.card_APDU(icdev, 0, 5, senddata, out rlen, datarecv);
            if (st != 0)
            {
                listBox1.Items.Add("接触CPU卡取随机数失败!");
            }
            else
            {
                st = mtx_32dll.hex_asc(datarecv, datarecvasc, (ulong)rlen);
                listBox1.Items.Add("接触CPU卡取随机数成功,随机数:");
                listBox1.Items.Add(Encoding.Default.GetString(datarecvasc));
            }

            st = mtx_32dll.sam_slt_powerdown(icdev, 0);
            if (st != 0)
                listBox1.Items.Add("接触CPU卡关闭失败!");
            else
                listBox1.Items.Add("接触CPU卡关闭成功!");

            //关闭设备
            st = mtx_32dll.device_close(icdev);

            if (st == 0)
            {
                listBox1.Items.Add("设备关闭:" + icdev);
            }
            else
            {
                listBox1.Items.Add("设备关闭失败:" + icdev);
            }

        }

        private void FJCPU_Click(object sender, EventArgs e)
        {
            int icdev = 0;
            Int16 st;
            byte snrLen,atrLen;
            int rlen;
            byte[] cardType = new byte[16];
            byte[] atrData = new byte[200];
            byte[] atrAsc = new byte[200];
            byte[] snr = new byte[100];

            byte[] senddata = new byte[6];   //{0x00,0x84,0x00,0x00,0x08,0};   //获取随机数
            byte[] datarecv = new byte[300];
            byte[] datarecvasc = new byte[600];
            //mt_32dll.rf_card(icdev, 0, recdata,cardinfolen);

            int port = 0;//COM1
            int baud = 115200;

            icdev = mtx_32dll.device_open(port, baud);
            if ((int)icdev > 0)
            {
                listBox1.Items.Add("设备打开:" + icdev);
            }
            else
            {
                listBox1.Items.Add("打开失败" + icdev);
                return;
            }

            st = mtx_32dll.open_card(icdev, 0,cardType,out snrLen, snr, out atrLen, atrData);
            if (st != 0)
            {
                listBox1.Items.Add("非接CPU卡打开失败!");
                return;
            }
            else
            {
                st = mtx_32dll.hex_asc(atrData, atrAsc,atrLen);
                listBox1.Items.Add("非接CPU卡打开成功,复位信息:");
                listBox1.Items.Add(Encoding.Default.GetString(atrAsc));
            }

            //获取随机数
            senddata[0] = 0;
            senddata[1] = 132;
            senddata[2] = 0;
            senddata[3] = 0;
            senddata[4] = 8;
            senddata[5] = 0;
            st = mtx_32dll.card_APDU(icdev,0xFF,5, senddata,out rlen,datarecv);
            if (st != 0)
            {
                listBox1.Items.Add("非接CPU卡取随机数失败!");
            }
            else
            {
                st = mtx_32dll.hex_asc(datarecv, datarecvasc, (ulong)rlen);
                listBox1.Items.Add("非接CPU卡取随机数成功,随机数:");
                listBox1.Items.Add(Encoding.Default.GetString(datarecvasc));
            }

            st = mtx_32dll.rf_halt(icdev,0);
            if (st != 0)
                listBox1.Items.Add("非接CPU卡关闭失败!");
            else
                listBox1.Items.Add("非接CPU卡关闭成功!");

            //关闭设备
            st = mtx_32dll.device_close(icdev);

            if (st == 0)
            {
                listBox1.Items.Add("设备关闭:" + icdev);
            }
            else
            {
                listBox1.Items.Add("设备关闭失败:" + icdev);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //其实是读金融社保卡内银行卡部分的持卡人信息
            int icdev = 0;
            Int16 st;
            byte snrLen, atrLen;
            byte[] cardType = new byte[16];
            byte[] atrData = new byte[200];
            byte[] atrAsc = new byte[200];
            byte[] snr = new byte[100];

            try
            {
                int port = 0;//COM1
                int baud = 115200;

                icdev = mtx_32dll.device_open(port, baud);
                if ((int)icdev > 0)
                {
                    listBox1.Items.Add("设备打开:" + icdev);
                }
                else
                {
                    listBox1.Items.Add("打开失败" + icdev);
                    return;
                }
                st = mtx_32dll.open_card(icdev, 0, cardType, out snrLen, snr, out atrLen, atrData);
                if (st != 0)
                {
                    listBox1.Items.Add("非接CPU卡打开失败!");
                    return;
                }
                else
                {
                    st = mtx_32dll.hex_asc(atrData, atrAsc, atrLen);
                    listBox1.Items.Add("非接CPU卡打开成功,复位信息:");
                    listBox1.Items.Add(Encoding.Default.GetString(atrAsc));
                }
                //读银行卡
                byte[] sbAPDU = new byte[50];
                byte[] data = new byte[1024];
                byte[] readDate = new byte[1024];
                string s;
                int dataLen = 0;
                s = "00A40000023F00";
                sbAPDU = strToToHexByte(s);
                st = mtx_32dll.card_APDU(icdev, 255, sbAPDU.Length, sbAPDU, out dataLen, data);

                s = "00B2010C";
                sbAPDU = strToToHexByte(s);
                st = mtx_32dll.card_APDU(icdev, 255, sbAPDU.Length, sbAPDU, out dataLen, data);

                s = "00A4040009A00000000386980701";
                sbAPDU = strToToHexByte(s);
                st = mtx_32dll.card_APDU(icdev, 255, sbAPDU.Length, sbAPDU, out dataLen, data);

                s = "00B0960000";
                sbAPDU = strToToHexByte(s);
                st = mtx_32dll.card_APDU(icdev, 255, sbAPDU.Length, sbAPDU, out dataLen, data);

                if (data[dataLen - 2] == 0x90 && data[dataLen - 1] == 0)
                {
                    listBox1.Items.Add("社保卡读取成功!");
                    //读到的原始数据
                    textBox1.Text = "";
                    for (int i = 0; i < dataLen; i++)
                    {
                        textBox1.Text = textBox1.Text + byteToStr(data[i]) + " ";
                    }

                    textBox2.Text = "";
                    //获取姓名
                    byte[] name = new byte[60];
                    for (int i = 0; i < 22 && data[i + 2] != 0; i++)
                    {
                        name[i] = data[i + 2];
                    }
                    System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");
                    textBox2.Text = chs.GetString(name);

                    textBox5.Text = "";
                    //获取卡号
                    for (int i = 22; i < 55 && data[i] != 0; i++)
                    {
                        textBox5.Text = textBox5.Text + (data[i] - 48).ToString();
                    }

                    switch (data[55] - 48)
                    {
                        case 1:
                            textBox3.Text = "身份证";
                            break;


                    }
                }
                else
                {
                    listBox1.Items.Add("社保卡读取失败!");
                }

                //关闭卡片
                st = mtx_32dll.rf_halt(icdev, 0);
                if (st != 0)
                    listBox1.Items.Add("非接CPU卡关闭失败!");
                else
                    listBox1.Items.Add("非接CPU卡关闭成功!");
                //关闭设备
                st = mtx_32dll.device_close(icdev);

                if (st == 0)
                {
                    listBox1.Items.Add("设备关闭:" + icdev);
                }
                else
                {
                    listBox1.Items.Add("设备关闭失败:" + icdev);
                }
            }
            catch (Exception ex)
            {
                if (icdev <= 0)
                {
                    listBox1.Items.Add(ex.Message);
                }
                else
                {
                    // 关闭设备
                    st = mtx_32dll.device_close(icdev);
                    if (st == 0)
                    {
                        listBox1.Items.Add("设备关闭:" + icdev);
                    }
                    else
                    {
                        listBox1.Items.Add("设备关闭失败:" + icdev);
                    }

                }

            }
        }

        private static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        string byteToStr(byte a)
        {
            string h, l;
            h = "";
            l = "";
            switch (a / 16)
            {
                case 0:
                    h = "0";
                    break;
                case 1:
                    h = "1";
                    break;
                case 2:
                    h = "2";
                    break;
                case 3:
                    h = "3";
                    break;
                case 4:
                    h = "4";
                    break;
                case 5:
                    h = "5";
                    break;
                case 6:
                    h = "6";
                    break;
                case 7:
                    h = "7";
                    break;
                case 8:
                    h = "8";
                    break;
                case 9:
                    h = "9";
                    break;
                case 10:
                    h = "A";
                    break;
                case 11:
                    h = "B";
                    break;
                case 12:
                    h = "C";
                    break;
                case 13:
                    h = "D";
                    break;
                case 14:
                    h = "E";
                    break;
                case 15:
                    h = "F";
                    break;
            }
            switch (a % 16)
            {
                case 0:
                    l = "0";
                    break;
                case 1:
                    l = "1";
                    break;
                case 2:
                    l = "2";
                    break;
                case 3:
                    l = "3";
                    break;
                case 4:
                    l = "4";
                    break;
                case 5:
                    l = "5";
                    break;
                case 6:
                    l = "6";
                    break;
                case 7:
                    l = "7";
                    break;
                case 8:
                    l = "8";
                    break;
                case 9:
                    l = "9";
                    break;
                case 10:
                    l = "A";
                    break;
                case 11:
                    l = "B";
                    break;
                case 12:
                    l = "C";
                    break;
                case 13:
                    l = "D";
                    break;
                case 14:
                    l = "E";
                    break;
                case 15:
                    l = "F";
                    break;
            }
            return h + l;
        }
    }
}
