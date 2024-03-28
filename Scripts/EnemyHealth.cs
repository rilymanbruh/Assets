using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject ENDGAMEGOOD;

    public float value = 100;

    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            ENDGAMEGOOD.SetActive(true);
            GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
