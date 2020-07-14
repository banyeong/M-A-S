using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}

public class story_1 : MonoBehaviour //아무런 조건도 충족하지 못함
{
    [SerializeField] private SpriteRenderer sprite_Charcter;
    [SerializeField] private SpriteRenderer sprite_dialogue;
    [SerializeField] private Text txt_dialogue;

    private bool isDialogue = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void NextDialogue() //대화활성화
    {
        StudentStat studentStat = new StudentStat();

        if ((studentStat.currentMslStr < 300) && (studentStat.currentMoralStr < 300)
                && (studentStat.currentWealth < 500) && (studentStat.Favorability < 300))
        {
            txt_dialogue.text = dialogue[count].dialogue;
            sprite_Charcter.sprite = dialogue[count].cg;
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isDialogue)
        {
            if(Input.GetMouseButtonDown(0))
            {
                if(count < dialogue.Length)
                {
                    NextDialogue();
                }

                else
                {
                    //씬 전환 로그 넣어야 할 듯
                }    
            }
        }
    }
}
