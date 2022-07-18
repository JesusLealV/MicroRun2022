using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public   GameObject Player;
    public   GameObject child;
    public   float      speed;

    // Start is called before the first frame update
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        child  = Player.transform.Find("camera constraint").gameObject;

    }

    private void FixedUpdate()
    {
        follow();
    }

    // Update is called once per frame
    private void follow()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position,child.transform.position,Time.deltaTime*speed);
        gameObject.transform.LookAt(Player.gameObject.transform.position);
        
            
        
    }
}
