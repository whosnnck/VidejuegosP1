using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarObjetos : MonoBehaviour
{
    public int objetosRecolectados = 0;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ObjetoRecolectable"))
        {
            other.gameObject.SetActive(false);
            objetosRecolectados++;
        }
    }
}
