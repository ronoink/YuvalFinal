using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodBar : MonoBehaviour
{

    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedskin = 0;
    public GameObject playerskin;

    public void Nextmood()
    {

        selectedskin = selectedskin + 1;
        if (selectedskin == skins.Count)
        {
            selectedskin = 9;
        }
        sr.sprite = skins[selectedskin];


    }






}
