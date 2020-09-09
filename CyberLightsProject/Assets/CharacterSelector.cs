using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.InputSystem.InputAction;
public class CharacterSelector : MonoBehaviour
{
    public List<CharaCell> Characters;
    public GameObject CellPrefab;
    public UniqueCell[,] board = new UniqueCell[3, 2];
    public List<PLAYERSELECTSPOT> selections = new List<PLAYERSELECTSPOT>();
    int x = -1;
    int y = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (CharaCell c in Characters)
        {
            x++;
            if (x > 2)
            {
                x = 0;
                y++;
            }
            GameObject NewCell = Instantiate(CellPrefab, transform.position, Quaternion.identity, transform);
            NewCell.name = c.name;
            NewCell.transform.Find("Sprite").GetComponent<Image>().sprite = c.Sprite;
            UniqueCell NewUniqueCell = new UniqueCell();
            NewUniqueCell.transform = NewCell.transform;
            NewUniqueCell.cell = c;
            board[x, y] = NewUniqueCell;

        }

        Selectors = FindObjectsOfType<CharaSelector>();
    }

    public List<string> LockedCharacters;
    public CharaSelector[] Selectors;
        
    public void UpdateSelected(int PlayerIndex, int x, int y)
    {
        PLAYERSELECTSPOT currentSelection = selections[PlayerIndex];
        currentSelection.nameCharacter.text = board[x,y].cell.name;
        currentSelection.image.sprite = board[x, y].cell.Sprite;
    }
    // Update is called once per frame
    void Update()
    {
        int PlayerInPlay = 0;
        int PlayerSelected= 0;


        for (int i = 0; i < Selectors.Length; i++)
        {
            if (Selectors[i].inUse || Selectors[i].HasSelected)
            {
                PlayerInPlay++;
            }

            if (Selectors[i].HasSelected)
            {
                PlayerSelected++;
            }

            if(PlayerSelected == PlayerInPlay && PlayerInPlay > 1)
            {
                Debug.Log("StartTheGame!");
                Debug.Log(PlayerInPlay);
            }
        }
    }

    [System.Serializable]
    public class PLAYERSELECTSPOT
    {
        public Image image;
        public bool isLocked;
        public TextMeshProUGUI nameCharacter;
    }

    public class UniqueCell
    {
        public CharaCell cell;
        public Transform transform;
    }
}
