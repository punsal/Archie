namespace Game_Events
{
    class InputEventManager
    {
        public delegate void IsClicked();

        public static event IsClicked OnClicked;

        public static void RaiseOnClicked() => OnClicked?.Invoke();
    }
}
