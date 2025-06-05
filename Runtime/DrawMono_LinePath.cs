using System.Collections.Generic;
using UnityEngine;


namespace Eloi.Draw
{
    [ExecuteInEditMode]
    public class DrawMono_LinePath : MonoBehaviour
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
        void Update()
        {
            if (enabled == false) return;
            if (m_targets == null || m_targets.Count == 0)
            {
                return;
            }
            DebugDrawUility.LinePath(m_targets, m_color);
        }
    }


}

