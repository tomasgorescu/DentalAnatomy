using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lateral : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "lateral"){
            this.GetComponent<Renderer>().material.color = Color.green;
        }
        else{
            this.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
