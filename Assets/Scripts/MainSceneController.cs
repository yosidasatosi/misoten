using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneController : MonoBehaviour
{
    public string NextSceneName;
    public Animation StageNameAnim;

    // Start is called before the first frame update
    void Start()
    {
        FadeInOut.Instance.FadeIn(1.0f,() => StageNameAnim?.Play());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(NextSceneName);
        }
    }
}
