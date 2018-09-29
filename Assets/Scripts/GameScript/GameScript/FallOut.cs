
using UnityEngine;

public class FallOut : MonoBehaviour {
    public Rigidbody ground;
    private void Start()
    {
        ground = ground.GetComponent<Rigidbody>();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            return;
        ground.isKinematic = false;
    }
}
