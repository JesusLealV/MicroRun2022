using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
     public float velocidad_actual = 0.0f;
    public float velocidad_imp = 0.03f;
    public float velocidad_max = 1.0f;
    public float rot_actual = 0.0f;
    public float vel_rot = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {   velocidad_actual  +=    velocidad_imp;  
            if (velocidad_actual > velocidad_max)
                { velocidad_actual = velocidad_max;
                }
            
        } 

       // if (Input.GetKeyUp(KeyCode.W))
        {
            velocidad_actual -= velocidad_imp;
          if  (velocidad_actual < 0)
          {
            velocidad_actual = 0;
          }

        }

       if (Input.GetKeyDown(KeyCode.A)) 
         {
            rot_actual = -vel_rot;
         }
       // else if (Input.GetKeyUp(KeyCode.A))
        {
            rot_actual = 0.0f;
        }
         
        if (Input.GetKeyDown(KeyCode.D)) 
         {
            rot_actual = vel_rot;
         }

         
      //  else if (Input.GetKeyUp(KeyCode.D))
        {
            rot_actual = 0.0f;
        }
    //GetComponent<Rigidbody> (). AddForce ( transform.forward * velocidad_actual, ForceMode.Impulse);
    //GetComponent <Rigidbody> (). AddTorque (0,rot_actual, 0,ForceMode.Impulse);
    

}
}
