using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   //Health Bar variable
   public Health_control hp;
   //Player Steps
   public AudioSource step1;
   public AudioSource step2;
   private int currstep;

   private Rigidbody2D rb;
   private Animator anim;
   private SpriteRenderer sprite;

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
      anim = GetComponent<Animator>();
      sprite =GetComponent<SpriteRenderer>();
      currstep = 1;
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
         sprite.flipX=true;
      }
      else if(rb.velocity.x > 0){
         sprite.flipX=false;
      }

      //Steps Audio
      if(Mathf.Abs(rb.velocity.x) > 0 && isGrounded)
      {

         if(!step1.isPlaying && !step2.isPlaying && currstep == 1)
         {
            step1.Play();
            currstep = 2;
         }

                 if(!step1.isPlaying && !step2.isPlaying && currstep == 2)
         {
            step2.Play();
            currstep = 2;
         }
      }

      anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
      anim.SetFloat("V_Speed", rb.velocity.y);
      anim.SetBool("Grounded", isGrounded);

   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      if(other.gameObject.tag == "Spike")
      {
         hp.TakeDamage(20);
      }
   }
}
