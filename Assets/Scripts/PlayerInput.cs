using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public float ejeHorizontal;
    public float ejeVertical;
    public bool atacar;
    public bool habilidad1;
    public bool habilidad2;
    public bool inventario;
    public bool interactuar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        atacar = Input.GetButtonDown("Atacar");
        habilidad1 = Input.GetButtonDown("Habilidad1");
        habilidad2 = Input.GetButtonDown("Habilidad2");
        inventario = Input.GetButtonDown("Inventario");
        interactuar = Input.GetButtonDown("Interactuar");

        ejeHorizontal = Input.GetAxis("Horizontal");
        ejeVertical = Input.GetAxis("Vertical");

        Debug.Log("El eje horizontal "+ejeHorizontal);
        Debug.Log("El eje horizontal "+ejeVertical);

    }
}
