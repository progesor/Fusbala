using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public static BallManager curent;

    private void Awake()
    {
        curent = this;
    }

    public event Action<int> onBallSelected;

    public void BallSelected(int ballNumber)
    {
        if (onBallSelected!=null)
        {
            onBallSelected(ballNumber);
        }
    }

    public List<int> balls;
    
    // Start is called before the first frame update
    void Start()
    {
        BallManager.curent.onBallSelected+=CurentOnonBallSelected;
        balls = new List<int>();
    }

    private void CurentOnonBallSelected(int obj)
    {
        balls.Add(obj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
