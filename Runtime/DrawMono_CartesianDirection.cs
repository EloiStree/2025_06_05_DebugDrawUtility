using UnityEngine;


namespace Eloi.Draw {
    [ExecuteInEditMode]
    public class DrawMono_CartesianDirection : MonoBehaviour
    {
        private void Reset()
        {
            m_cartesianReference = transform;
            foreach (Transform child in transform)
            {
                    m_point = child;
               
            }
        }

        public Transform m_cartesianReference;
        public Transform m_point;
        public float m_cartesianRadius = 1f;
        public Space m_space = Space.Self;
        public Color m_lineColor = Color.yellow;
        public bool m_useNormalizedDirection = true;
        void Update()
        {
            if (enabled == false) return;
            DebugDrawUility.Cartesian(m_cartesianReference, m_cartesianRadius, m_space);

            if (m_point != null)
            {
                Vector3 direction = m_point.position - m_cartesianReference.position;

                if (m_useNormalizedDirection)
                    Debug.DrawLine(m_cartesianReference.position, m_cartesianReference.position + direction.normalized, m_lineColor);
                else
                    Debug.DrawLine(m_cartesianReference.position, m_point.position, m_lineColor);
            }

            
        }
    }

}

