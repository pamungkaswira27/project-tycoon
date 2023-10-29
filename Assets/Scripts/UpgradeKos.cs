using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeKos : MonoBehaviour
{
    public RoomExpanderController ruangan;

    public Sprite dua;
    public Sprite tiga;
    public Sprite empat;
    public Sprite lima;
    public Sprite enam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ruangan._numberOfRoom == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = dua;
        }
        if (ruangan._numberOfRoom == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = tiga;
        }
        if (ruangan._numberOfRoom == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = empat;
        }
        if (ruangan._numberOfRoom == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = lima;
        }
        if (ruangan._numberOfRoom == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = enam;
        }

    }
}
