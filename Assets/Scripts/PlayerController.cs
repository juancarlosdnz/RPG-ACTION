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
    private bool backSide;
    private Animator animator;

    [SerializeField] private float velocidad;

    

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerTransform = GetComponent<Transform>();
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {

        horizontal = playerInput.ejeHorizontal;
        vertical = playerInput.ejeVertical;
        backSide = (vertical > 0);
        
        bool isVerticalZero = (vertical != 0);

        if (isVerticalZero)
        {
            animator.SetBool("Back", backSide);
        }

    }

    void FixedUpdate()
    {

        // Vector2 newPosition = playerTransform.position + new Vector3(velocidad * horizontal*Time.deltaTime, velocidad * vertical*Time.deltaTime, 0);
        // playerTransform.position = newPosition;

        Vector2 velocityVector = new Vector2(horizontal, vertical) * velocidad;
        playerRB.velocity = velocityVector;

    }

    
}
