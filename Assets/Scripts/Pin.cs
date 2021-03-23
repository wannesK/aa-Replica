using UnityEngine;

public class Pin : MonoBehaviour
{
    public float pinSpeed = 20f;

    private bool isPinned = false;

    private GameManager gameManager;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void Update()
    {
        ShootThePin();
    }

    private void ShootThePin()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * pinSpeed * Time.deltaTime);
        }       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rotator"))
        {
            transform.SetParent(collision.transform);
            //collision.GetComponent<Rotator>().rotateSpeed *= -1;
            isPinned = true;
            gameManager.IncreaseScore();
        }
        else if (collision.CompareTag("Pin"))
        {
            //GameManager.Instance.EndGame();
            gameManager.EndGame();
        }
    }
}
