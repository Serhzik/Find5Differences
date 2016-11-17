using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
public class Interface : MonoBehaviour {

    public GameObject[] Opened;
    public GameObject[] Stars1, Stars2, Stars3;

    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < MenuManager.Instance.LvlOpened; i++)
        {
            Opened[i].SetActive(true);
            if (MenuManager.Instance.Stars[i] == 1)
                Stars1[i].SetActive(true);
            else if (MenuManager.Instance.Stars[i] == 2)
                Stars2[i].SetActive(true);
            else if (MenuManager.Instance.Stars[i] == 3)
                Stars3[i].SetActive(true);
        }
	}
    public void OpenRandomStar()
    {
        MenuManager.Instance.OpenLvl(Random.Range(1, 4));
        Debug.Log("OpenRandom");
    }
    public void Clear()
    {
        PlayerPrefs.DeleteAll();
    }
}
