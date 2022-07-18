using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ControllerV2 : MonoBehaviour
{  internal enum driveType
    {
     frontWheelDrive , 
    rearWheelDrive,
    allWheelDrive
    }   

[SerializeField] private driveType drive;

    public inp IM; 


    [Header("Collider de las llantas")]
    public WheelCollider[] llantas = new WheelCollider[4];

    [Header("Objetos de llantas")]
    public GameObject[] mallasLlanta = new GameObject[4];

    [Header("Parámetros de movimiento")]
    // Torque del motor en N/metros
    public int torqueMotor = 1000;
    // Máxima velocidad de giro
    public float direccionMax = 10;

    // Start is called before the first frame update
    void Start()
    {
         getObjects();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AnimarLlantas();
        moveVehicle();
        steerVehicle ();

       
    }

    private void moveVehicle()
    {   
        //float totalPower;
        
        if(drive == driveType.allWheelDrive)
        { for(int i = 0; i < llantas.Length; i++)
            {
                llantas[i].motorTorque = IM.vertical * (torqueMotor/4);
            }

        } 
        
        else if (drive== driveType.rearWheelDrive )

        {
            for(int i = 2; i < llantas.Length; i++)
            {
                llantas[i].motorTorque = IM.vertical * (torqueMotor/2);
            }

        }

         else 

        {
            for(int i = 0; i < llantas.Length -2; i++)
            {
                llantas[i].motorTorque = IM.vertical * (torqueMotor/2);
            }

        }

    }


    void steerVehicle()
    {
        for(int i = 0; i < llantas.Length -2; i++)
            {
                llantas[i].steerAngle = IM.horizontal * direccionMax;
            }
    }

    void AnimarLlantas()
    {
        // Iniciar posicion en cero
        Vector3 posicionLlantas = Vector3.zero;

        // Iniciar rotacion a la predeterminada
        Quaternion rotacionLlantas = Quaternion.identity;

        // Para cada llanta asignar la rotacion y la posicion
        for (int i = 0; i < 4; i++)
        {
            llantas[i].GetWorldPose(out posicionLlantas, out rotacionLlantas);
            mallasLlanta[i].transform.position = posicionLlantas;
            mallasLlanta[i].transform.rotation = rotacionLlantas;
            mallasLlanta[i].transform.Rotate(Vector3.forward, 90);
        }
    }

    private void getObjects()
    {
        IM = GetComponent<inp>();
    }
}