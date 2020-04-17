using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Jugador : MonoBehaviour
{

    public int puntaje = 0;
    public TextMeshProUGUI texto;
    

    // Start is called before the first frame update
    void Start()
    {
        texto = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
