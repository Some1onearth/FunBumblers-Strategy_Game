using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunWoo
{
    public class GameManager : MonoBehaviour
    {
        #region Variables

        public static bool playerTurn;

        #endregion

        private static void Start()
        {
            playerTurn = false;
        }
    }

}