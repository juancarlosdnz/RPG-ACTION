using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private Transform playerTransform;
    private float horizontal;
    private float vertical;
    private Rigidbody2D playerRB;

    [SerializeField] private float velocidad;

    

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerTransform = GetComponent<Transform>();
        playerRB = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = playerInput.ejeHorizontal;
        vertical = playerInput.ejeVertical;

        // Vector2 newPosition = playerTransform.position + new Vector3(velocidad * horizontal*Time.deltaTime, velocidad * vertical*Time.deltaTime, 0);
        // playerTransform.position = newPosition;

        Vector2 velocityVector = new Vector2(horizontal, vertical) * velocidad;
        playerRB.velocity = velocityVector;

    }
}
