using UnityEngine;

public class Slime : MonoBehaviour
{
    [Header("跳躍高度"),Range(0.1f,100f)]
    public float jumpheight;
    [Header("是否死亡")]
    public bool dead;
}
