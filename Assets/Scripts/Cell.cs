using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{

    #region variables
    public Image _OutlineImage;

    [HideInInspector]
    public Vector2Int _BoardPosition = Vector2Int.zero; // space to store where the cell is on the board
    [HideInInspector]
    public Board _Board = null;
    [HideInInspector]
    public RectTransform _rectTransform = null;
    #endregion

    public void Setup(Vector2Int newBoardPosition, Board newBoard)
    {
        _BoardPosition = newBoardPosition;
        _Board = newBoard;

        _rectTransform = GetComponent<RectTransform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
