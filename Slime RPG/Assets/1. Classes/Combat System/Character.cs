using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CombatPlayer combatPlayer;

    public GameObject myActions;

    public List<GameObject> actions;
    public int atk, def;

    public delegate void AbilityEvent();

    AbilityEvent abilityEvent;

    public void ShowAvailable(bool b)
    {
        myActions.SetActive(b);
    }

    public void AdjustSkillList(bool b)
    {
        foreach (GameObject a in actions)
        {
            gameObject.SetActive(b);
        }
    }

    public void PressButton(Action action)
    {
        StartCoroutine(MyTurn(action));
    }

    public IEnumerator MyTurn(Action action)
    {
        ShowAvailable(false);

        yield return new WaitForSeconds(0.5f);

        action.Activate(atk);

        yield return new WaitForSeconds(0.5f);

        combatPlayer.listPos++;

        combatPlayer.NextTurn();
    }
}
