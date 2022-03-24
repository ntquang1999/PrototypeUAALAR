using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static GameController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        
    }

    public void loadScene(int index)
    {
        SceneManager.LoadScene(index);
    }


    public void receiveData(string receive)
    {
    }

    public void exit()
    {
#if UNITY_IOS
        Application.Unload();
#elif UNITY_ANDROID
        Application.Quit();
#endif
    }
}
