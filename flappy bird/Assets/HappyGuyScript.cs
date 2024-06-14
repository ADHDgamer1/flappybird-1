using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyGuyScript : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float FlapStrength;
    public LogicScript Logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            MyRigidBody.velocity = Vector2.up * FlapStrength;
        }

    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameOver();
        birdIsAlive = false;
    }   
}
