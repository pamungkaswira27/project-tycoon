using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_manager : MonoBehaviour
{
   public GameObject menu_pause;
    public GameObject menu_upgrade;


    public void muncul_pause()
    {
        menu_pause.SetActive(true);
    }

    public void resume()
    {
        menu_pause.SetActive(false);
    }

    public void panel_upgrade()
    {
        menu_upgrade.SetActive(true);
    }

    public void panel_upgrade2()
    {
        menu_upgrade.SetActive(false);
    }
}
