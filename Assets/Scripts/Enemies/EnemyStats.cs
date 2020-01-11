using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    public int levelBase;

	public string[] hazardTags;

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

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<HazardData>())
		{
			foreach (var hazardTag in hazardTags)
			{
				if (other.GetComponent<HazardData>().hazard.hazardObjectName == hazardTag)
				{
					hp -= other.GetComponent<HazardData>().hazard.damagePoints;

					if (hp <= 0)
						Die();
				}
			}
		}
	}

	private void Die()
	{

	}


	void setStats()
    {
        range = rangePerLvl * level;
        speed = speedPerLvl * level;
        hp = hpPerLvl * level;

    }
}
