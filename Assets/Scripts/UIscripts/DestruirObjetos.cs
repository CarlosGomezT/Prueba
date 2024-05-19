using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjetos : MonoBehaviour
{
    public GameObject[] Mensajes;

    private void Update()
    {
        if(GlobalManager.CanGrab == false)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mano"))
        {
            ManoPersonaje collisionAPelota = other.GetComponent<ManoPersonaje>();

            if (GlobalManager.Ocupado == false &&  GlobalManager.CanGrab == true)
            {
                int randomNum = Random.Range(0, Mensajes.Length);
                Instantiate(Mensajes[randomNum], transform.position, transform.rotation);

                collisionAPelota.AparecerPelota();
                GlobalManager.Ocupado = true;
                Destroy(gameObject);
            }
        }
    }
}
