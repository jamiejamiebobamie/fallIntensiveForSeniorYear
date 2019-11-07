using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRules : MonoBehaviour
{
    public GameObject IcePlayer;
    public GameObject FirePlayer;
    int icePlayer;

    //public CharacterList characterList;

    // Start is called before the first frame update
    void Start()
    {
        //characterList = gameObject.GetComponent<CharacterList>();

        icePlayer = PlayerPrefs.GetInt("CharacterSelected");
        Debug.Log(icePlayer);

        if (icePlayer == 1)
        {
            IcePlayer.SetActive(true);
            FirePlayer.SetActive(false);

        }
        else
        {
            IcePlayer.SetActive(false);
            FirePlayer.SetActive(true);
        }


    }
}
