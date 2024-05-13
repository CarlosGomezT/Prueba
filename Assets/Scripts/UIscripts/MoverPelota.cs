using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPelota : MonoBehaviour
{

    public Transform target;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("PelotaDestino").transform;
    }
    
    // Update is called once per frame
    void Update()
    {
        float paso = velocidad * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, paso);
       
    }

}
