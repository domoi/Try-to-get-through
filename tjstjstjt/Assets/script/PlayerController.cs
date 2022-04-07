using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 5f;
    private bool faceRight = true;
    public GameObject Die1;

    public GameMaster gm;


    private bool isGrounded;
    public Transform groundCheck;
    public float checkRaius;
    public LayerMask whatIsGround;

    private Animator anim;


    Rigidbody2D rb;
    SpriteRenderer sr;
    
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRaius, whatIsGround);

        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;
 
        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.05f && isGrounded ==true)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        if (isGrounded == true)
        {
            anim.SetBool("Jump", false);
        }
        else
        {
            anim.SetBool("Jump", true);
        }
        if(movement > 0 && !faceRight)
        {
            flip();
        }
        else if (movement < 0 && faceRight)
        {
            flip();
        }
        if(movement == 0)
        {
            anim.SetBool("Run", false);
        }
        else
        {
            anim.SetBool("Run", true);
        }
    }
    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Respawn"))
        {
            transform.position = gm.lastCheckPoint;
            
            StartCoroutine(instobj(false));
        }
    }
    IEnumerator instobj(bool textdie)
    {
        yield return new WaitForSeconds(0.5f);
        Die1.SetActive(textdie);
    }
}
        
