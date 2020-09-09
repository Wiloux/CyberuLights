using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehaviour : MonoBehaviour
{
    public GameObject bulletRef;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShootOnce()
    {
        Instantiate(bulletRef, spawnPoint.position, Quaternion.identity);
    }
}
