using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemigos;
    private float tiempoEntreEnemigos;
    public float comienzoDeTiempo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoEntreEnemigos <= 0)
        {
            int random = Random.Range(0, enemigos.Length);
            Instantiate(enemigos[random], transform.position, Quaternion.identity);

            tiempoEntreEnemigos = comienzoDeTiempo;
        }
        else
        {
            tiempoEntreEnemigos -= Time.deltaTime;
        }
    }
}
