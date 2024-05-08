using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjeto : MonoBehaviour
{
    public GameObject objetoSpawn;
    public Transform puntoC;
    public Transform puntoD;
    public float velocidad = 1.0f;
    public float tiempoSpawn = 1.0f;

    private bool enMovimiento = false;
    private float tiempoInicioMov;
    private Vector3 origen;
    private Vector3 destino;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MoverySpawnear", 0f, tiempoSpawn);
    }

    void MoverySpawnear()
    {
        if (!enMovimiento)
        {
            Instantiate(objetoSpawn, puntoC.position, Quaternion.identity);

            origen = puntoC.position;
            destino = puntoD.position;
            tiempoInicioMov = Time.time;
            enMovimiento = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enMovimiento)
        {
            float tiempoPasado = Time.time - tiempoInicioMov;
            float fraccionCamino = Mathf.Clamp01(tiempoPasado * velocidad / Vector3.Distance(origen, destino));

            transform.position = Vector3.Lerp(origen, destino, fraccionCamino);

            if (fraccionCamino >= 1.0f)
            {
                enMovimiento = false;
            }
        }
    }
}
