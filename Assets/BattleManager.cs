using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] State state;
    [SerializeField] Player player1;
    [SerializeField] Player player2;



    // Temporary
    [SerializeField] bool isPlayer1DoneSelecting;
    [SerializeField] bool isPlayer2DoneSelecting;
    [SerializeField] bool isAttackDone;
    [SerializeField] bool isDamagingDone;
    [SerializeField] bool isReturningDone;
    [SerializeField] bool isPlayerEleminated;

    enum State
    {
        Preparation,
        Player1Select,
        Player2Select,
        Attacking,
        Damaging,
        Returning,
        BattleOver
    }
    void Update()
    {
       
        switch (state)
        {
            case State.Preparation:
                // player1 prepres
                // set player1 play first
                state = State.Player1Select;
                break;

            case State.Player1Select:
                if (isPlayer1DoneSelecting)
                {
                //set player 2 play next
                state = State.Player2Select;
                }
                break; 

            case State.Player2Select:
                if (isPlayer2DoneSelecting)
                {
                //set player 1 and 2 attacks
                state = State.Attacking;
                }

                break;

            case State.Attacking:
                if(isAttackDone)
                {
                    // calculate who take damage
                    // start damage animation
                    state = State.Damaging;
                }
                break;
            case State.Damaging:
                if (isDamagingDone)
                {
                    state = State.Returning;
                }
                break;

            case State.Returning:
                if (isReturningDone)
                {
                    if (isPlayerEleminated)
                        state = State.BattleOver;
                    else
                        state = State.Preparation;
                }
                break;
            case State.BattleOver:
                break;

    }
}
}
