namespace Assets.Scripts.Machine_Events
{
    class GameMachineEventManager
    {
        public delegate void StateChangeAction();
        public  static  event  StateChangeAction OnStateChange;
        public static void RaiseOnStateChange() => OnStateChange?.Invoke();

        public delegate void StateExecutionAction();
        public static event StateExecutionAction OnStateExecution;
        public static void RaiseOnStateExecution() => OnStateExecution?.Invoke();

        public delegate int ExampleDelegate(string msg);

        public static event ExampleDelegate OnExampleAction;
    }
}
