using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool end = false;

    public void WinGame()
    {
        if (end == false)
        {
            end = true;
            Debug.Log("Win");
            Invoke("Restart", 2f);
        }
    }
    public void LoseGame()
    {   
        if (end == false) 
        {
            end = true;
            Debug.Log("Lose");
            Invoke("Restart", 2f);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    } 
}
