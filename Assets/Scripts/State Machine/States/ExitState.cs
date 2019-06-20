using System.Threading;
using Assets.Scripts.Game_Events;
using Assets.Scripts.Machine_Events;
using Assets.Scripts.StateMachine.Interfaces;
using UnityEngine;

namespace Assets.Scripts.State_Machine.States
{
    public class ExitState : IState
    {
        public void OnEnter()
        {
            Debug.Log("Exiting..");
            Thread.Sleep(1000);
            GameMachineEventManager.RaiseOnStateExecution();
        }

        public void OnExecute()
        {
            GameEventManager.RaiseOnExit();
        }

        public void OnExit()
        {
            Debug.Log("Game is ready for another state.");
        }
    }
}