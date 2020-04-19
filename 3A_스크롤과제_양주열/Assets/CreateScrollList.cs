using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CreateScrollList : MonoBehaviour
{
    public int itemCount = 0;

    public GameObject Item;
    public Transform ContentPanel;

    private string[] name = { 
               "나무 철퇴", "돌 철퇴", "강철 철퇴", "다이아 철퇴" , "황금 철퇴"
             , "나무 도끼", "돌 도끼", "강철 도끼", "다이아 도끼", "황금 도끼"
             , "나무 지팡이", "돌 지팡이", "강철 지팡이", "다이아 지팡이", "황금 지팡이"
             , "나무 메이스", "돌 메이스", "강철 메이스", "다이아 메이스" , "황금 메이스"
             , "나무 외날도끼", "돌 외날도끼", "강철 도끼", "다이아 도끼"
             , "Error", "Error", "Error", "Error"
             , "나무 둔기", "돌 둔기", "강철 둔기", "다이아 둔기", "황금 둔기"
             , "나무 폴암", "돌 폴암", "강철 폴암", "다이아 폴암"
             , "나무 망치", "돌 망치", "강철 망치", "다이아 망치", "황금 망치"
             , "나무 폴암", "돌 폴암", "강철 폴암", "다이아 폴암"
             , "나무 창"
             , "나무 낫", "돌 낫", "강철 낫", "다이아 낫", "황금 낫"
    };

    private string[] score = {
               "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15", "LEVEL 20"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15", "LEVEL 20"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15", "LEVEL 20"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15", "LEVEL 20"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15", "LEVEL 20"
             , "Error", "Error", "Error", "Error"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15", "LEVEL 20"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15", "LEVEL 20"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15", "LEVEL 20"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15"
             , "LEVEL 0"
             , "LEVEL 0", "LEVEL 5", "LEVEL 10", "LEVEL 15", "LEVEL 20"
    };

    private Sprite[] sprites;

    void Start()
    {
        sprites = Resources.LoadAll<Sprite>("ItemSprite02");
        PoulateList();
    }

    void PoulateList()
    {
        for(int i = 0; i < itemCount; i++)
        {
            GameObject newButton = Instantiate(Item) as GameObject;
            Item Script = newButton.GetComponent<Item>();
            Script.nameLabel.text = name[i];
            Script.LevelLabel.text = score[i];
            Script.Icon.sprite = sprites[i];

            newButton.transform.SetParent(ContentPanel);
        }

    }


}
