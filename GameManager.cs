using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public void Endgame()
    {
        if(gamehasended == false)
        {
            gamehasended=true;
            Invoke("restart",2f);
        }

    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
