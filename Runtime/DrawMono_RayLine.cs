using UnityEngine;


namespace Eloi.Draw {

    [ExecuteInEditMode]
    public class DrawMono_RayLine : MonoBehaviour
    {

        private void Reset()
        {
            if (m_target == null)
            {
                m_target = transform;
            }
            m_axis = Vector3.forward;
            m_radiusMultiplicator = 1f;
            m_space = Space.Self;
        }
        public Transform m_target;
        public Vector3 m_axis;
        public float m_radiusMultiplicator = 1f;
        public Space m_space = Space.Self;
        public Color m_color = Color.green;
        void Update()
        {
            if (enabled == false) return;
            if (m_target == null) return;
            DebugDrawUility.RayLine(m_target, m_axis, m_radiusMultiplicator, m_space, m_color);
        }
    }



}

