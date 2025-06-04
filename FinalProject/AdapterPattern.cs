using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Thing3D
    {
		Vector3 _transform;

		public Thing3D(Vector3 transform)
        {
            _transform = transform;
        }
        
        public void TeleportToLocation(Vector3 transform)
        {
            _transform = transform;
        }

        public Vector3 GetTransform()
        {
            return _transform;
        }

        public string GetTransformString()
        {
			return "(" + _transform.x + ", " + _transform.y + ", " + _transform.z + ")";
		}
    }



    class Vector2
    {
		public float x = 0;
		public float y = 0;

		public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

	class Vector3
	{
		public float x = 0;
		public float y = 0;
        public float z = 0;

		public Vector3(float x = 0, float y = 0, float z = 0)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
	}

	class Vector2To3Adapter
	{
        private Vector2 _vector2;
        private float z = 0;
		public Vector2To3Adapter(Vector2 vector2, float z = 0)
        {
            _vector2 = new Vector2(vector2.x, vector2.y);
            this.z = z;
		}

        public Vector3 ToVector3()
        {
            return new Vector3(_vector2.x, _vector2.y, z);
        }
    }

}
