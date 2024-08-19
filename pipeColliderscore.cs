using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class pipeColliderscore : MonoBehaviour
{
    public AudioSource scoreSound;
    public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            scoreSound.Play();

        }
        
    }
}
