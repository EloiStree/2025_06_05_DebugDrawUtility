using UnityEngine;


namespace Eloi.Draw {

    [ExecuteInEditMode]
    public class DrawMono_CameraView : MonoBehaviour
    {
        private void Reset()
        {
            m_target = Camera.main;
        }
        public Camera m_target;
        public bool m_useMainIfNull = true;
        public Color m_colorNear= Color.green;
        public Color m_colorLine=Color.yellow;
        public Color m_colorFar = Color.green;
        void Update()
        {
            if (enabled == false) return;
            if (m_target == null && m_useMainIfNull)
            {
                m_target = Camera.main;
            }
            DebugDrawUility.CameraView(m_target, m_colorNear, m_colorLine, m_colorFar,0 );
        }
    }

}

