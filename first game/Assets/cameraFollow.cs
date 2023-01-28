
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //hanya bekerja ketika mulai masuk sence saja
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Player.position);
        //bekerja terus ketika sedang berjalan
        transform.position = Player.position + offset;

    }
}
