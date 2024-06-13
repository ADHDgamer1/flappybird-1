using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyGuyScript : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float FlapStrength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        { MyRigidBody.velocity = Vector2.up * FlapStrength;
        }
    }   
}