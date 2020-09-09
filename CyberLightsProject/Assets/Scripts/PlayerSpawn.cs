using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public string[] characterArray = new string[0];

    // Start is called before the first frame update
    void Start()
    {
        //Spawn Player 1
        GameObject instance = Instantiate(Resources.Load(characterArray[0], typeof(GameObject))) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
