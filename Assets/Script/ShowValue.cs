using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowValue : MonoBehaviour
{
    private TextMeshProUGUI _textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetValue(float value)
    {
        _textMeshPro.text = value.ToString("0.00")+" Saniye";
    }
}
