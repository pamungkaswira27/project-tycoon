using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncomeUi : MonoBehaviour
{
    public Income waktu;
    // Start is called before the first frame update
    Text score;

    void Start()
    {
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        score.text = "" + waktu.pendapatan;
    }
}
