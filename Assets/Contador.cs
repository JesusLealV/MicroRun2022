using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Contador : MonoBehaviour  
{  
    private Rigidbody rb;
    public float velocidad;
  private int puntuacion;

    public Text pts;
    public Text gantast; 

    
    
    void Awake()
    {
        puntuacion = 0;
        gantast.gameObject.SetActive(false);

    } 
 
    // Start is called before the first frame update
    void Start()
    {   
        rb=GetComponent<Rigidbody>();

        actualizarPts();
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter( Collider obj)
    {       
        
        obj.gameObject.SetActive(false);
        puntuacion ++;
       actualizarPts ();
       if ( puntuacion >= 2 )
       {
             gantast.gameObject.SetActive(true);
       }
    }

    void actualizarPts()
    {
        pts.text = "$"   + puntuacion.ToString();
    }
}
