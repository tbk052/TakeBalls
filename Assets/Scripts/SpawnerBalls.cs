using UnityEngine;

public class SpawnerBalls : MonoBehaviour
{
    public GameObject ballPrefab_red;
    public GameObject ballPrefab_green;
    public GameObject ballPrefab_blue;

    void Start()
    {
        RandomPosRed();
        RandomPosGreen();
        RandomPosBlue();
    }

    public void RandomPosRed()
    {
        Vector3 randomPos_red = new Vector3(Random.Range(-6, 10), 2, Random.Range(0, 14));
            Instantiate(ballPrefab_red, randomPos_red, Quaternion.identity);
    }
    public void RandomPosGreen()
    {
        Vector3 randomPos_green = new Vector3(Random.Range(-6, 10), 2, Random.Range(0, 14));
            Instantiate(ballPrefab_green, randomPos_green, Quaternion.identity);
    }
    public void RandomPosBlue()
    {
        Vector3 randomPos_blue = new Vector3(Random.Range(-6, 10), 2, Random.Range(0, 14));
            Instantiate(ballPrefab_blue, randomPos_blue, Quaternion.identity);
    }
}
