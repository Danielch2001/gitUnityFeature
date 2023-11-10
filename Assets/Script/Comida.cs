using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comida : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        // Esta función se ejecuta automáticamente cuando el objeto entra en colisión con otro objeto.

        // Verifica si el objeto con el que colisionamos tiene la etiqueta "comida".
        if (collision.transform.CompareTag("Player"))
        {
            FindAnyObjectByType<GameManager>().AddComida();
            // Si el objeto tiene la etiqueta "Player", destrúyelo.
            Destroy(gameObject);
        }
    }
}
