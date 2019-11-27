using UnityEngine;

public class Test : MonoBehaviour
{
    
    private void Start()
    {
        
    }

    private void Update()
    {
        print(Input.GetKeyDown(KeyCode.Mouse0));
        print(Input.GetKeyDown("mouse 1"));
    }
}
