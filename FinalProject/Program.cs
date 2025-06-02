namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //* State Pattern *//
            GameObject box = new GameObject(new GroundState()); // Create context with initial state
            box.DoAction();

            box.ChangeState(new JumpState()); // Set new State
            box.DoAction(); // DoAction will do that states action

            box.DoAction(); // JumpStates previous DoAction will change currentState of box to AirState. Now DoAction is AirState's DoAction.
        }
    }
}
