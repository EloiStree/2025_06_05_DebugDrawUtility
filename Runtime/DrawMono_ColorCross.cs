using UnityEngine;


namespace Eloi.Draw {


    [ExecuteInEditMode]
    public class DrawMono_ColorCross : MonoBehaviour
    {

        private void Reset()
        {
            m_target = transform;
            m_radius = 1f;
            m_space = Space.Self;
            m_color = Color.pink;
        }
        public Transform m_target;
        public float m_radius = 1f;
        public Space m_space = Space.Self;
        public Color m_color = Color.pink;
        void Update()
        {
            if(enabled == false) return;

            if (m_target == null) return;
            DebugDrawUility.Cross(m_target, m_color, m_radius, m_space);
        }
    }



}

