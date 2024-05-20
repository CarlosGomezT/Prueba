using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animaciones : MonoBehaviour
{

    public float TimeToDisappear;
    public LookAtConstraint lookAtConstraint;


    private void Start()
    {
        Camera camara = Camera.main;
        Invoke("RealizarAccion", .1f);
        RealizarAccion();

        if (camara != null)
        {
            ConstraintSource constraintSource = new ConstraintSource();
            constraintSource.sourceTransform = camara.transform;
            constraintSource.weight = 1;
            lookAtConstraint.SetSource(0, constraintSource);
        }
    }

    private void RealizarAccion()
    {
        Invoke("DestruirObjeto", TimeToDisappear);
    }

    private void DestruirObjeto()
    {
        Destroy(gameObject);
    }
}
