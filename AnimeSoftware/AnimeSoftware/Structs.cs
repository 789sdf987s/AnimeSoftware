using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class Structs
    {
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
    }
}
