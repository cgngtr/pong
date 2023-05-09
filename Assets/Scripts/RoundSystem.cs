using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundSystem : MonoBehaviour
{
    private SceneController SceneController;
    int scoreRight = 0;
    int scoreLeft = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("goalpostleft"))
        {
            scoreRight++;
            Debug.Log(scoreRight);
            SceneController.nextRound();
        }
        if (collision.gameObject.CompareTag("goalpostright"))
        {
            scoreLeft++;
            Debug.Log(scoreLeft);
            SceneController.nextRound();
        }
    }

}