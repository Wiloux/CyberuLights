using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;
public class CharacterSelector : MonoBehaviour
{
    public List<CharaCell> Characters;
    public GameObject CellPrefab;
    public Transform[,] board=  new Transform [3,2]; 
    // Start is called before the first frame update
    void Start()
    {
        int x = 0;
        int y = 0;
        foreach(CharaCell c in Characters)
        {
            Instantiate(CellPrefab, transform.position, Quaternion.identity, transform);
            CellPrefab.name = c.name;
            CellPrefab.transform.Find("Sprite").GetComponent<Image>().sprite = c.Sprite;
            board[x +1, y +1] = CellPrefab.transform;
        }
    }
    public List<GameObject> Selection;
    // Update is called once per frame
    void Update()
    {
        foreach(GameObject g in Selection)
        {
           
        }
    }
}
