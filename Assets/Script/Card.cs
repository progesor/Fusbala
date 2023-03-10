using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField]
    private int CardNumber;

    public List<Cell> NumberCell;

    public Color NumberCellColor;
    public Color NumberTextColor;
    public Color IdNumberCellColor;
    public Color IdNumberTextColor;

    private void OnDrawGizmos()
    {
        Cell[] asd = GetComponentsInChildren<Cell>();

        foreach (Cell c in asd)
        {
            if (c.MyCellType==CellType.id)
            {
                c.gameObject.GetComponentInChildren<TextMesh>().text = CardNumber.ToString();
                c.IdNumberCellColor = IdNumberCellColor;
                c.IdNumberTextColor = IdNumberTextColor;
            }

            if (c.MyCellType==CellType.number)
            {
                c.NumberTextColor = NumberTextColor;
                c.NumberCellColor = NumberCellColor;
            }
        }
    }
    private void ChckNumbers(int number)
    {
        foreach (Cell c in NumberCell)
        {
            if (c.CellNumber==number)
            {
                c.Mark();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        BallManager.curent.onBallSelected+=CurentOnonBallSelected;
        FindAllNumberCell();
    }

    private void CurentOnonBallSelected(int obj)
    {
        ChckNumbers(obj);
    }

    private void FindAllNumberCell()
    {
        Cell[] cells = GetComponentsInChildren<Cell>();

        foreach (Cell c in cells)
        {
            if (c.MyCellType==CellType.number)
            {
                NumberCell.Add(c);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        foreach (Cell c in NumberCell)
        {
            c.Reset();
        }
    }
}
