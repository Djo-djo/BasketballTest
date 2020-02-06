using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField]
    private Text ballHitTextField;
    [SerializeField]
    private GameObject basketballBall;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = Utils.PlanetData.Gravity;
        Camera.main.backgroundColor = Utils.PlanetData.Background;
        var screenSize = Camera.main.ScreenToWorldPoint(Vector3.zero);
        basketballBall.transform.position = new Vector3(screenSize.x / 5, screenSize.y / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        ballHitTextField.text = $"BallHit : {Utils.JumpCounter}";

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
