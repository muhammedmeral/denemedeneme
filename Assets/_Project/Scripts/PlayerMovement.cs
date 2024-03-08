using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    [SerializeField] private bool isReversed;

    private Vector3 normalToReverse;
    private Vector3 reverseToNormal;

    [SerializeField] private float yOffset  ;

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        this.transform.Translate(Vector3.forward*moveSpeed*Time.fixedDeltaTime);
    }
    public void ReversePlayer()
    {
       
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+yOffset,
                this.transform.position.z);

            Debug.Log("PlayerReversed");
        
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Trap")
        {
            Debug.Log("Ula Engele Çarptýn Hanzo");
        }
    }

}
