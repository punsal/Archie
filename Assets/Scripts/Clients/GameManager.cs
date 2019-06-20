using Assets.Scripts.Machine_Events;
using Assets.Scripts.State_Machine.Machines;
using Assets.Scripts.State_Machine.States;
using UnityEngine;
using UnityEngine.UI;
// ReSharper disable All

namespace Assets.Scripts.Clients
{
    public class GameManager : MonoBehaviour
    {
        public Button IdleButton;
        public Button GameButton;
        public Button ExitButton;

        private readonly GameMachine gameMachine = new GameMachine();
        private bool isExecutable = false;

        private void OnEnable()
        {
            IdleButton.onClick.AddListener(OnIdle);
            GameButton.onClick.AddListener(OnGame);
            ExitButton.onClick.AddListener(OnExit);

            GameMachineEventManager.OnStateChange += OnStateChange;
            GameMachineEventManager.OnStateExecution += OnStateExecution;
            GameMachineEventManager.OnExampleAction += ExampleMethod;

            gameMachine.ChangeState(new IdleState());
        }

        public int ExampleMethod(string msg)
        {
            return msg.Length;

        }

        private void Update()
        {
            if (isExecutable)
            {
                gameMachine.Run();
            }
        }

        private void OnIdle()
        {
            gameMachine.ChangeState(new IdleState());
        }

        private void OnGame()
        {
            gameMachine.ChangeState(new GameState());
        }

        private void OnExit()
        {
            gameMachine.ChangeState(new ExitState());
        }

        private void OnStateChange()
        {
            isExecutable = false;
        }

        private void OnStateExecution()
        {
            isExecutable = true;
        }

        private void OnDisable()
        {
            IdleButton.onClick.RemoveListener(OnIdle);
            GameButton.onClick.RemoveListener(OnGame);
            ExitButton.onClick.RemoveListener(OnExit);

            GameMachineEventManager.OnStateChange -= OnStateChange;
            GameMachineEventManager.OnStateExecution -= OnStateExecution;

            gameMachine.ChangeState(null);
        }
    }
}
