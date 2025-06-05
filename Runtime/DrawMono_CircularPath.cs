using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


namespace Eloi.Draw
{
    [ExecuteInEditMode]
    public class DrawMono_CircularPath : DrawMono_AbstractDefault
    {

        private void Reset()
        {
            if (m_targets == null || m_targets.Count == 0)
            {
                m_targets = new List<Transform>();
                foreach (Transform child in transform)
                {
                    m_targets.Add(child);
                }
            }
        }
        public List<Transform> m_targets;
        public Color m_color = Color.green;
       

        public override void DrawForSeconds(float seconds)
        {
            if (m_targets == null || m_targets.Count == 0)
            {
                return;
            }
            DebugDrawUility.CircularPath(m_targets, m_color);
        }
    }


}

