using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Draw {
    [ExecuteInEditMode]
    public class DrawMono_ExecuteInEditorAndUpdateTick : MonoBehaviour {

        public UnityEvent m_onTick;
        public void Update()
        {
            if (enabled == false) return;
            m_onTick?.Invoke();
        }
    }
}

