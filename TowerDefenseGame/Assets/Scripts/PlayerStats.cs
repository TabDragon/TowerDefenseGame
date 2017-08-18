using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int money;
    public int startMoney = 400;

    public static int lives;
    public int startLives;

    private void Start()
    {
        money = startMoney;
        lives = startLives;
    }
}
