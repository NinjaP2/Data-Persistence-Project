using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MainManager1 : MonoBehaviour
{
    public static MainManager1 Instance;
    public string Name;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }


}
