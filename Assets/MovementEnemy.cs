using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    public int levelBase;

    [Range(0, 10)]
    public float rangePerLvl;

    [Range(0, 5)]
    public float hpPerLvl;

    [Range(0, 10)]
    public float speedPerLvl;

    private new Transform transform ;
    private int level;
    private double range;
    private double speed;
    public GameObject[] players;
    private float[] distance; 

    
    // Unity function
    void Start()
    {
        transform = gameObject.transform;
        level = 1;
        levelBase = 1;
        searchPlayers();
        setStats();
    }

    void Update()
    {
        updateDistances();
    }

    //Custom Function

    void searchPlayers()
    {
        players = GameObject.FindGameObjectsWithTag("Players");
        distance = new float [players.Length];
    }
    void setStats()
    {
        range = rangePerLvl * level;
        speed = speedPerLvl * level;
        hpPerLvl = hpPerLvl * level;

    }

    void updateDistances() {
        
        GameObject player;
        int index = 0;
        int len = players.Length;
        for (; len != index; index++ ) {
            player = players[index];
            var heading = transform.position - player.transform.position;
            distance[index] = heading.magnitude;
        }
    }

    void findPlayer() {
    }

    void follow(){
    }
}

