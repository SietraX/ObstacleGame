using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    int hitCounter = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            hitCounter++;
            if (hitCounter == 3)
            {
                Debug.Log("You've bumped into the obstacles " + hitCounter + " times and game is restarted.");
                RestartTheGame();
                hitCounter = 0;
            }
            else
            {
                Debug.Log("You've bumped into the obstacles " + hitCounter + " times.");
            }
        }
        else if (other.gameObject.tag == "Finish")
        {
            Debug.Log("Congrulations, you finished the level!");
        }
    }

    private void RestartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
