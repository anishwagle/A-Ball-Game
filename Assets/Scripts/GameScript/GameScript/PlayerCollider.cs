using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerCollider : MonoBehaviour {
    public GameObject dieMenuUi;
    public PlayerMovement Player;
    public Text score;
    public Transform player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obs")
        {
            Player.enabled = false;
            StartCoroutine(Yourscore());
            

        }

    }
    private IEnumerator Yourscore()
    {
        yield return new WaitForSeconds(2.0f);
        score.text = (player.position.z / 3).ToString("0");
        dieMenuUi.SetActive(true);

    }

}
