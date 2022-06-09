using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private Transform playerTransform;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerTransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        playerInput.atacar = false;
        playerTransform.position= new Vector3(5, 5, 5);
        Debug.Log("Atacando usando player controller "+playerInput.atacar);
    }
}
