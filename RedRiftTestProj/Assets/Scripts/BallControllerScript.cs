using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallControllerScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    private Rigidbody2D rb;

    private Touch touch;
    private Vector3 touchPosition, whereToMove;

    private float currentDistanceToTouchPos = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        currentDistanceToTouchPos = (touchPosition - transform.position).magnitude;

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                StartMoving(touch.position);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            StartMoving(Input.mousePosition);
        }
    }

    private void StartMoving(Vector3 endPosition)
    {
        currentDistanceToTouchPos = 0;
        touchPosition = Camera.main.ScreenToWorldPoint(endPosition);
        touchPosition.z = 0;
        whereToMove = (touchPosition - transform.position).normalized;
        rb.velocity = new Vector2(whereToMove.x * moveSpeed, whereToMove.y * moveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Utils.JumpCounter++;
    }

    private void OnBecameInvisible()
    {
        rb.velocity -= 2 * rb.velocity;
    }
}