using UnityEngine;

public class Ground : MonoBehaviour
{
    public Transform ground;
    [Header("地板移動速度"),Range(0,100f)]
    public float speed = 5f;
    private void Update()
    {
        Move();
    }

    /// <summary>
    /// 地板移動
    /// </summary>
    private void Move()
    {
        ground.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
