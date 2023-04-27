using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEstadoObjeto : MonoBehaviour
{
    public GameObject objetoCambiado;

    private int cantidadObjetosRecolectados = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ObjetoRecolectable"))
        {
            cantidadObjetosRecolectados++;
            if (cantidadObjetosRecolectados >= 3)
            {
                Destroy(objetoCambiado);
            }
        }
    }
}
