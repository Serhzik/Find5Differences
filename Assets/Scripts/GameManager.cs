using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public int FindedDifs;
    public float time;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

	}
    public void Find()
    {
        FindedDifs++;
        if (FindedDifs == 5) // Win
        {
            int stars = 1;
            if (time < 180)
                stars++;
            if (time < 60)
                stars++;
            MenuManager.Instance.OpenLvl(stars);
        }
    }
}
