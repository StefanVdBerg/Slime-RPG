using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEnemy : MonoBehaviour
{
    public CombatManager combatManager;

    public List<Enemy> enemies;
    public int listPos;

    public void TurnStart()
    {
        listPos = 0;

        Debug.Log("Enemy turn");

        EnemyTurn();
    }

    public void EnemyTurn()
    {
        if(listPos < enemies.Count)
        {
            enemies[listPos].RandomAttack();
        }
        else
        {
            TurnEnd();
        }
    }

    public void TurnEnd()
    {
        combatManager.player.TurnStart();
    }
}
