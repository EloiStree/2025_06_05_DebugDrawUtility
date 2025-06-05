using UnityEngine;


namespace Eloi.Draw {




    [ExecuteInEditMode]
    public class DrawMono_Cartesian : MonoBehaviour
    {
        private void Reset()
        {
            m_target = transform;
            m_radius = 1f;
            m_space = Space.Self;
        }

        public Transform m_target;
        public float m_radius = 1f;
        public Space m_space = Space.Self;
        void Update()
        {
            if (enabled == false) return;
            DebugDrawUility.Cartesian(m_target, m_radius, m_space);
        }
    }

}

