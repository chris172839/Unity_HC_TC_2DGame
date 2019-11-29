using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int score = 0;
    [Header("最高分數")]
    public int bestscore = 0;
    [Header("水管群組")]
    public GameObject pipe;
    [Header("結束畫面")]
    public GameObject goFianl;
    /// <summary>
    /// 增加分數
    /// </summary>
    /// <returns></returns>
    public int AddScore()
    {
        print("加分!!");
        return ++score;
    }
    /// <summary>
    /// 判定是否最高分並設定
    /// </summary>
    public void SetBest()
    {
        if (score > bestscore)
            bestscore = score;
    }
    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void Gameover()
    {
        goFianl.SetActive(true);
        CancelInvoke("SpawnPipe");
    }

    private void SpawnPipe()
    {
        Vector3 pos = new Vector3(3.5f, Random.Range(-0.8f, 2), 0);
        Instantiate(pipe, pos, Quaternion.identity);
    }

    private void Start()
    {
        InvokeRepeating("SpawnPipe", 1.5f, 3f);
    }
}
