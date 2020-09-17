using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public float restartDelay = 1.5f;

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void endGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
