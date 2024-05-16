using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjetos : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mano"))
        {
            ManoPersonaje collisionAPelota = other.GetComponent<ManoPersonaje>();

            if (collisionAPelota.Ocupado == false)
            {
                collisionAPelota.AparecerPelota();
                collisionAPelota.Ocupado = true;
                Destroy(gameObject);
            }
        }
    }
}
