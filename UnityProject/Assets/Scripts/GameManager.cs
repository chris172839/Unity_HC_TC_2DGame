﻿using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int score = 0;
    [Header("最高分數")]
    public int bestscore = 0;
    /// <summary>
    /// 增加分數
    /// </summary>
    /// <returns></returns>
    private int AddScore()
    {
        return ++score;
    }
    /// <summary>
    /// 判定是否最高分並設定
    /// </summary>
    private void SetBest()
    {
        if (score > bestscore)
            bestscore = score;
    }
    /// <summary>
    /// 遊戲結束
    /// </summary>
    private void Gameover()
    {

    }
}
