using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private Text ballHitTextField;

    private void Start()
    {
        Utils.JumpCounter = PlayerPrefs.GetInt("JumpCounter");
    }

    private void Update()
    {
        ballHitTextField.text = $"BallHit : {Utils.JumpCounter}";
    }
    
    public void StartGame(PlanetData planetData)
    {
        Utils.PlanetData = planetData;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
