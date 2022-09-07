using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointSysteme : MonoBehaviour
{
    public Text MyScore;


    int score = 0;

    void Start()
    {
        MyScore.text = "SCORE : " + score.ToString();
        Rigidbody rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject)
        {
            AddScore();
        } 
        if (score == 10)
        {
            FindObjectOfType<GameManager>().WinGame();
        }
    }
    void AddScore()
    {
        score++;
        MyScore.text = "SCORE : " + score.ToString();
    }
}
