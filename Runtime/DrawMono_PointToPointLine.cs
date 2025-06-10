using UnityEngine;


namespace Eloi.Draw
{
    [ExecuteInEditMode]
    public class DrawMono_PointToPointLine : DrawMono_AbstractDefault
    {
        public Transform m_startPoint;
        public Transform m_endPoint;
        public Color m_color = Color.yellow;
        private void Reset()
        {

            m_startPoint = transform;
        }

        public override void DrawForSeconds(float seconds)
        {
            if (m_startPoint == null || m_endPoint ==null)
            {
                return;
            }
            DebugDrawUility.DrawLine(m_startPoint.position, m_endPoint.position, m_color,seconds);
        }


    }


}

