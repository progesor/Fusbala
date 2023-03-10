using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UiManager : MonoBehaviour
{

    public GameObject Cards;
    public Test Top;
    public BallsBoard BallsBoard;
    public Canvas PlayerName;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleCard ()
    {
        if (Cards.transform.position.z==-1)
        {
            Cards.transform.position=Vector3.forward;
            PlayerName.enabled = false;
        }
        else
        {
            Cards.transform.position=Vector3.back;
            PlayerName.enabled = true;
        }
    }

    public void ToggleDraw()
    {
        if (Top.canDrawn)
        {
            Top.canDrawn = false;
        }
        else
        {
            Top.canDrawn = true;
        }
    }

    public void SetDrawSpeed(float value)
    {
        Top.drawnSpeed = value;
    }

    public void DrawBall()
    {
        Top.DrawBall();
    }

    public void NewGame()
    {
        Top.Reset();
        BallsBoard.Reset();
        
        Card[] cards = FindObjectsOfType<Card>();

        foreach (Card c in cards)
        {
            c.Reset();
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
