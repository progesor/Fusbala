using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallsBoard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BallManager.curent.onBallSelected+=CurentOnonBallSelected;
    }

    private void CurentOnonBallSelected(int obj)
    {
        ShowBall(obj);
    }

    private void ShowBall(int Number)
    {
        var ffff=this.transform.Find("ballsSmall_" + (Number - 1));
       //Debug.Log(ffff);
        ffff.GameObject().SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        for (int i = 0; i < 90; i++)
        {
            var ffff=this.transform.Find("ballsSmall_" + (i));
            ffff.GameObject().SetActive(false);
        }
        
    }
}
