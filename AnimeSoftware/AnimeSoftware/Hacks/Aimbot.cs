using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeSoftware
{
    class Aimbot
    {
        public static Vector3 CalcAngle(Vector3 src, Vector3 dst)
        {
            Vector3 angles = new Vector3 { x = 0, y = 0, z = 0 };
            double[] delta = { (src.x - dst.x), (src.y - dst.y), (src.z - dst.z) };
            float hyp = (float)Math.Sqrt(delta[0] * delta[0] + delta[1] * delta[1] + delta[2] * delta[2]);
            angles.x = (float)(Math.Atan(delta[2] / hyp) * 180.0f / Math.PI);
            angles.y = (float)(Math.Atan(delta[1] / delta[0]) * 180.0f / Math.PI);
            if (delta[0] >= 0.0f)
            {
                angles.y += 180.0f;
            }
            return angles;
        }
        
        public static Entity BestDistance()
        {
            int Index=-1;
            float bestDistance = 999999f, tmpDistance;
            foreach(Entity x in Entity.List())
            {
                if (x.Health <= 0)
                    continue;
                if ((tmpDistance = x.DistanceToPlayer) < bestDistance)
                {
                    bestDistance = tmpDistance;
                    Index = x.Index;
                }
            }
            return new Entity(Index);
        }


        public static Vector3 NormalizedAngle(Vector3 src)
        {
            while (src.x > 89.0f)
                src.x -= 180.0f;

            while (src.x < -89.0f)
                src.x += 180.0f;

            while (src.y > 180.0f)
                src.y -= 360.0f;

            while (src.y < -180.0f)
                src.y += 360.0f;

            if (src.y < -180.0f || src.y > 180.0f)
                src.y = 0.0f;

            if (src.x < -89.0f || src.x > 89.0f)
                src.x = 0.0f;

            return src;
        }
    }
}
