using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public TMP_Text clicksT;
    public TMP_Text clicksTT;
    int clicks;
    int totalclicks;

    // Start is called before the first frame update
    void Start()
    {
        totalclicks = PlayerPrefs.GetInt("tclicks");
    }

    // Update is called once per frame
    void Update()
    {
        totalclicks = PlayerPrefs.GetInt("tclicks");
        clicksT.text = clicks.ToString();
        clicksTT.text = totalclicks.ToString();
    }

    public void Clicks()
    {
        clicks++;
    }
    public void End()
    {
        if (clicks > totalclicks)
        {
            PlayerPrefs.SetInt("tclicks", clicks);
        }
    }
    public void StartG()
    {
        PlayerPrefs.SetInt("clicks", 0);
        clicks = 0;
    }
}
