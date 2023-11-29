using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndgameManager : MonoBehaviour
{
    public PlayerMovement player;

    private void Update()
    {
        if (player == null)
            StartCoroutine(Endgame());

    }

    IEnumerator Endgame()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Game");
    }
}
