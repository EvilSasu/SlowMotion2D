using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject spawnPoint;
    public float spawnRate;
    public float maxX;
    public GameObject startText;
    bool spawnNext = true;
    bool startGame = false;

    private void Update()
    {
        if (startGame)
        {
            if (spawnNext)
                StartCoroutine(CreateBallIE());
        }
        if (Input.anyKeyDown)
        {
            startGame = true;
            startText.gameObject.SetActive(false);
        }
            
    }

    IEnumerator CreateBallIE()
    {
        spawnNext = false;
        yield return new WaitForSeconds(spawnRate);
        Instantiate(ball, new Vector2(Random.Range(-maxX, maxX), spawnPoint.transform.position.y), Quaternion.identity);
        if( spawnRate > 0.1f)
            spawnRate -= 0.1f;
        spawnNext = true;
    }
}
