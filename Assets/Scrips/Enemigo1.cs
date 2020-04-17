using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Enemigo1 : MonoBehaviour
{

    SerialPort puerto = new SerialPort("COM6", 9600);

    public float velocidad;
    public int contador = 0;
    public bool adentro = false;

    // Start is called before the first frame update
    void Start()
    {

        puerto.Open();
        puerto.ReadTimeout = 1;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * -velocidad * Time.deltaTime;
        if (contador == 2)
        {
            adentro = true;
        }

        else
        {
            adentro = false;
        }

        /*if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (adentro)
            {
                GameObject.Find("CasillaJugador").GetComponent<Jugador>().puntaje++;
                GameObject.Find("CasillaJugador").GetComponent<Jugador>().texto.text = "Score: " +
                    GameObject.Find("CasillaJugador").GetComponent<Jugador>().puntaje.ToString();
                Destroy(gameObject);

            }
        }*/

        if(puerto.IsOpen)

        {
            try
            {
                ene1(puerto.ReadByte());
            }
            catch (System.Exception)
            {

            }
        }
    }
    //2
    void ene1(int direccion)
    {


        if (direccion == 1)
        {
            if (adentro)
            {
                GameObject.Find("CasillaJugador").GetComponent<Jugador>().puntaje++;
                GameObject.Find("CasillaJugador").GetComponent<Jugador>().texto.text = "Score: " +
                    GameObject.Find("CasillaJugador").GetComponent<Jugador>().puntaje.ToString();
                Destroy(gameObject);

            }
        }



        //Space.World: se mueve en las coordenadas del espacio local donde esta el GameObject
        //Space.Self: se utiliza para rotación sobre si mismo, con los ejes que el objeto tiene
        //Camera.main.transform: se mueve relativo a las coordenadas de la camara

        if (direccion == 2)
        {
            

        }
    }

    //1
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            contador++;
        }
    }


    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            contador--;
        }
    }

}
