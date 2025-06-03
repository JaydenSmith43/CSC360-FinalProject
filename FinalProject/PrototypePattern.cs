using System.Diagnostics;
using System.Drawing;

namespace FinalProject
{
	public interface Bomb // Prototype Interface
	{
		Bomb Clone();
		void Explode();
	}

	class BigBomb : Bomb // Concrete Prototype
	{
		private int _explosionTimer;
		private int _bombSize;

		public BigBomb(int bombSize, int explosionTimer)
		{
			_bombSize = bombSize;
			_explosionTimer = explosionTimer;
		}

		public Bomb Clone()
		{
			return new BigBomb(_bombSize, _explosionTimer);
		}

		public void Explode()
		{
			Debug.WriteLine("I am big bomb, kaboom! Explosion Timer = " + _explosionTimer + ", Bomb Size = " + _bombSize);
		}
	}

	class C4 : Bomb
	{
		private int _bombRadius;
		private int _bombSize;

		public C4(int bombSize, int bombRadius)
		{
			_bombSize = bombSize;
			_bombRadius = bombRadius;
		}

		public Bomb Clone()
		{
			return new C4(_bombSize, _bombRadius);
		}

		public void Explode()
		{
			Debug.WriteLine("I am C4, skadoosh! Bomb Radius = " + _bombRadius + ", Bomb Size = " +_bombSize);
		}
	}
}