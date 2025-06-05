using UnityEngine;
using static UnityEngine.GraphicsBuffer;


namespace Eloi.Draw
{
    [ExecuteInEditMode]
    public class DrawMono_CenterToCorner : DrawMono_AbstractDefault
    {
        private void Reset()
        {
            m_center = transform;
        }

        public Transform m_center;
        public Transform m_corner;
        public Color m_color = Color.red; 


        public override void DrawForSeconds(float seconds)
        {
            if (m_center == null)
            {
                return;
            }
            if (m_corner == null)
            {
                return;
            }
            DebugDrawUility.CenterToCorner(m_center, m_corner, m_color, 0);
        }
    }

}

