using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzonee : MonoBehaviour
{
    AudioSource deadZoneSource;
    // Start is called before the first frame update
    void Start()
    {
        deadZoneSource=GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "Player")
        {
                DeadZoneSound();
        }
    }
    // Update is called once per frame
    void DeadZoneSound()
    {
        deadZoneSource.Play();
    }
}
