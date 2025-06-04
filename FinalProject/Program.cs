using System.Diagnostics;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* State Pattern */
            GameObject box = new GameObject(new GroundState()); // Create context with initial state
            box.DoAction();

            box.ChangeState(new JumpState()); // Set new State
            box.DoAction(); // DoAction will do that states action

            box.DoAction(); // JumpStates previous DoAction will change currentState of box to AirState. Now DoAction is AirState's DoAction.



            /* Prototype Pattern */
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



			/* Adapter Pattern */
			Thing3D thing3D = new Thing3D(new Vector3(3, 5, 8)); //create new thing3D
            Debug.WriteLine("Thing3D's transform: " + thing3D.GetTransformString());

			Vector2 vector2 = new Vector2(5, 7);
			Vector2To3Adapter vector2To3Adapter = new Vector2To3Adapter(vector2, 67); //adapt vector2 -> vector3 with adapter

            thing3D.TeleportToLocation(vector2To3Adapter.ToVector3()); //update thing3D's transform with adapter transform
			Debug.WriteLine("Thing3D's transform: " + thing3D.GetTransformString());
		}
    }
}
