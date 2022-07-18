using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour  
{  
    
    private int puntuacion;
    public Text pts;
    
    
    void Awake()
    {
        puntuacion = 0;

    }

    // Start is called before the first frame update
    void Start()
    {
        actualizarPts();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTiggerEnter( bOXCollider obj)
    {
        obj.gameObejct.SetActive(false);
        puntuacion++;
       actualizarPts ();
    }

    void actualizarPts()
    {
        pts.text = "$"   + puntuacion.ToString();
    }
}
