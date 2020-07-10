using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentStat : MonoBehaviour
{
    public static StudentStat instance;

    public int MslStr;//근력
    public int currentMslStr;

    public int MoralStr;//도력
    public int currentMoralStr;

    public int Wealth;//재력
    public int currentWealth;

    public int Favorability;//호감도
    public int cureentFavorability;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        //근력 도력 재력 호감도 50으로 초기화, 초기값은 50임
        currentMslStr = 50;
        currentMoralStr = 50;
        currentWealth = 50;
        cureentFavorability = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
