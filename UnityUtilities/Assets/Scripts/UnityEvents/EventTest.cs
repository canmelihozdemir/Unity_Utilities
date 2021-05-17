using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityUtilities.EventTest
{
    public class EventTest : MonoBehaviour
    {
        [Serializable]public class OnClickedUnity : UnityEvent { }
        public OnClickedUnity onLeftClickedUnity;
        public OnClickedUnity onRightClickedUnity;

        public delegate void OnClicked();
        public event OnClicked onLeftClicked;
        public event OnClicked onRightClicked;

        private void Start()
        {
            onLeftClicked += PrintLeft;
            onRightClicked += ()=> PrintRight();

            onRightClickedUnity.AddListener(PrintRight);
            //onRightClickedUnity.AddListener(() => {PrintRight(); });
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                onLeftClicked?.Invoke();
                onLeftClickedUnity?.Invoke();
            }
            else if (Input.GetMouseButtonDown(1))
            {
                onRightClicked?.Invoke();
                onRightClickedUnity?.Invoke();

            }
        }

        public void PrintRight()
        {
            Debug.Log("Right");
        }

        public void PrintLeft()
        {
            Debug.Log("Left");
        }
    }
}

