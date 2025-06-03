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



            //* Prototype Pattern *//
            Bomb bigBomb = new BigBomb(6, 30);
			Bomb newBigBomb1 = bigBomb.Clone();
			bigBomb.Explode();
			newBigBomb1.Explode();

            Bomb newBigBomb2 = new BigBomb(8, 500);
            newBigBomb2.Explode();

			Bomb ceeFour1 = new C4(2, 10);
            Bomb ceeFour2 = ceeFour1.Clone();
			Bomb ceeFour3 = ceeFour1.Clone();

            ceeFour1.Explode();
            ceeFour2.Explode();
            ceeFour3.Explode();
		}
    }
}
