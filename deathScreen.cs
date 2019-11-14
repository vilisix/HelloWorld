using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScreen : MonoBehaviour
{
    public Canvas deathScreenCanvas;
    private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        deathScreenCanvas.enabled = false;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead && Input.GetKeyDown(KeyCode.Space))
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
        if (isDead && Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    public void killPlayer()
    {
        deathScreenCanvas.enabled = true;
        isDead = true;
    }

}
