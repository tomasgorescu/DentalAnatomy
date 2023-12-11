using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canino : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "canino"){
            this.GetComponent<Renderer>().material.color = Color.green;
        }
        else{
            this.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
