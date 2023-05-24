using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<MenadzerPunktow>().DodajPunkt();
            Destroy(this.gameObject);
        }
    }
}
