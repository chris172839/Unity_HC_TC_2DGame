using UnityEngine;

public class Slime : MonoBehaviour
{
    [Header("跳躍高度"),Range(0.1f,1000f)]
    public float jumpheight=250;
    [Header("是否死亡")]
    public bool dead;
    public GameObject goScore, goGM;
    public Rigidbody2D rb2D;
    public float rotation = 5f;

    private void Start()
    {

    }

    private void Update()
    {
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        Dead();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.name);

        Dead();
    }

    /// <summary>
    /// 是否跳躍
    /// </summary>
    private void Jump()
    {
        if (dead) return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            goScore.SetActive(true);
            goGM.SetActive(true);
            rb2D.Sleep();
            rb2D.gravityScale = 1.5f;
            rb2D.AddForce(new Vector2(0, jumpheight));
        }
        rb2D.SetRotation(rotation * rb2D.velocity.y);
    }
    /// <summary>
    /// 是否死亡
    /// </summary>
    private void Dead()
    {
        dead = true;
    }
    /// <summary>
    /// 是否通過水管
    /// </summary>
    private void ThroughPipe()
    {

    }
}
