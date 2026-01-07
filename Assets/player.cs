using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject Character;
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public float checkRadius = 0.2f;
    private Rigidbody2D _rb;
    private bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private health health;
    public Text jumptext;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = Character.GetComponent<Rigidbody2D>();
        health = FindFirstObjectByType<health>();
    }

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space)) Debug.Log("player: space pressed");
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("player: space pressed & isGrounded");
            _rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

            isGrounded = false;
            //jumptext.text="Заряд прыжка: 0";
            Debug.Log("player: прыг");
        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);
        if (isGrounded) jumptext.text="Заряд прыжка: 1";
        else jumptext.text="Заряд прыжка: 0";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.D))
        {
            _rb.linearVelocity = new Vector2(moveHorizontal * moveSpeed, _rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rb.linearVelocity = new Vector2(moveHorizontal * moveSpeed, _rb.linearVelocity.y);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("player: "+collision.gameObject.name);
    }
}
