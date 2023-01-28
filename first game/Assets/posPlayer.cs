using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class posPlayer : MonoBehaviour
{
    public Transform Player;
    public Text posText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posText.text = Player.position.z.ToString("");
    }
}
