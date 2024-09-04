using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Player player;
    public static int map_size = 40;

    void Awake()
    {
        Instance = this;
    }

}
