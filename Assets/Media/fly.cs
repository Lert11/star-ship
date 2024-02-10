using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.WSA;

public class fly : MonoBehaviour
{
    Rigidbody rigiss;
    AudioSource Starship;
    // Start is called before the first frame update
    void Start()
    {
        Starship = GetComponent<AudioSource>();
        rigiss = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
            rinput();
            Launch();
    }
    void Launch()
        {
            if (Input.GetKey(KeyCode.Space))
            { 
              print("press space");
              //rigiss.AddForce(Vector3.up);
              rigiss.AddRelativeForce(Vector3.up*10);
              if (!Starship.isPlaying)
                {
                    Starship.Play();
                }
            }
            else
                 {
                   Starship.Pause();

                 }           
        }
    void rinput()
    {
        
        if (Input.GetKey(KeyCode.Q))
        {

            print("press Q");
            rigiss.AddRelativeTorque(new Vector3(0,0,-0.5f));
            
        }
        if (Input.GetKey(KeyCode.E))
        {

            print("press e");
            rigiss.AddRelativeTorque(new Vector3(0, 0, 0.5f));
            
            
        }
        if (Input.GetKey(KeyCode.S))
        {

            print("press S");
            rigiss.AddRelativeTorque(new Vector3 (0.5f,0,0));
           

        }
        if (Input.GetKey(KeyCode.W))
        {

            print("press W");
            rigiss.AddRelativeTorque(new Vector3(-0.5f,0,0));
            
        }
       // rigiss.freezeRotation = true;
    }
}
