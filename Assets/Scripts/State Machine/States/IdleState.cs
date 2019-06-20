using Assets.Scripts.Game_Events;
using Assets.Scripts.Machine_Events;
using Assets.Scripts.StateMachine.Interfaces;
using UnityEngine;

namespace Assets.Scripts.State_Machine.States
{
    public class IdleState : IState
    {
        public void OnEnter()
        {
            Debug.Log("Idle is started. Waiting...");
            GameMachineEventManager.RaiseOnStateExecution();
        }

        public void OnExecute()
        {
            GameEventManager.RaiseOnIdle();
        }

        public void OnExit()
        {
            Debug.Log("Idle exits!");
        }
    }
}
