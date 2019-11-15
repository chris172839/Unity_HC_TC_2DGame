using UnityEngine;

public class Ground : MonoBehaviour
{
    public Transform ground;
    [Header("地板移動速度"),Range(0,100f)]
    public float speed = 1f;
    private void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        ground.Translate(-speed, 0, 0);
    }

    /// <summary>
    /// 地板移動
    /// </summary>
    private void Move()
    {

    }
}
