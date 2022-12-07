using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    int score = 0;

    private void Start()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    public void ChangeScore(int val)
    {
        score = val;
    }
}
