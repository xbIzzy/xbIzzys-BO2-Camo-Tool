using XDevkit;
using JRPC_Client;

namespace xbIzzys_BO2_Camo_Tool.Utilities
{
    public class ClassCamos
    {
        public static IXboxConsole Console;

        public static void ApplyCyborg()
        {
            Console.SetMemory(0x84353A50, new byte[] { 0x0D, 0x01, 0x00 });
            Console.SetMemory(0x84353A5D, new byte[] { 0x0D, 0x87, 0x00 });
            Console.SetMemory(0x84353A83, new byte[] { 0x0D, 0xC1, 0x10 });
            Console.SetMemory(0x84353A92, new byte[] { 0x6D, 0x08, 0x00 });
            Console.SetMemory(0x84353AB9, new byte[] { 0x0D, 0x01, 0x00 });
            Console.SetMemory(0x84353AC6, new byte[] { 0x0D, 0x87, 0x00 });
            Console.SetMemory(0x84353AED, new byte[] { 0xCD, 0x10, 0x00 });
            Console.SetMemory(0x84353AFB, new byte[] { 0x6D, 0x08, 0x00 });
            Console.SetMemory(0x84353B22, new byte[] { 0x0D, 0x01, 0x00 });
            Console.SetMemory(0x84353B30, new byte[] { 0x87, 0x00, 0x00 });
            Console.SetMemory(0x84353B56, new byte[] { 0xCD, 0x10, 0x00 });
            Console.SetMemory(0x84353B64, new byte[] { 0x6D, 0x08, 0x00 });
            Console.SetMemory(0x84353B8B, new byte[] { 0x0D, 0x01, 0x00 });
            Console.SetMemory(0x84353B99, new byte[] { 0x87, 0x00, 0x00 });
            Console.SetMemory(0x84353BBF, new byte[] { 0xCD, 0x10, 0x00 });
            Console.SetMemory(0x84353BCD, new byte[] { 0x6D, 0x08, 0x00 });
            Console.SetMemory(0x84353BF4, new byte[] { 0x0D, 0x01, 0x00 });
            Console.SetMemory(0x84353C02, new byte[] { 0x87, 0x00, 0x00 });
            Console.SetMemory(0x84353C28, new byte[] { 0xCD, 0x10, 0x00 });
            Console.SetMemory(0x84353C36, new byte[] { 0x6D, 0x08, 0x00 });
            Console.XNotify("xbIzzys BO2 Camo Tool | Applied Cyborg to Public Classes");
        }

        public static void ApplyDragon()
        {
            Console.SetMemory(0x84353A50, new byte[] { 0x11, 0xA1, 0x00 });
            Console.SetMemory(0x84353A5D, new byte[] { 0x00, 0x88, 0x00 });
            Console.SetMemory(0x84353A83, new byte[] { 0x00, 0x00, 0x11 });
            Console.SetMemory(0x84353A92, new byte[] { 0x80, 0xA8, 0x00 });
            Console.SetMemory(0x84353AB9, new byte[] { 0x10, 0x01, 0x00 });
            Console.SetMemory(0x84353AC6, new byte[] { 0x00, 0x88, 0x00 });
            Console.SetMemory(0x84353AED, new byte[] { 0x00, 0x11, 0x00 });
            Console.SetMemory(0x84353AFB, new byte[] { 0x80, 0x08, 0x00 });
            Console.SetMemory(0x84353B22, new byte[] { 0x10, 0x01, 0x00 });
            Console.SetMemory(0x84353B30, new byte[] { 0x88, 0x00, 0x00 });
            Console.SetMemory(0x84353B56, new byte[] { 0x00, 0x11, 0x00 });
            Console.SetMemory(0x84353B64, new byte[] { 0x80, 0x08, 0x00 });
            Console.SetMemory(0x84353B8B, new byte[] { 0x10, 0x01, 0x00 });
            Console.SetMemory(0x84353B99, new byte[] { 0x88, 0x0A, 0x00 });
            Console.SetMemory(0x84353BBF, new byte[] { 0x00, 0x11, 0x00 });
            Console.SetMemory(0x84353BCD, new byte[] { 0x80, 0x08, 0x00 });
            Console.SetMemory(0x84353BF4, new byte[] { 0x10, 0x01, 0x00 });
            Console.SetMemory(0x84353C02, new byte[] { 0x88, 0x00, 0x00 });
            Console.SetMemory(0x84353C28, new byte[] { 0x00, 0x11, 0x00 });
            Console.SetMemory(0x84353C36, new byte[] { 0x80, 0x08, 0x00 });
            Console.XNotify("xbIzzys BO2 Camo Tool | Applied Dragon to Public Classes");
        }

        public static void ApplyW115()
        {
            Console.SetMemory(0x84353A50, new byte[] { 0x78, 0x01, 0x00 });
            Console.SetMemory(0x84353A5D, new byte[] { 0x00, 0xBC, 0x00 });
            Console.SetMemory(0x84353A83, new byte[] { 0x00, 0x80, 0x17 });
            Console.SetMemory(0x84353A92, new byte[] { 0xC0, 0x0B, 0x00 });
            Console.SetMemory(0x84353AB9, new byte[] { 0x78, 0x01, 0x00 });
            Console.SetMemory(0x84353AC6, new byte[] { 0x00, 0xBC, 0x00 });
            Console.SetMemory(0x84353AED, new byte[] { 0x80, 0x17, 0x00 });
            Console.SetMemory(0x84353AFB, new byte[] { 0xC0, 0x0B, 0x00 });
            Console.SetMemory(0x84353B22, new byte[] { 0x78, 0x01, 0x00 });
            Console.SetMemory(0x84353B30, new byte[] { 0xBC, 0x00, 0x00 });
            Console.SetMemory(0x84353B56, new byte[] { 0x80, 0x17, 0x00 });
            Console.SetMemory(0x84353B64, new byte[] { 0xC0, 0x0B, 0x00 });
            Console.SetMemory(0x84353B8B, new byte[] { 0x78, 0x01, 0x00 });
            Console.SetMemory(0x84353B99, new byte[] { 0xBC, 0x00, 0x00 });
            Console.SetMemory(0x84353BBF, new byte[] { 0x80, 0x17, 0x00 });
            Console.SetMemory(0x84353BCD, new byte[] { 0xC0, 0x0B, 0x00 });
            Console.SetMemory(0x84353BF4, new byte[] { 0x78, 0x01, 0x00 });
            Console.SetMemory(0x84353C02, new byte[] { 0xBC, 0x00, 0x00 });
            Console.SetMemory(0x84353C28, new byte[] { 0x80, 0x17, 0x00 });
            Console.SetMemory(0x84353C36, new byte[] { 0xC0, 0x0B, 0x00 });
            Console.XNotify("xbIzzys BO2 Camo Tool | Applied W115 to Public Classes");
        }
    }
}
