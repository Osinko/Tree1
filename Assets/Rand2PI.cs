using UnityEngine;
using System.Collections;

public class Rand2PI : MonoBehaviour
{
		public int sampling = 10000;
		int m, n;
		int count;
		float pi;

		void Start ()
		{
				for (int i = 0; i < sampling; i++) {
						m = Random.Range (0, 100000);
						n = Random.Range (0, 100000);
						float gcd = MathfUtils.Gcd (m, n);
						if (gcd == 1) {
								count++;
						}
				}
				pi = Mathf.Sqrt (6f * sampling / count);
				print (pi);
		}
}
