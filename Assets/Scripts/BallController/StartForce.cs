using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartForce : MonoBehaviour
{
    public Vector3 startForce;
    private Rigidbody rb;
    void Start()
    {   
        // Balle avance vers l'avant en continue
        rb = GetComponent<Rigidbody>();
        rb.AddForce(startForce, ForceMode.Impulse);

        
    }
    void FixedUpdate()
    {
        if (rb.position.y < 2f)
        {
            FindObjectOfType<GameManager>().LoseGame();
        }
    }
   
}
