using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirMovimientos : MonoBehaviour
{
    public GameObject objectToFollow; // El objeto cuya rotación queremos seguir
    public GameObject targetObject; // El objeto que capturará la rotación
    public float lerpSpeed = 0.1f; // Velocidad de interpolación

    private Quaternion initialRotation;

    private void Start()
    {
        // Almacenamos la rotación inicial del objeto capturador
        if (targetObject != null)
        {
            initialRotation = targetObject.transform.rotation;
        }
        else
        {
            Debug.LogWarning("El GameObject targetObject no está asignado.");
        }
    }

    private void Update()
    {
        // Si los objetos están asignados
        if (objectToFollow != null && targetObject != null)
        {
            // Obtenemos la rotación del objeto a seguir
            Quaternion rotation = objectToFollow.transform.rotation;

            // Convertimos la rotación en ángulos eulerianos
            Vector3 eulerRotation = rotation.eulerAngles;

            // Dividimos cada componente por 10 para obtener la décima parte
            eulerRotation *= 0.1f;

            // Convertimos los ángulos eulerianos de nuevo a cuaternión
            Quaternion targetRotation = Quaternion.Euler(eulerRotation);

            // Interpolamos suavemente hacia la rotación objetivo
            Quaternion newRotation = Quaternion.Lerp(targetObject.transform.rotation, initialRotation * targetRotation, lerpSpeed * Time.deltaTime);

            // Aplicamos la rotación al objeto capturador
            targetObject.transform.rotation = newRotation;
        }
        else
        {
            Debug.LogWarning("Los GameObjects no están asignados.");
        }
    }
}
