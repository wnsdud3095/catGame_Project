using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int HP = 10;
    public void GetDamage(int damage)
    {
        HP = HP - damage;
        Debug.Log("HP" + HP);
        if(HP<=0)
            Destroy(gameObject);
    }
}
