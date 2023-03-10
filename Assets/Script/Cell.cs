using System;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.Serialization;

public enum CellType
{
    blank,number,id
}
public class Cell : MonoBehaviour
{
    [FormerlySerializedAs("CellNumber")] [SerializeField]
    private int _cellNumber = 0;

    private Color _numberCellColor;
    private Color _numberTextColor;
    private Color _ıdNumberCellColor;
    private Color _ıdNumberTextColor;

    public Color NumberCellColor
    {
        get
        {
            return _numberCellColor;
        }
        set
        {
            _numberCellColor = value;
        }
    }
    public Color NumberTextColor
    {
        get
        {
            return _numberTextColor;
        }
        set
        {
            _numberTextColor = value;
        }
    }
    public Color IdNumberCellColor
    {
        get
        {
            return _ıdNumberCellColor;
        }
        set
        {
            _ıdNumberCellColor = value;
        }
    }
    public Color IdNumberTextColor
    {
        get
        {
            return _ıdNumberTextColor;
        }
        set
        {
            _ıdNumberTextColor = value;
        }
    }

    [SerializeField] private CellType _cellType = CellType.blank;

    public CellType MyCellType
    {
        get
        {
            return _cellType;
        }
    }

    public int CellNumber
    {
        get
        {
            return _cellNumber;
        }
    }

    private SpriteRenderer _spriteRenderer;
    private TextMesh _textMesh;

    private void OnDrawGizmos()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _textMesh = GetComponentInChildren<TextMesh>();
        if (_cellType == CellType.number)
        {
            _textMesh.text = _cellNumber.ToString();
            _textMesh.color = _numberTextColor;
            _spriteRenderer.color = _numberCellColor;
            _spriteRenderer.enabled = true;
        }
        
        if (_cellType == CellType.blank)
        {
            _textMesh.text = "";
            _spriteRenderer.enabled = false;
        }
        
        if (_cellType == CellType.id)
        {
            _textMesh.color = _ıdNumberTextColor;
            _spriteRenderer.color = _ıdNumberCellColor;
            _spriteRenderer.enabled = true;
        }
    }

    public void Mark()
    {
        //_spriteRenderer.color=Color.black;
        //_spriteRenderer.enabled = false;
        this.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _textMesh = GetComponentInChildren<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Reset()
    {
        this.gameObject.SetActive(true);
    }
}
