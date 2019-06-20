namespace Assets.Scripts.Game_Events
{
    class GameEventManager
    {
        public delegate void IdleAction();
        public static event IdleAction OnIdle;
        public static void RaiseOnIdle() => OnIdle?.Invoke();

        public delegate void GameAction();
        public static GameAction OnGame;
        public static void RaiseOnGame() => OnGame?.Invoke();

        public delegate void ExitAction();
        public static ExitAction OnExit;
        public static void RaiseOnExit() => OnExit?.Invoke();
    }
}
