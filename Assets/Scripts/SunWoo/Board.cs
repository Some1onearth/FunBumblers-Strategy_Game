using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunWoo
{
    public class Board : MonoBehaviour
    {
        #region Variables

        [SerializeField] private int boardWidth;
        [SerializeField] private int boardHeight;
        [SerializeField] private GameObject[] objects;
        [SerializeField] public GameObject[,] board;
        [SerializeField] private GameObject player;

        #endregion

        private void Start()
        {
            BoardTo2DArray();
            PrintBoard();
        }

        private void Update()
        {
            UpdateBoard();
        }

        private void BoardTo2DArray()
        {
            board = new GameObject[boardWidth, boardHeight];

            int i = 0;
            for (int y = 0; y < boardHeight; y++)
            {
                for (int x = 0; x < boardWidth; x++)
                {
                    board[x, y] = objects[i];
                    i++;
                }
            }
        }

        private void UpdateBoard()
        {
            for (int y = 0; y < boardHeight; y++)
            {
                for (int x = 0; x < boardWidth; x++)
                {
                    if (Mathf.Abs(player.GetComponent<Player>().position.x - x) == Mathf.Abs(player.GetComponent<Player>().position.y - y))
                    {
                        if (Mathf.Abs(player.GetComponent<Player>().position.x - x) <= player.GetComponent<Player>().stepDistance)
                        {
                            board[x, y].GetComponent<Cell>().inRange = true;
                        }
                    }
                    else if (Mathf.Abs(player.GetComponent<Player>().position.x - x) <= player.GetComponent<Player>().stepDistance && Mathf.Abs(player.GetComponent<Player>().position.y - y) == 0)
                    {
                        board[x, y].GetComponent<Cell>().inRange = true;
                    }
                    else if (Mathf.Abs(player.GetComponent<Player>().position.x - x) == 0 && Mathf.Abs(player.GetComponent<Player>().position.y - y) <= player.GetComponent<Player>().stepDistance)
                    {
                        board[x, y].GetComponent<Cell>().inRange = true;
                    }
                }
            }
        }

        private void PrintBoard()
        {
            foreach (var b in board)
            {
                Debug.Log(b.name);
            }
        }
    }

}