using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjetos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mano"))
        {
            ManoPersonaje collisionAPelota = other.GetComponent<ManoPersonaje>();

            if (GlobalManager.Ocupado == false &&  GlobalManager.CanGrab == true)
            {
                collisionAPelota.AparecerPelota();
                GlobalManager.Ocupado = true;
                Destroy(gameObject);
            }
        }
    }
}
