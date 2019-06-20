using Assets.Scripts.Game_Events;
using Assets.Scripts.Machine_Events;
using Assets.Scripts.StateMachine.Interfaces;
using UnityEngine;

namespace Assets.Scripts.State_Machine.States
{
    public class GameState : IState
    {
        public void OnEnter()
        {
            Debug.Log("Game is started. Waiting...");
            GameMachineEventManager.RaiseOnStateExecution();
        }

        public void OnExecute()
        {
            GameEventManager.RaiseOnGame();
        }

        public void OnExit()
        {
            Debug.Log("Game exits!");
        }
    }
}
