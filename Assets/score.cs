using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    public int points;
    public Text scoreText;
    void Start()
    {
        points = 0;
    }

    private void Update()
    {
        scoreText.text = points.ToString();
        
    }

}
