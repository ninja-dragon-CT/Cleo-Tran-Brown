using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void OnButtonSelect1 ()
    {
        SceneManager.LoadScene(1);
    }

    public void OnButtonSelect2 ()
    {
        SceneManager.LoadScene(2);
    }

    public void OnButtonSelect3 ()
    {
        SceneManager.LoadScene(3);
    }

    [System.Serializable]
    public struct ButtonPlayerPrefs
    {
        public GameObject gameObject;
        public string playerPrefKey;
    }

    public ButtonPlayerPrefs[] buttons;

    private void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int score = PlayerPrefs.GetInt(buttons[i].playerPrefKey, 0);

            for (int starIndex = 1; starIndex <= 3; starIndex++)
            {
                Transform star = buttons[i].gameObject.transform.Find("star" + starIndex);
                if (starIndex <= score)
                {
                    star.gameObject.SetActive(true);
                }
                else
                {
                    star.gameObject.SetActive(false);
                }
            }
                 
        }
    }
}
