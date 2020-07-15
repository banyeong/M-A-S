using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEditor;

public class story_2_1 : MonoBehaviour
{
#pragma warning disable 0649

    [SerializeField] private SpriteRenderer sprite_Charcter;
    [SerializeField] private SpriteRenderer sprite_dialogue;

    [SerializeField] private TextMeshProUGUI txt_dialogue;

    [SerializeField] private UnityEngine.UI.Button pgButton;
    [SerializeField] private UnityEngine.UI.Button choice_1;
    [SerializeField] private UnityEngine.UI.Button choice_2;

    private bool isDialogue = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void ShowButton() //선택지버튼이 보이도록 하는 함수
    {
        pgButton.gameObject.SetActive(true);
        choice_1.gameObject.SetActive(true);
        choice_2.gameObject.SetActive(true);
        pgButton.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false); //대화 텍스트가 안 보이게 함

        isDialogue = true;
    }

    public void NextDialogue() //대화활성화
    {
        StudentStat studentStat = new StudentStat();

        txt_dialogue.text = dialogue[count].dialogue;
        sprite_Charcter.sprite = dialogue[count].cg;
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogue == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (count < dialogue.Length)
                {
                    NextDialogue();
                }
                else
                {
                    ShowButton();
                }
            }
        }
    }
}
