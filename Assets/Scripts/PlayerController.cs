using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private Transform playerTransform;
    private Rigidbody2D playerRB;
    private Animator animator;
    private SpriteRenderer playerSprite;

    private float horizontal;
    private float vertical;
    int walkHashCode;

    [SerializeField] private float velocidad;

    

    void Start()
    {

        playerInput = GetComponent<PlayerInput>();
        playerTransform = GetComponent<Transform>();
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerSprite = GetComponent<SpriteRenderer>();
        walkHashCode = Animator.StringToHash("Corriendo")

    }

    void Update()
    {
        horizontal = playerInput.ejeHorizontal;
        vertical = playerInput.ejeVertical;

        bool isVerticalZero = (vertical != 0);

        if (horizontal != 0 || vertical != 0)
        {
            AssignXY();
            animator.SetBool(walkHashCode, true);

        }
        else{
            animator.SetBool(walkHashCode, false);
        }

        SpriteFlipper();

    }

    private void SpriteFlipper()
    {
        if (horizontal < 0 && Mathf.Abs(vertical) < Mathf.Abs(horizontal))
        {
            playerSprite.flipX = true;
        }
        else if (horizontal != 0)
        {
            playerSprite.flipX = false;
        }
    }

    private void AssignXY()
    {
        animator.SetFloat("X", horizontal);
        animator.SetFloat("Y", vertical);
    }

    void FixedUpdate()
    {
        Vector2 velocityVector = new Vector2(horizontal, vertical) * velocidad;
        playerRB.velocity = velocityVector;

    }

    
}
