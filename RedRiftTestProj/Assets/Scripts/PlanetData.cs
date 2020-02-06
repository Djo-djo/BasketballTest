using UnityEngine;

[CreateAssetMenu(fileName = "PlanetData", menuName = "Planet Data", order = 51)]
public class PlanetData : ScriptableObject
{
    [SerializeField]
    private Vector2 gravity;
    [SerializeField]
    private Color background;

    public Vector2 Gravity => gravity;

    public Color Background => background;
}
