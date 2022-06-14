using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunWoo
{
    public class Player : MonoBehaviour
    {
        #region Variables

        public Vector2 position;
        public int stepDistance;

        #endregion

        private void Start()
        {
            stepDistance = 2;
            position = new Vector2(3, 3);
        }
    }
}