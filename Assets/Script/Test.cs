using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class Test : MonoBehaviour
{
    public int maxBallNumber = 90;
    public List<Sprite> allSpriteNumbers = new List<Sprite>();
    private int drawIndex = 0;
    public int CurrentNumber = 0;
    private SpriteRenderer myRenderer;
    public bool canDrawn = false;
    private float lastDraw;
    public float drawnSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

        lastDraw = Time.time;
        myRenderer = GetComponent<SpriteRenderer>();
        Sprite[] ballImages = Resources.LoadAll<Sprite>("Images/ballsBig");
        allSpriteNumbers.AddRange(ballImages);
        Shuffle(allSpriteNumbers);
    }

    

    // Update is called once per frame
    void Update()
    {
        if (canDrawn)
        {
            if (Time.time-lastDraw>drawnSpeed)
            {
                DrawBall();
                lastDraw = Time.time;
            }
        }
    }

    public void DrawBall()
    {
        if (drawIndex >= maxBallNumber) return;
        var asd = allSpriteNumbers[drawIndex];
        myRenderer.sprite=allSpriteNumbers[drawIndex];
        CurrentNumber = Convert.ToInt32(asd.name.Replace("ballsBig_", ""))+1;
        BallManager.curent.BallSelected(CurrentNumber);
        drawIndex++;
    }


    public static void Shuffle<T>(IList<T> list)
    {
        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
        int n = list.Count;
        while (n > 1)
        {
            byte[] box = new byte[1];
            do provider.GetBytes(box);
            while (!(box[0] < n * (Byte.MaxValue / n)));
            int k = (box[0] % n);
            n--;
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public void Reset()
    {
        Shuffle(allSpriteNumbers);
        drawIndex = 0;
        CurrentNumber = 0;
    }
}
