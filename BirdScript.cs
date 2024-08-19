using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float fuerzaDevolar;
    public LogicScript logic;
    public AudioSource jumpSound;
    public Animator animation;
    public PipeSpawn playerReady;
    public GameObject clickSprite;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetMouseButtonDown(0) == true && logic.dead == false)
        {
           
            myRigidbody.velocity = Vector2.up * fuerzaDevolar;
            jumpSound.Play();
           
            myRigidbody.gravityScale = 2;
            playerReady.BirdReady();
            clickSprite.SetActive(false);
        }
       
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        
    }
}
