using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterList : MonoBehaviour
{

    public int icePlayer;

    public void setIcePlayerTrue()
    {
        icePlayer = 1;
        LoadScene();
    }

    public void setIcePlayerFalse()
    {
        icePlayer = 0;
        LoadScene();
    }

    void LoadScene()
    {
        PlayerPrefs.SetInt("CharacterSelected", icePlayer);
        SceneManager.LoadScene("First Scene");
    }

}
