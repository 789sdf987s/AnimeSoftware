using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using hazedumper;

namespace AnimeSoftware
{
    class LocalPlayer : IDisposable
    {
        public void Dispose()
        {

        }
        public static int Ptr
        {
            get
            {
                return Memory.Read<int>(Memory.Client + signatures.dwLocalPlayer);
            }
        }

        public static Vector3 Position
        {
            get
            {
                Vector3 position = Memory.Read<Vector3>(Ptr + netvars.m_vecOrigin);
                return position;
            }
        }
        public static Vector3 Velocity
        {
            get
            {
                Vector3 velocity = Memory.Read<Vector3>(Ptr + netvars.m_vecVelocity);
                return velocity;
            }
        }

        public static void Jump()
        {
            Memory.Write<int>(Memory.Client + signatures.dwForceJump, 5);
            Thread.Sleep(20);
            Memory.Write<int>(Memory.Client + signatures.dwForceJump, 4);
        }
        public static int Flags
        {
            get
            {
                return Memory.Read<int>(Ptr + netvars.m_fFlags);
            }
        }
        public static float Speed
        {
            get
            {
                Vector3 velocity = Velocity;
                float result = (float)Math.Sqrt(velocity.x * velocity.x + velocity.y * velocity.y + velocity.z * velocity.z);
                return result;
            }
        }

        public static bool InGame
        {
            get
            {
                int ClientState = Memory.Read<int>(Memory.Engine + signatures.dwClientState);
                return Memory.Read<int>(ClientState + signatures.dwClientState_State) == 6;
            }
        }
        public static int Health
        {
            get
            {
                return Memory.Read<int>(Ptr + netvars.m_iHealth);
            }
        }
        public static Vector3 ViewPosition
        {
            get
            {
                Vector3 position = Position;
                position.z += Memory.Read<float>(Ptr + netvars.m_vecViewOffset + 0x8);
                return position;
            }
        }

        public static Vector3 ViewAngle
        {
            get
            {
                int ClientState = Memory.Read<Int32>(Memory.Engine + signatures.dwClientState);

                Vector3 viewAngles = Memory.Read<Vector3>(ClientState + signatures.dwClientState_ViewAngles);
                return viewAngles;
            }
            set
            {
                int ClientState = Memory.Read<Int32>(Memory.Engine + signatures.dwClientState);

                Memory.Write<Vector3>(ClientState + signatures.dwClientState_ViewAngles, value);
            }
        }
        public static float ViewAngleY
        {
            set
            {
                int ClientState = Memory.Read<Int32>(Memory.Engine + signatures.dwClientState);

                Memory.Write<float>(ClientState + signatures.dwClientState_ViewAngles + 0x4, value);
            }
        }
    }
}
