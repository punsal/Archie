using Assets.Scripts.Machine_Events;
using Assets.Scripts.StateMachine.Interfaces;

namespace Assets.Scripts.State_Machine.Machines
{
    public class GameMachine
    {
        private IState state;

        public void ChangeState(IState state)
        {
            GameMachineEventManager.RaiseOnStateChange();
            this.state?.OnExit();

            this.state = state;
            this.state?.OnEnter();
        }

        public void Run() => state?.OnExecute();
    }
}