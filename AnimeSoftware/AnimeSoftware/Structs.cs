using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class Structs
    {
        public static readonly int[] SpamWeaponList = new int[]{ 4,9,10,11,38,40,64,262208 };
        public static Dictionary<int, string> Hitbox = new Dictionary<int, string>
        {
            [8] = "Head",
            [7] = "Neck",
            [6] = "Body"
        };
    }

    public enum Hitbox
    {
        HEAD = 8,
        NECK = 7,
        BODY = 6
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CharCodes
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public int[] tab;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct player_info_s
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public char[] __pad0;
        public int m_nXuidLow;
        public int m_nXuidHigh;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] m_szPlayerName;
        public int m_nUserID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
        public char[] m_szSteamID;
        public uint m_nSteam3ID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] m_szFriendsName;
        [MarshalAs(UnmanagedType.U1, SizeConst = 1)]
        public bool m_bIsFakePlayer;
        [MarshalAs(UnmanagedType.U1, SizeConst = 1)]
        public bool m_bIsHLTV;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] m_dwCustomFiles;
        public char m_FilesDownloaded;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GlowSettings
    {
        byte renderWhenOccluded;
        byte renderWhenUnoccluded;
        byte fullBloomRender;

        public GlowSettings(bool __renderWhenOccluded, bool __renderWhenUnoccluded, bool __fullBloom)
        {
            renderWhenOccluded = __renderWhenOccluded == true ? (byte)1 : (byte)0;
            renderWhenUnoccluded = __renderWhenUnoccluded == true ? (byte)1 : (byte)0;
            fullBloomRender = __fullBloom == true ? (byte)1 : (byte)0;
        }
    }

    public struct GlowColor
    {
        public float r;
        public float g;
        public float b;
        public float a;
        public GlowColor(Color color)
        {
            r = color.R / 255f;
            g = color.G / 255f;
            b = color.B / 255f;
            a = color.A / 255f;
        }
        public GlowColor(float _r,float _g,float _b, float _a)
        {
            r = _r;
            g = _g;
            b = _b;
            a = _a;
        }
        public static Color operator *(GlowColor a, int b)
        {
            return Color.FromArgb((int)a.a*b, (int)a.r * b, (int)a.g * b, (int)a.b * b);
        }
        public Color ToColor
        {
            get
            {
                return Color.FromArgb((int)(a*255), (int)(r *255), (int)(g *255), (int)(b *255));
            }
        }
    }
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public float Length
        {
            get
            {
                return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
            }
        }
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static Vector3 operator /(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static Vector3 operator *(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static Vector3 operator /(Vector3 a, int b)
        {
            return new Vector3(a.x / b, a.y / b, a.z / b);
        }
        public static Vector3 operator *(Vector3 a, int b)
        {
            return new Vector3(a.x * b, a.y * b, a.z * b);
        }
        public static Vector3 operator /(Vector3 a, float b)
        {
            return new Vector3(a.x / b, a.y / b, a.z / b);
        }
        public static Vector3 operator *(Vector3 a, float b)
        {
            return new Vector3(a.x * b, a.y * b, a.z * b);
        }
    }
}
