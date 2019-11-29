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
    public GameManager gm;
    [Header("音效")]
    public AudioSource aud;
    public AudioClip jumpSound, hurtSound, passSound;

    private void Start()
    {

    }

    private void Update()
    {
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)     //isTrigger
    {
        if (collision.gameObject.name == "passArea")
        {
            gm.AddScore();
            aud.PlayOneShot(passSound);
        }
        else
        {
            Dead();
        }
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
            aud.PlayOneShot(jumpSound);
        }
        rb2D.SetRotation(rotation * rb2D.velocity.y);
    }
    /// <summary>
    /// 是否死亡
    /// </summary>
    private void Dead()
    {
        dead = true;
        gm.Gameover();
        Ground.speed = 0;
        aud.PlayOneShot(hurtSound);
    }
    /// <summary>
    /// 是否通過水管
    /// </summary>
    private void ThroughPipe()
    {

    }
}
