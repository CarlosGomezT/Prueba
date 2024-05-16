using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TargetsBall : MonoBehaviour
{
    public GameObject target; // Asigna el objeto que quieres seguir en el inspector
    public Animator AnimationToPlay;
    public LookAtConstraint lookAtConstraint;

    private void Start()
    {
        Invoke("EsperarRealizarAccion", .8f);
        Camera camara = Camera.main;

        if (camara != null)
        {
            // Asigna la cámara al LookAtConstraint
            ConstraintSource constraintSource = new ConstraintSource();
            constraintSource.sourceTransform = camara.transform;
            constraintSource.weight = 1;
            lookAtConstraint.SetSource(0, constraintSource);
        }
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
        AnimationToPlay.Play("TargetAnimation");
        Invoke("DestruirObjeto", 5f);     
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
