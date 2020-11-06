using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPlayer : MonoBehaviour
{
    public CombatManager combatManager;

    public List<Character> characters;
    public int listPos;

    public void TurnStart()
    {
        listPos = 0;

        NextTurn();
    }

    public void NextTurn()
    {
        if(listPos < characters.Count)
        {
            characters[listPos].ShowAvailable(true);
        }
        else
        {
            TurnEnd();
        }
    }

    public void TurnEnd()
    {
        combatManager.enemy.TurnStart();
    }
}
