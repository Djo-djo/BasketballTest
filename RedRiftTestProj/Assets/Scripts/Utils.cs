using UnityEngine;

public static class Utils
{
    private static int jumpCounter;
    private static PlanetData planetData;

    public static int JumpCounter
    {
        get => jumpCounter;
        set
        {
            jumpCounter = value;
            PlayerPrefs.SetInt("JumpCounter", jumpCounter);
        }
    }

    public static PlanetData PlanetData { get => planetData; set => planetData = value; }
}
