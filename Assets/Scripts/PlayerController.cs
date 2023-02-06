using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody2D rb;
   //private Animator anim;

   public Transform groundCheckPoint;

   public LayerMask whatIsGround;
   public bool isGrounded;

   public KeyCode jump;

   [SerializeField]
   private float movementSpeed;
   [SerializeField]
   private float jumpForce;
   [SerializeField]
   private float groundCheckRadius;


   // Start is called before the first frame update
   void Start()
   {
      rb = GetComponent<Rigidbody2D>();
      //anim = GetComponent<Animator>();
   }


   // Update is called once per frame
   void Update()
   {
      isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

      rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movementSpeed, rb.velocity.y);
      
      if (Input.GetKeyDown(jump) && isGrounded){
         rb.velocity = new Vector2(rb.velocity.x, jumpForce);
      }

      if (rb.velocity.x < 0){
         transform.localScale = new Vector3(-1,1,1);
      }
      else if(rb.velocity.x > 0){
         transform.localScale = new Vector3(1,1,1);
      }

      //anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
      //anim.SetBool("Grounded", isGrounded);
   }
}