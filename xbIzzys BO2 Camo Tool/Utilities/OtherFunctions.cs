using JRPC_Client;
using System;
using System.Windows.Forms;
using xbIzzys_BO2_Camo_Tool.Utilities.Camos;
using XDevkit;

namespace xbIzzys_BO2_Camo_Tool.Utilities
{
    public class OtherFunctions
    {
        public static IXboxConsole Console;

        public static void SetW115Speed(byte ScrollByte)
        {
            Console.WriteByte(0xA58A80D4, ScrollByte);
            Console.WriteByte(0xA58A8050, ScrollByte);
            Console.WriteByte(0xA58A7CF0, ScrollByte);
            Console.WriteByte(0xA58A7CF4, ScrollByte);
            Console.WriteByte(0xA58A7C70, ScrollByte);
            Console.WriteByte(0xA58A8314, ScrollByte);
            Console.WriteByte(0xA58A7B50, ScrollByte);
            Console.WriteByte(0xA58A7B54, ScrollByte);
            Console.WriteByte(0xA58A84B0, ScrollByte);
            Console.WriteByte(0xA58A86F0, ScrollByte);
            Console.WriteByte(0xA58A8810, ScrollByte);
            Console.WriteByte(0xA58A8890, ScrollByte);
            Console.WriteByte(0xA58A7F30, ScrollByte);
            Console.WriteByte(0xA58A80D0, ScrollByte);
            Console.WriteByte(0xA58A8310, ScrollByte);
        }

        public static void SetW115Glow(byte GlowByte)
        {
            Console.WriteByte(0xA58A7B30, GlowByte);
            Console.WriteByte(0xA58A7F10, GlowByte);
            Console.WriteByte(0xA58A82F0, GlowByte);
            Console.WriteByte(0xA58A86D0, GlowByte);
        }
    }
}
