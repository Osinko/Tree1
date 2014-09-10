using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour
{
		public Transform a;
		public Transform b;

		public	bool col;
	
		void Update ()
		{
				col = ColBetweenSphere (a.transform.position, b.transform.position);
		}

		public static bool ColBetweenSphere (Vector3 position1, Vector3 position2, float radius1 = 0.5f, float radius2 = 0.5f)
		{
				return  (position1 - position2).sqrMagnitude <= (radius1 + radius2) * (radius1 + radius2);
		}
}
