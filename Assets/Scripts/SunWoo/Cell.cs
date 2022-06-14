using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SunWoo
{
    public class Cell : MonoBehaviour
    {
        #region Variables

        public bool inRange;
        [SerializeField] private GameObject player;

        #endregion

        public void OnMouseDown()
        {
            Debug.Log("Click");
            if (GameManager.playerTurn)
            {
                // Check if the player can move to this cell
                if (true)
                {
                    // Move to this cell
                    MovePlayer();
                }
            }
        }

        public void OnMouseOver()
        {
            Debug.Log("enter");
            // Check if the cell is in range
            if (inRange)
            {
                // Highlight the cell
                GetComponent<SpriteRenderer>().color = new Color32(200, 255, 200, 255);
            }
        }

        private void MovePlayer()
        {
            player.transform.position = transform.position;
        }

        public void OnMouseExit()
        {
            Debug.Log("exit");
            // Unhighlight the cell
            GetComponent<SpriteRenderer>().color = new Color32(0, 255, 0, 255);
        }
    }

}