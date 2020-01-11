using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    public int levelBase;

    [Range(0, 10)]
    public float rangePerLvl;

    [Range(0, 5)]
    public float hpPerLvl;

    [Range(0, 10)]
    public float speedPerLvl;

    [Header("Private variables")]
    [SerializeField]
    private int level;

    [SerializeField]
    private double range;

    [SerializeField]
    private double speed;

    [SerializeField]
    private double hp;
    
    // Start is called before the first frame update
    void Start()
    {
        
        level = 1;
        levelBase = 1;
        setStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setStats()
    {
        range = rangePerLvl * level;
        speed = speedPerLvl * level;
        hp = hpPerLvl * level;

    }
}
