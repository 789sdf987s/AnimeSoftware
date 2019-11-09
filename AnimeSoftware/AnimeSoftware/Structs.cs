using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class Structs
    {
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
    }
}
