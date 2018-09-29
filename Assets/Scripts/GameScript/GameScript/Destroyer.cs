using UnityEngine;

public class Destroyer : MonoBehaviour {
    public Transform player;

    void Update()
    {
        transform.position =new Vector3(player.position.x,-10f, player.position.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
            return;
        Destroy(collision.gameObject);
    }
}
