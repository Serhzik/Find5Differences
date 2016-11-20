using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
    public static MenuManager Instance;
    public int twoStarSecs, threeStarSecs, loadedlevel;

    public int LvlOpened, MaxLevels;
    public bool Completed;
    public int[] Stars;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
        DontDestroyOnLoad(gameObject);
    }

	void Start () {
        LvlOpened = PlayerPrefs.GetInt("Opened", 1);
        for (int i = 0; i < 10; i++)
            Stars[i] = PlayerPrefs.GetInt("Stars" + i, 0);
        if (Stars[9] != 0)
            Completed = true;
	}
	
	public void OpenLvl(int stars)
    {
        Stars[loadedlevel] = stars;
        PlayerPrefs.SetInt("Stars" + (loadedlevel), stars);
        if(loadedlevel == LvlOpened-1)
        {
            if (LvlOpened <= MaxLevels)
            {
                LvlOpened++;
                PlayerPrefs.SetInt("Opened", LvlOpened);
            }
            else
            {
                Completed = true;
            }
            Debug.Log("Open lvl = " + LvlOpened + "Stars = " + stars);
        }
    }
}
