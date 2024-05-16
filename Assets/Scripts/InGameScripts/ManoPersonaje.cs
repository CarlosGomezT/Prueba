using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoPersonaje : MonoBehaviour
{
    [SerializeField]
    private GameObject pelotaEnMano;
    public bool Ocupado;

    public void AparecerPelota()
    {
        pelotaEnMano.SetActive(!pelotaEnMano.activeSelf);
    }
    private void OnCollisionEnter(Collision other)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Ocupado == true)
        {
            if (other.CompareTag("Caja"))
            {
                AparecerPelota();
                Ocupado = false;
                GlobalManager.StartInteraccion();
            }
        }
    }
}
