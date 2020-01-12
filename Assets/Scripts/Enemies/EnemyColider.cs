using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColider : MonoBehaviour
{
    public string playerTag;
    private MovementEnemy Function;
    //public Object EnemyC;
    // Start is called before the first frame update
    void Start()
    {
        Function = this.transform.parent.GetComponent<MovementEnemy>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerStay(Collider other)
    {   
        if(other.CompareTag(playerTag))
        {
            Function.Follow(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            Function.NotFollow();
        }
    }
}
