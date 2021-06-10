using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    private int score;

    public float timeLeft;

    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        timeLeft = 10f; 

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            score++; 
        }

        timeLeft = timeLeft - Time.deltaTime;
        
        if(timeLeft< 0)
        {
            SceneManager.LoadScene("Sala Final");
        }
    }
}
