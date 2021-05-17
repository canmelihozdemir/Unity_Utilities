using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtilities.Scriptable_Object
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerType _playerType = null;

        private void Update()
        {
            GetComponent<Renderer>().material.color = _playerType.playerColor;
            transform.localScale = _playerType.playerScale;

        }
    }
}

