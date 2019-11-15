using UnityEngine;

public class Test : MonoBehaviour
{

    private int square(int num)
    {
        return num * num;
    }

    private void square2(int num)
    {
        print(num * num);
    }

    private string say(string text)
    {
        return (text);
    }

    private void Start()
    {
        print(square(10));
        square2(20);
        print(say("AAAAAAAAAAA"));
    }
}
