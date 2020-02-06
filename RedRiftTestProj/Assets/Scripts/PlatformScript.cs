using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
