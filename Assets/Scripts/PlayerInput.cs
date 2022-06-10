using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public float ejeHorizontal;
    public float ejeVertical;
    [HideInInspector] public bool atacar;
    [HideInInspector] public bool habilidad2;
    [HideInInspector] public bool habilidad1;
    [HideInInspector] public bool interactuar;
    [HideInInspector] public bool inventario;


    void Update()
    {

        atacar = Input.GetButtonDown("Atacar");
        habilidad1 = Input.GetButtonDown("Habilidad1");
        habilidad2 = Input.GetButtonDown("Habilidad2");
        inventario = Input.GetButtonDown("Inventario");
        interactuar = Input.GetButtonDown("Interactuar");

        ejeHorizontal = Input.GetAxis("Horizontal");
        ejeVertical = Input.GetAxis("Vertical");

    }
}
