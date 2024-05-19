using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoPersonaje : MonoBehaviour
{
    [SerializeField]
    private GameObject pelotaEnMano;
    public GameObject[] Mensajes;

    public void AparecerPelota()
    {
        pelotaEnMano.SetActive(!pelotaEnMano.activeSelf);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Caja") && GlobalManager.Ocupado == true && GlobalManager.CanGrab==true)
        {

            int randomNum = Random.Range(0, Mensajes.Length);
            Instantiate(Mensajes[randomNum], transform.position, transform.rotation);

            AparecerPelota();
            GlobalManager.Ocupado = false;
            GlobalManager.StartInteraccion();
        }
    }
}
