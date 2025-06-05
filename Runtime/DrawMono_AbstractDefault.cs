using UnityEngine;


namespace Eloi.Draw {
    [ExecuteInEditMode]
    public abstract class DrawMono_AbstractDefault : MonoBehaviour
    {


        [ContextMenu("Draw")]
        public void DrawForDeltaTime() { 
        
            DrawForSeconds(Time.deltaTime);
        }

        [ContextMenu("Draw 1 second")]
        public void DrawForOneSecond() => DrawForSeconds(1f);
        [ContextMenu("Draw 10 seconds")]
        public void DrawForTenSeconds() => DrawForSeconds(10f);


        public abstract void DrawForSeconds(float seconds);

        public void Update()
        {
            if (enabled == false) return;
            DrawForSeconds(Time.deltaTime);
        }
    }



}

