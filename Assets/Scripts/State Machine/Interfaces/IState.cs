
namespace Assets.Scripts.StateMachine.Interfaces
{
    public interface IState
    {
        void OnEnter();
        void OnExecute();
        void OnExit();
    }
}
