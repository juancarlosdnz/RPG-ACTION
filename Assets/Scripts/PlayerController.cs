using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private Transform playerTransform;
    public float velocidad;
    private float horizontal;
    private float vertical;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerTransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = playerInput.ejeHorizontal;
        vertical = playerInput.ejeVertical;

        Vector2 newPosition = playerTransform.position + new Vector3(velocidad * horizontal*Time.deltaTime, velocidad * vertical*Time.deltaTime, 0);
        playerTransform.position = newPosition;
        Debug.Log("Atacando usando player controller "+playerInput.atacar);
    }
}
