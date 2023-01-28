
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody pb;

    public float forwardForce = 2000f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("play game");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            pb.AddForce( (forwardForce * Time.deltaTime) * -1,0,0);
        }
        // untuk input keyboard dengan menggunakkan Input.GetKey("")
        if (Input.GetKey("s"))
        {
            pb.AddForce( (forwardForce * Time.deltaTime) ,0,0);
        }
        if ( Input.GetKey("d"))
        {
            pb.AddForce(0,0, 500 *Time.deltaTime);
        }
        if ( Input.GetKey("a"))
        {
            pb.AddForce(0,0, (500 *Time.deltaTime)*-1);
        }
    }
}
