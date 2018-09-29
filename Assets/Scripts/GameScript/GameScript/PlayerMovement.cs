using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 0f;
    public float sideForce = 30f;
    private float ScreenWidth;

    private void Start()
    {
        ScreenWidth = Screen.width;
    }
    // Update is called once per frame
    void Update () {
        rb.AddForce(0f, 0f, forwardForce * Time.deltaTime);
        if (Input.GetKey("a")){
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        int i=0;
        while(i<Input.touchCount)
        {
            if(Input.GetTouch(i).position.x>ScreenWidth/2)
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            ++i;
        }
	}
}
