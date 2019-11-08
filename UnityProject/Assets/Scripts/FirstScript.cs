using UnityEngine;

public class FirstScript : MonoBehaviour    //程式內容
{
    [Header("金幣")]
    public int coin = 500;
    public float speed = 1.5f;
    public string prop = "potion";
    public bool dead = true;

    private void Start()
    {
        print("Hello, world!");
    }

    private void Update()
    {
        print("Hi~");
    }
}




