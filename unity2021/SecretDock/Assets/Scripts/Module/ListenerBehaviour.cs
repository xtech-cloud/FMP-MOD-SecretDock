using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace XTC.FMP.MOD.SecretDock.LIB.Unity
{
    public class ListenerBehaviour : MonoBehaviour
    {
        public float tickTime = 0.5f;
        public int wakeCount = 10;
        public int x = 1820;
        public int y = 0;
        public int width = 100;
        public int height = 100;
        public Action onTrigger;

        private int count_ = 0;
        private float timer_ = 0;
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                handleClick(Input.mousePosition);
            }
            for (int i = 0; i < Input.touchCount; i++)
            {
                var position = Input.GetTouch(i).position;
                handleClick(position);
            }
        }

        private void handleClick(Vector2 _position)
        {
            bool inRect = _position.x > x && _position.x < x + width && _position.y > y && _position.y < y + height;
            if (!inRect)
                return;
            if (Time.realtimeSinceStartup - timer_ > tickTime)
            {
                timer_ = 0;
                count_ = 0;
            }
            if (count_ > wakeCount)
                return;
            timer_ = Time.realtimeSinceStartup;
            count_ += 1;
            if (count_ > wakeCount)
                onTrigger();
        }
    }
}
