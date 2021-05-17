using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtilities.Scriptable_Object
{
    [CreateAssetMenu(fileName ="New ScriptableObject",menuName = "Player Type")]
    public class PlayerType : ScriptableObject
    {
        public Color playerColor = Color.black;
        public float playerSpeed = 10f;
        public Vector3 playerScale = Vector3.one;
        
    }
}

