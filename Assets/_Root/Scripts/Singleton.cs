using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    Singleton<T> instance;
    public Singleton<T> Instance => instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
