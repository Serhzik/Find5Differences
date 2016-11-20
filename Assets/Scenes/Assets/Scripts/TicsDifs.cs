using UnityEngine;
using System.Collections;

public class TicsDifs : MonoBehaviour {
    public GameObject[]  ButsLeft, ButsRight, TicsLeft, TicsRight;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        SetButs();
        SetTics();
    }

    void SetButs()
    {
        for (int i = 0; i < 5; i++)
        {
            if (GameManager.Instance.Dif[i])
            {
                ButsLeft[i].SetActive(false);
                ButsRight[i].SetActive(false);
            }
        }
    }

    void SetTics()
    {
        for (int i = 0; i < 5; i++)
        {
            if (GameManager.Instance.Dif[i])
            {
                TicsLeft[i].SetActive(true);
                TicsRight[i].SetActive(true);
            }
        }
    }
}
