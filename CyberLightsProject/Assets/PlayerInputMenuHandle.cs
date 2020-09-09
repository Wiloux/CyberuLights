using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputMenuHandle : MonoBehaviour
{
    // Start is called before the first frame update
    public CharaSelector Selector;
    PlayerInput playerInput;
    int PlayerIndex;
    void Awake()
    {
        var Selectors = FindObjectsOfType<CharaSelector>();
        playerInput = GetComponent<PlayerInput>();
        PlayerIndex = playerInput.playerIndex;
        Selector = Selectors.FirstOrDefault(m => m.GetPlayerIndex() == PlayerIndex);
    }

    private void Start()
    {
        StartCoroutine(PlayerJoins());
    }
    IEnumerator PlayerJoins()
    {
        Selector.ChangeSelectedCharacter(); 
        Selector.NewPlayer();
      yield return new  WaitForSeconds(0.4f);
        Selector.inUse = true;
    }
    public void OnSelection(CallbackContext context)
    {
        if (Selector != null)
        {
            if (!Selector.HasSelected)
            {
                Selector.SelectTarget();
            }
        }
    }
    public void OnMove(CallbackContext context)
    {
        if (Selector != null)
        {

            Selector.x1 += context.ReadValue<Vector2>().x;
            Selector.y1 +=  context.ReadValue<Vector2>().y *-1;
            if (Selector.y1 > 1)
            {
                Selector.y1 = 1;
            }
            else if (Selector.y1 < 0)
            {
                Selector.y1 = 0;
            }

            if (Selector.x1 > 2)
            {
                Selector.x1 = 2;
            }
            else if (Selector.x1 < 0)
            {
                Selector.x1 = 0;
            }

            Selector.ChangeSelectedCharacter();
        }

    }
    // pdate is called once per frame
    void Update()
    {

    }
}
