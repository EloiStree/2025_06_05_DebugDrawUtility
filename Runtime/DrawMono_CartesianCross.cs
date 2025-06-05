using UnityEngine;


namespace Eloi.Draw {


    [ExecuteInEditMode]
    public class DrawMono_CartesianCross : MonoBehaviour
    {

        private void Reset()
        {
            if (m_target == null)
            {
                m_target = transform;
            }
        }
        public Transform m_target;
        public float m_radiusPositive = 1f;
        public float m_radiusNegative = 0.1f;
        public Space m_space = Space.Self;
        void Update()
        {

            if (enabled == false) return;
            DebugDrawUility.CartersianCross(m_target, m_radiusPositive, m_radiusNegative, m_space);
        }

    }



}

