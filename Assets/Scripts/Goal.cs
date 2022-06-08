using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int score;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Destroy(gameObject);
            ScoreScript.scoreValue += score;
            Debug.Log("You gain " + score);
        }
    }
}
