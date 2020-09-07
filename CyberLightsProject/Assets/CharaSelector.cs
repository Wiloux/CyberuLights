using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class CharaSelector : MonoBehaviour
{

    public Vector2 x1y2;
    public void OnMove(CallbackContext context)
    {
        x1y2 = context.ReadValue<Vector2>();
        
    }// Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<CharaSelector>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
