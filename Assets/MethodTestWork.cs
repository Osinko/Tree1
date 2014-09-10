using UnityEngine;
using System.Collections;

public class MethodTestWork : MonoBehaviour
{
		void Start ()
		{
				float x = 4f;

				print (f1 (x));
				print (f2 (x));
		}

		float f1 (float x)
		{
				return Mathf.Sqrt (x);
		}

		float f2 (float x)
		{
				return -Mathf.Sqrt (x);
		}
}
