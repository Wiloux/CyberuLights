using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharaSelector : MonoBehaviour
{

    public float x1;
    public float y1;
    public CharacterSelector CharaSelect;
    public string SelectedChara;
// Start is called before the first frame update
    void Awake()
    {
     CharaSelect = FindObjectOfType<CharacterSelector>();   
    }

    public void ChangeSelectedCharacter()
    {
        if (!HasSelected)
        {
            SelectedChara = CharaSelect.board[(int)x1, (int)y1].transform.name;
            GetComponent<RectTransform>().position = CharaSelect.board[(int)x1, (int)y1].transform.GetComponent<RectTransform>().position;
            CharaSelect.UpdateSelected(PlayerIndex, (int)x1, (int)y1);
        }
    }
    public bool HasSelected;

    public void SelectTarget()
    {
        if (inUse)
        {
            Debug.Log("selected");
            CharaSelect.LockedCharacters[PlayerIndex] = SelectedChara;
            HasSelected = true;
            GetComponent<RectTransform>().position = new Vector2(5000, 5000);
        }
    }

    public void NewPlayer()
    {
        CharaSelect.LockedCharacters.Add("");
    }

    public bool inUse;
    [SerializeField]
    private int PlayerIndex = 0;
    public int GetPlayerIndex()
    {
        return PlayerIndex;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
