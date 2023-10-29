using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Income : MonoBehaviour
{
    public RoomExpanderController ruangan;

    public float timer = 0;
    public int pendapatan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timer += 2;
        }

        if (timer >= 0)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if(timer >= 10)
        {
            pendapatan = pendapatan + (2 * ruangan._numberOfRoom);
            timer = 0;
        }
    }
}
