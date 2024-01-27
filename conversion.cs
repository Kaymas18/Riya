﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
////using System.Threading.Tasks;

namespace simpleapp
{
    internal class conversion
    {
        // Method to calculate BCC (Bitwise Exclusive OR) for a given byte array.
        public static byte BccCheckUtil(byte[] data)
        {
            byte CheckCode = 0;
            int len = data.Length;

            // Method to calculate BCC (Bitwise Exclusive OR) for a given byte array.
            for (int i = 0; i < len; i++)
            {
                CheckCode ^= data[i];
            }

            // Return the resulting BCC.
            return CheckCode;
        }

        // Similar method to BccCheckUtil, but allows specifying the length of the array.
        public static byte Check_Xor(byte[] data, int len)
        {
            byte CheckCode = 0;

            // Loop through each byte in the array and perform XOR operation.
            //int len = data.Length;
            for (int i = 0; i < len; i++)
            {
                CheckCode ^= data[i];
            }

            // Return the resulting XOR.
            return CheckCode;
        }

        #region 进制转化优化程序（数组）  ( Hexadecimal Conversion Optimization Program (Array) )
        /// <summary>
        /// 字节数组转化为16进制字符串  ( Converts a byte array to a hexadecimal string with a specified format character between each byte. )
        /// </summary>
        /// <param name="bytes">字节数组  Byte array to convert. </param>
        /// <param name="format">格式字符 Format character. </param>
        /// <returns>16进制字符串  Hexadecimal string. </returns>
        public static string ToHexString2Format(byte[] bytes, string format)
        {
            string ret = string.Empty;

            // Loop through each byte and convert it to a formatted hexadecimal string.
            foreach (byte mybyte in bytes)
            {
                ret += mybyte.ToString("X2") + format;
            }

            // Remove the trailing format character and return the resulting hexadecimal string.
            ret = ret.Substring(0, ret.Length);
            return ret;
        }
        /// <summary>
        /// 字符串转16进制字节数组 ( Converts a space-separated hexadecimal string to a byte array. )
        /// </summary>
        /// <param name="hexStr">16进制字符串  Input hexadecimal string. </param>
        /// <returns> Byte array. </returns>
        public static byte[] strToHexByte(string hexStr)
        {
            hexStr = hexStr.Replace(" ", "");

            // Add a space if the length of the hexadecimal string is not even.
            if ((hexStr.Length % 2) != 0)
            {
                hexStr += " ";
            }

            // Create a byte array by parsing substrings of the hexadecimal string.
            byte[] retrunBytes = new byte[hexStr.Length / 2];
            for (int i = 0; i < retrunBytes.Length; i++)
            {
                retrunBytes[i] = Convert.ToByte(hexStr.Substring(i * 2, 2), 16);
            }

            // Return the resulting byte array.
            return retrunBytes;
        }

        /// <summary>
        /// 单个字符串转16进制
        /// </summary>
        /// <param name="hexStr"></param>
        /// <returns></returns>
        public static byte oneStrToHexByte(string hexStr)
        {

            hexStr = hexStr.Replace(" ", "");
            return Convert.ToByte(hexStr, 16);
        }
        /// <summary>
        /// 汉字转16进制字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="charset">字符编码：如"utf-8","gb2312"</param>
        /// <param name="fenge">是否每字符用逗号分隔</param>
        /// <returns></returns>
        public static string ChineseToHex(string s, string charset, bool fenge)
        {
            if ((s.Length % 2) != 0)
            {
                s += " ";//空格
                         //throw new ArgumentException("s is not valid chinese string!");
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding(charset);
            byte[] bytes = chs.GetBytes(s);
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str += string.Format("{0:X}", bytes[i]);
                if (fenge && (i != bytes.Length - 1))
                {
                    str += string.Format("{0}", ",");
                }
            }
            //return str.ToLower();
            return str;
        }
        /// <summary>
        /// 从16进制转汉字
        /// </summary>
        /// <param name="hex"></param>
        /// <param name="charset">编码：如"utf-8","gb2312"</param>
        /// <returns></returns>
        public static string UnHexToChinese(string hex, string charset)
        {
            if (hex == null)
                throw new ArgumentNullException("hex");
            hex = hex.Replace(",", "");
            hex = hex.Replace("\n", "");
            hex = hex.Replace("\\", "");
            hex = hex.Replace(" ", "");
            if (hex.Length % 2 != 0)
            {
                hex += "20";//空格
            }
            // 需要将 hex 转换成 byte 数组。 
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte。 
                    bytes[i] = byte.Parse(hex.Substring(i * 2, 2),
                    System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    // Rethrow an exception with custom message. 
                    throw new ArgumentException("hex is not a valid hex number!", "hex");
                }
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding(charset);
            return chs.GetString(bytes);
        }
        #endregion


        /// <summary>
        /// 将字符串转为16进制字符，允许中文
        /// </summary>
        /// <param name="s"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public static string StringToHexString(string s, Encoding encode)
        {
            byte[] b = encode.GetBytes(s);//按照指定编码将string编程字节数组
            string result = string.Empty;
            for (int i = 0; i < b.Length; i++)//逐字节变为16进制字符
            {
                result += Convert.ToString(b[i], 16);
            }
            return result;
        }

        /// <summary>
        /// 字节数组转10进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string bytesToStr(byte[] bytes)
        {
            /*
               string result = string.Empty;
            for (int i = 0; i < hardVerData.Length; i++)//逐字节变为10进制字符
            {
                result += Convert.ToString(hardVerData[i], 10);
            }
             */

string returnStr = "";
if (bytes != null)
{
    for (int i = 0; i < bytes.Length; i++)
    {
        returnStr += bytes[i].ToString();//ToString("X2")
    }
}
return returnStr;
        }

        public static string bytesToStr(byte[] bytes, string split)
{
    string returnStr = "";
    if (bytes != null)
    {
        for (int i = 0; i < bytes.Length; i++)
        {
            if (i < bytes.Length - 1)
            {
                returnStr += bytes[i].ToString() + split;//ToString("X2")
            }
            else
            {
                returnStr += bytes[i].ToString();//ToString("X2")
            }

        }
    }
    return returnStr;
}


public static string charsToStr(char[] bytes, string split)
{
    string returnStr = "";
    if (bytes != null)
    {
        for (int i = 0; i < bytes.Length; i++)
        {
            if (i < bytes.Length - 1)
            {
                returnStr += bytes[i].ToString() + split;//ToString("X2")
            }
            else
            {
                returnStr += bytes[i].ToString();//ToString("X2")
            }

        }
    }
    return returnStr;
}

    }
}

