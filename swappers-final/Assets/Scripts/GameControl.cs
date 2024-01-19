using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl Instance;

    private int level = 1;

    SwapPositions sp;

    void Awake()
    {
        sp = this.GetComponent<SwapPositions>();

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadLevel();
        }
    }

    private void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IncrementLevel()
    {
        level++;

        if (level == 5)
        {
            GameControl.Instance.GetComponent<SwapPositions>().enabled = true;
        }

        SceneManager.LoadScene("Level" + GameControl.Instance.GetLevel());

    }

    public int GetLevel()
    {
        return level;
    }
}
