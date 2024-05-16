using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetsBall : MonoBehaviour
{
    public GameObject target; // Asigna el objeto que quieres seguir en el inspector

    private void Start()
    {
        Invoke("EsperarRealizarAccion", 2f);
    }
    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
        }
    }

    private void EsperarRealizarAccion()
    {
        Invoke("DestruirObjeto", 3f);     
    }

    private void DestruirObjeto()
    {
        if (target != null)
        {
            Destroy(target);
            Destroy(gameObject);
        }
    }
}
