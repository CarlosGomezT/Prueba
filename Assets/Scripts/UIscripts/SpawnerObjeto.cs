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
    public bool Gravity = false;
    public float Fuerza;
    public float FuerzaUp;

    public GameObject pelotaPrefab; 
    public GameObject objetivoPrefab;
    public float RadioSpawn ;

    private bool enMovimiento = false;
    private float tiempoInicioMov;
    private Vector3 origen;
    private Vector3 destino;


    // Start is called before the first frame update
    void Start()
    {
        CallSpawner();
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
    void MoverySpawnearGravity()
    {
        GameObject pelota = Instantiate(objetoSpawn, puntoC.position, Quaternion.identity);
        Vector3 posicionObjetivo = puntoD.position + new Vector3(Random.Range(-RadioSpawn, RadioSpawn), Random.Range(-RadioSpawn, RadioSpawn), 0f);
        GameObject objetivo = Instantiate(objetivoPrefab, posicionObjetivo, Quaternion.identity);
        TargetsBall PelotaLanzada = objetivo.GetComponent<TargetsBall>();
        PelotaLanzada.target = pelota;
        Vector3 direccion = (posicionObjetivo - puntoC.position).normalized;
        Rigidbody rb = pelota.GetComponent<Rigidbody>();
        rb.velocity = direccion * (Fuerza);
        rb.AddForce(Vector3.up * ( FuerzaUp), ForceMode.Impulse);
        Quaternion randomRotation = Quaternion.Euler(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
        pelota.transform.rotation = randomRotation;
    }

    public void CallSpawner()
    {
        if (Gravity == false)
        {
            InvokeRepeating("MoverySpawnear", 0f, tiempoSpawn);
        }
        else
        {
            InvokeRepeating("MoverySpawnearGravity", 0f, tiempoSpawn);
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
