
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    #region Variables

    public GameObject _CellPrefab;

    [HideInInspector]
    public Cell[,] _AllCells = new Cell[8, 8];

    #endregion

    public void Create()
    {
        //board
        for (int y = 0; y < 8; y++) // change the size of the board here
        {
            for (int x = 0; x < 8; x++)
            {
                // Create the cell
                GameObject newCell = Instantiate(_CellPrefab, transform);

                //Position
                RectTransform rectTransform = newCell.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2((x * 100) + 50, (y * 100) + 50);

                //Setup
                _AllCells[x, y] = newCell.GetComponent<Cell>();
                _AllCells[x, y].Setup(new Vector2Int(x, y), this);
            }
        }

        //color
        for (int x = 0; x < 8; x+= 2)
        {

        }
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
