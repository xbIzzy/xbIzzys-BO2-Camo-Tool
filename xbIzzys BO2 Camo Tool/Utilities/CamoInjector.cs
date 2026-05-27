using XDevkit;
using JRPC_Client;
using xbIzzys_BO2_Camo_Tool.Utilities.Camos;

namespace xbIzzys_BO2_Camo_Tool.Utilities
{
    public class CamoInjector
    {
        public static IXboxConsole Console;

        public static void InjectCyborg(CyborgCamo Cyborg)
        {
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);

            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Cyborg.Glow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Cyborg.Reveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Cyborg.Rgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Cyborg.Col);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Cyborg.Heat);
        }

        public static void InjectDragon(DragonCamo Dragon)
        {
            Console.WriteByte(0x82FFA04F, 0x03);
            Console.WriteByte(0x82FFA1F7, 0x03);
            Console.WriteByte(0x82FFA61B, 0x03);
            Console.WriteByte(0x82FFA39F, 0x03);
            Console.WriteByte(0x82FFA7C3, 0x03);
            Console.WriteByte(0x82FFA2CB, 0x03);
            Console.WriteByte(0x82FFA6EF, 0x03);
            Console.WriteByte(0x82FFA473, 0x03);

            Console.WriteByte(Console.ReadUInt32(0x82FFA054), Dragon.Ember);
            Console.WriteByte(Console.ReadUInt32(0x82FFA1FC), Dragon.Reveal);
            Console.WriteByte(Console.ReadUInt32(0x82FFA620), Dragon.MtlReveal);
            Console.WriteByte(Console.ReadUInt32(0x82FFA3A4), Dragon.Col);
            Console.WriteByte(Console.ReadUInt32(0x82FFA7C8), Dragon.AltCol);
            Console.WriteByte(Console.ReadUInt32(0x82FFA2D0), Dragon.Rgb);
            Console.WriteByte(Console.ReadUInt32(0x82FFA6F4), Dragon.AltRgb);
            Console.WriteByte(Console.ReadUInt32(0x82FFA478), Dragon.Heat);
        }

        public static void InjectW115(W115Camo W115)
        {
            Console.WriteByte(0xABC69000, W115.Col);

            Console.WriteUInt32(0xA58A7A5C, 0x830C7538);
            Console.WriteUInt32(0xA58A7EA0, 0x830C7538);
            Console.WriteUInt32(0xA58A8280, 0x830C7538);
            Console.WriteUInt32(0xA58A8660, 0x830C7538);
            Console.WriteUInt32(0xA58A8A40, 0x830C7538);
            Console.WriteUInt32(0xA58A8E24, 0x830C7538);
            Console.WriteUInt32(0xA58A9208, 0x830C7538);

            Console.WriteByte(0xA58A80D4, W115.Speed);
            Console.WriteByte(0xA58A8050, W115.Speed);
            Console.WriteByte(0xA58A7CF0, W115.Speed);
            Console.WriteByte(0xA58A7CF4, W115.Speed);
            Console.WriteByte(0xA58A7C70, W115.Speed);
            Console.WriteByte(0xA58A8314, W115.Speed);
            Console.WriteByte(0xA58A7B50, W115.Speed);
            Console.WriteByte(0xA58A7B54, W115.Speed);
            Console.WriteByte(0xA58A84B0, W115.Speed);
            Console.WriteByte(0xA58A86F0, W115.Speed);
            Console.WriteByte(0xA58A8810, W115.Speed);
            Console.WriteByte(0xA58A8890, W115.Speed);
            Console.WriteByte(0xA58A7F30, W115.Speed);
            Console.WriteByte(0xA58A80D0, W115.Speed);
            Console.WriteByte(0xA58A8310, W115.Speed);

            Console.WriteByte(0xA58A7B30, W115.Glow);
            Console.WriteByte(0xA58A7F10, W115.Glow);
            Console.WriteByte(0xA58A82F0, W115.Glow);
            Console.WriteByte(0xA58A86D0, W115.Glow);
        }
    }
}
