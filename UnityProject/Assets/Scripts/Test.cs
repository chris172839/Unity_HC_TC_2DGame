using UnityEngine;

public class Test : MonoBehaviour
{
    public int a = 10, b = 3,combo = 0;
    public bool A, B;

    private void Start()
    {
        /*
        #region 數學運算子
        print("a + b =" + (a + b));
        print("a - b =" + (a - b));
        print("a * b =" + (a * b));
        print("a / b =" + (a / b));
        print("a % b =" + (a % b));
        print("a  執行a--後  a-- =" + a-- + "  a = " + a);
        print("a  執行a++後  a++ =" + a++ + "  a = " + a);
        print("a  執行--a後  --a =" + --a + "  a = " + a);
        print("a  執行++a後  ++a =" + ++a + "  a = " + a);
        print("a += 10 >> " + (a += 10));
        a = 10;
        #endregion
        #region 比較運算子
        print("a > b 結果是 " + (a > b));
        print("a < b 結果是 " + (a < b));
        print("a >= b 結果是 " + (a >= b));
        print("a <= b 結果是 " + (a <= b));
        print("a == b 結果是 " + (a == b));
        print("a != b 結果是 " + (a != b));
        #endregion 

        #region 邏輯運算子
        print("true && true 結果是 " + (A && B));
        print("true && false 結果是 " + (A && !B));
        print("false && true 結果是 " + (!A && B));
        print("false && false 結果是 " + (!A && !B));
        print("true || true 結果是 " + (A || B));
        print("true || false 結果是 " + (A || !B));
        print("false || true 結果是 " + (!A || B));
        print("false || false 結果是 " + (!A || !B));
        #endregion 
        */

        
    }

    private void Update()
    {
        #region 判斷式
        if (combo <= 50) { print("1x"); }
        else if (combo <= 100) { print("2x"); }
        else if (combo <= 150) { print("5x"); }
        else { print("10x"); }
        #endregion
    }



}
