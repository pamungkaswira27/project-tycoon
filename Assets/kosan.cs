using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kosan : MonoBehaviour
{
    public GameObject Panel;

    private void OnMouseDown()
    {
        Panel.SetActive(true);
    }
}
