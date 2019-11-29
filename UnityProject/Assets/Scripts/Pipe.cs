public class Pipe : Ground
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 3f);
    }

    private void OnBecameVisible()
    {
        
    }
}