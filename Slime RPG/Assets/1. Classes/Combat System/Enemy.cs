using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public CombatEnemy combatEnemy;

    public List<Action> actions;
    public int atk, def;

    public void RandomAttack()
    {
        StartCoroutine(AttackEvent());
    }

    public IEnumerator AttackEvent()
    {
        actions[Random.Range(0, actions.Count)].Activate(atk);

        yield return new WaitForSeconds(1f);

        combatEnemy.listPos++;

        combatEnemy.EnemyTurn();
    }
}
