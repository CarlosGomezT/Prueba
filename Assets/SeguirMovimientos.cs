using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirMovimientos : MonoBehaviour
{
    public GameObject objectToFollow; // El objeto cuya rotaci�n queremos seguir
    public GameObject targetObject; // El objeto que capturar� la rotaci�n
    public float lerpSpeed = 0.1f; // Velocidad de interpolaci�n

    private Quaternion initialRotation;

    private void Start()
    {
        // Almacenamos la rotaci�n inicial del objeto capturador
        if (targetObject != null)
        {
            initialRotation = targetObject.transform.rotation;
        }
        else
        {
            Debug.LogWarning("El GameObject targetObject no est� asignado.");
        }
    }

    private void Update()
    {
        // Si los objetos est�n asignados
        if (objectToFollow != null && targetObject != null)
        {
            // Obtenemos la rotaci�n del objeto a seguir
            Quaternion rotation = objectToFollow.transform.rotation;

            // Convertimos la rotaci�n en �ngulos eulerianos
            Vector3 eulerRotation = rotation.eulerAngles;

            // Dividimos cada componente por 10 para obtener la d�cima parte
            eulerRotation *= 0.1f;

            // Convertimos los �ngulos eulerianos de nuevo a cuaterni�n
            Quaternion targetRotation = Quaternion.Euler(eulerRotation);

            // Interpolamos suavemente hacia la rotaci�n objetivo
            Quaternion newRotation = Quaternion.Lerp(targetObject.transform.rotation, initialRotation * targetRotation, lerpSpeed * Time.deltaTime);

            // Aplicamos la rotaci�n al objeto capturador
            targetObject.transform.rotation = newRotation;
        }
        else
        {
            Debug.LogWarning("Los GameObjects no est�n asignados.");
        }
    }
}
