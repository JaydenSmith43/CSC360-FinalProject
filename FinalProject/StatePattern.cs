using System.Diagnostics;

namespace FinalProject
{
    abstract class State // State Interface
    {
		protected GameObject gameObject;

		public abstract void DoAction();
		public abstract void SetContext(GameObject gameObject);
	}

	class GroundState : State // Concrete State
	{
		public override void DoAction()
		{
			Debug.WriteLine("I am on the ground");
		}

		public override void SetContext(GameObject gameObject)
		{
			this.gameObject = gameObject;
		}
	}

	class JumpState : State // Concrete State
	{
		public float jumpForce = 25f;

		public override void SetContext(GameObject gameObject)
		{
			this.gameObject = gameObject;
		}

		public override void DoAction()
		{
			Debug.WriteLine("I am jumping in the air");
			gameObject.ChangeState(new AirState());
		}


	}

	class AirState : State // Concrete State
	{
		public float airTime = 0f;

		public override void SetContext(GameObject gameObject)
		{
			this.gameObject = gameObject;
		}

		public override void DoAction()
		{
			Debug.WriteLine("I am in the air");
		}
	}

	class GameObject // Context
	{
		private State currentState;
		public GameObject(State currentState)
		{
			this.currentState = currentState;
			this.currentState.SetContext(this);
		}

		public void ChangeState(State currentState)
		{
			this.currentState = currentState;
			this.currentState.SetContext(this);
		}

		public void DoAction() // Do the action of the current state
		{
			currentState.DoAction();
		}
	}
}
