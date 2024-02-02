using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl Instance;

    private int level = 0;

    public SwapPositions sp;

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
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex)+1);

    }

    public int GetLevel()
    {
        return level;
    }
}
