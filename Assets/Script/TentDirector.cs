using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentDirector : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[2];
    sbyte tentLV = 0;
    public GameObject[] tents = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LV_UP()
    {

        for (int i = 0; i < tents.Length; i++)
        {
            tents[i].GetComponent<SpriteRenderer>().sprite = sprites[tentLV];
        }
        tentLV++;
    }
}
