using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public static Music instance;
    [SerializeField] AudioSource music;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void OnMusic()
    {
        music.Play();

    }
    public void OffMusic()
    {
        music.Stop();
    }

    
}
