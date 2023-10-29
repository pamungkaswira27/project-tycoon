using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Income : MonoBehaviour
{
    public RoomExpanderController ruangan;

    public float timer = 0;
    public int pendapatan;

    public int jumlahUpgrade = 0;
    // Start is called before the first frame update
    void Start()
    {
        //demo
        //pendapatan = PlayerPrefs.GetInt("pendapatan", 0);
    }

    // Update is called once per frame
    void Update()
    {

        //PlayerPrefs.SetInt("pendapatan", pendapatan);

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
            pendapatan = pendapatan + jumlahUpgrade + (2 * ruangan._numberOfRoom);
            
            timer = 0;
        }
    }
}
