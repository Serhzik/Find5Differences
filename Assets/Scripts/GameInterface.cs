using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameInterface : MonoBehaviour {
    public Text timer, timerShadow;
    public Slider slider;
    public GameObject[] Icons, Levels;
    public GameObject Win, star2, star3;
    bool win;
    // Use this for initialization
    void Start() {
        Levels[MenuManager.Instance.loadedlevel].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (!win)
        {
            SetTimer();
            SetIcons();
            SetSlider();
            CheckWin();
        }
	}
    void SetTimer()
    {
        timer.text = "";
        int mins = (int)GameManager.Instance.time / 60;
        int secs = (int)GameManager.Instance.time % 60;
        if (mins < 10)
            timer.text += "0";
        timer.text += mins.ToString() + ":";
        if (secs < 10)
            timer.text += "0";
        timer.text += secs.ToString();
        timerShadow.text = timer.text;
    }
    void SetIcons()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i <= GameManager.Instance.FindedDifs - 1)
                Icons[i].SetActive(true);
            //Debug.Log("i = " + i + "inon [i] = " + Icons[i].activeSelf);
        } 
    }
    //void SetButs()
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        if(GameManager.Instance.Dif[i])
    //        {
    //            ButsLeft[i].SetActive(false);
    //            ButsRight[i].SetActive(false);
    //        }
    //    }
    //}

    //void SetTics()
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        if (GameManager.Instance.Dif[i])
    //        {
    //            TicsLeft[i].SetActive(true);
    //            TicsRight[i].SetActive(true);
    //        }
    //    }
    //}
    void SetSlider()
    {
        //slider.value = ((float)MenuManager.Instance.twoStarSecs + 20) / GameManager.Instance.time;
        slider.value = GameManager.Instance.time;
    }
    void CheckWin()
    {
        if (GameManager.Instance.winner)
        {
            Win.SetActive(true);
            if (GameManager.Instance.time <= MenuManager.Instance.twoStarSecs)
                star2.SetActive(true);
            if (GameManager.Instance.time <= MenuManager.Instance.threeStarSecs)
                star3.SetActive(true);
        }
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void NextButton()
    {
        SceneManager.LoadScene("Game");
    }
}
