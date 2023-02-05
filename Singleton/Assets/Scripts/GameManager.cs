using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int currentLevel = 0;
    public int slimeB = 0;
    public int targetSl = 1;
    public int health = 100;
    
    void Awake()
    {

        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slimeB == targetSl)
        {
            currentLevel++;
            slimeB=0;
            targetSl *= 2;
            SceneManager.LoadScene(currentLevel);
        }
        
        if (health == 0)
        {
            SceneManager.LoadScene("Scenes/gameOver");
        }
    }
}
