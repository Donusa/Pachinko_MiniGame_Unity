using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class IncrementPoints : MonoBehaviour
{
    score Score;
    public int coins;
    public Text text;

    public void Awake()
    {
        Score = GameObject.Find("Text").GetComponent<score>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Score.points += coins;
    }

}
