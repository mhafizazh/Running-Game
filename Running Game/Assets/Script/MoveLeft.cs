using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10;
    private PlayerControllerScript playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        //playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        
    }
}
