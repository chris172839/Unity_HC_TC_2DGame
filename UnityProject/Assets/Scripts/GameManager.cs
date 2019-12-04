using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public Text scoreText;
    public Text BestScoreText;
    /// <summary>
    /// 增加分數
    /// </summary>
    /// <returns></returns>
    public void AddScore()
    {
        ++score;
        scoreText.text = score.ToString();
        SetBest();
    }
    /// <summary>
    /// 判定是否最高分並設定
    /// </summary>
    public void SetBest()
    {
        if (score > bestscore)
            PlayerPrefs.SetInt("最高分數", score);
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

    public void Replay()
    {
        print("重新");
        SceneManager.LoadScene("遊戲場景");

    }

    public void Exit()
    {
        print("離開");
        Application.Quit();
    }

    private void Start()
    {
        Screen.SetResolution(450, 800, false);
        InvokeRepeating("SpawnPipe", 1.5f, 3f);
        bestscore = PlayerPrefs.GetInt("最高分數");
        BestScoreText.text = bestscore.ToString();
    }
}
