using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{

    public Text TimerText;

    public float StartTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        string Scene = SceneManager.GetActiveScene().name;
        if (Scene == "Scene")
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Update()
    {
        float t = Time.time - StartTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        TimerText.text = minutes + ":" + seconds;
    }

}