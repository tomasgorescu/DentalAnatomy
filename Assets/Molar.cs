using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "molar"){
            this.GetComponent<Renderer>().material.color = Color.green;
        }
        else{
            this.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
