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

    public Animator animationPersonaje;
    private Coroutine repeatCoroutine;


    // Start is called before the first frame update
    void Start()
    {
        PlayBalls();
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
        Vector3 posicionObjetivo = puntoD.position + new Vector3(Random.Range(-RadioSpawn * .8f, RadioSpawn * .6f), Random.Range(-RadioSpawn, RadioSpawn), 0f);


        GameObject objetivo = Instantiate(objetivoPrefab, posicionObjetivo, Quaternion.identity);
        TargetsBall PelotaLanzada = objetivo.GetComponent<TargetsBall>();
        PelotaLanzada.target = pelota;


        Vector3 direccion = (posicionObjetivo - puntoC.position).normalized;
        Rigidbody rb = pelota.GetComponent<Rigidbody>();


        Vector3 rotationAxis = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        float rotationSpeed = Random.Range(70f, 180f);


        rb.velocity = direccion * (Fuerza);
        rb.AddForce(Vector3.up * (FuerzaUp), ForceMode.Impulse);
        StartCoroutine(RotateBall(pelota, rotationAxis, rotationSpeed));
    }
    IEnumerator RotateBall(GameObject ball, Vector3 axis, float speed)
    {
        while (ball != null)
        {
            ball.transform.Rotate(axis, speed * Time.deltaTime);
            yield return null; 
        }
    }

    public void CallSpawner()
    {
        if (Gravity == false)
        {
            Invoke("MoverySpawnear", 1.4f);
        }
        else
        {
            Invoke("MoverySpawnearGravity", 1.4f);
        }
    }

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

    public void PlayBalls()
    {
        StartRepeating(tiempoSpawn);
    }

    public void StartRepeating(float tiempoRepeat)
    {
        if (repeatCoroutine == null)
        {
            repeatCoroutine = StartCoroutine(RepeatAction(tiempoRepeat));
            Debug.Log("=0=0===0=00=0=00=0=0=");
        }
        Debug.Log("StartRepeating");
    }
    public void StopRepeating()
    {
        if (repeatCoroutine != null)
        {
            StopCoroutine(repeatCoroutine);
            repeatCoroutine = null;
        }
        Debug.Log("StopRepeating");
    }

    IEnumerator RepeatAction(float tiempoRepeat)
    {
        while (GameStateManager.ContinuePlayRoutine == true)
        {
            animationPersonaje.Play("LanzarObjeto");
            CallSpawner();
            yield return new WaitForSeconds(tiempoRepeat);
        }
        Debug.Log("RepeatAction");
        StopRepeating();
    }
}
