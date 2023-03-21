using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Material[] material;
    Renderer playerRend;

    public Material Red;
    public Material Green;
    public Material Blue;

    public Text pointsText;
    private int points;
    public GameObject winScreen;
    public GameObject loseScreen;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    void Start()
    {
        winScreen.SetActive(false);
        loseScreen.SetActive(false);

        playerRend = GetComponent<Renderer>();
        playerRend.enabled = true;
        playerRend.sharedMaterial = material[Random.Range(0, material.Length)];

        points = 0;

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "RedBall")
        {
            if (playerRend.sharedMaterial == Red)
            {
                playerRend.sharedMaterial = material[Random.Range(0, material.Length)];
                Destroy(col.gameObject);
                CountPoints();

                Invoke("CallNewRedBalls", 1f);
            }
            else
            {
                loseScreen.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        else if (col.gameObject.tag == "GreenBall")
        {
            if (playerRend.sharedMaterial == Green)
            {
                playerRend.sharedMaterial = material[Random.Range(0, material.Length)];
                Destroy(col.gameObject);
                CountPoints();

                Invoke("CallNewGreenBalls", 1f);
            }
            else
            {
                loseScreen.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        else if (col.gameObject.tag == "BlueBall")
        {
            if (playerRend.sharedMaterial == Blue)
            {
                playerRend.sharedMaterial = material[Random.Range(0, material.Length)];
                Destroy(col.gameObject);
                CountPoints();

                Invoke("CallNewBlueBalls", 1f);
            }
            else
            {
                loseScreen.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    private void CallNewRedBalls()
    {
        FindObjectOfType<SpawnerBalls>().RandomPosRed();
    }

    private void CallNewGreenBalls()
    {
        FindObjectOfType<SpawnerBalls>().RandomPosGreen();
    }

    private void CallNewBlueBalls()
    {
        FindObjectOfType<SpawnerBalls>().RandomPosBlue();
    }

    public void CountPoints()
    {
        if (points < 9)
        {
            points++;
            pointsText.text = points.ToString();
        }
        else
        {
            points++;
            pointsText.text = points.ToString();
            winScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
