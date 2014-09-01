using UnityEngine;
using System.Collections;

public class SquareTest : MonoBehaviour
{

		void Start ()
		{
				print (Square (24));
		}

		int Square (int n)
		{
				if (n == 0) {
						return 0;
				}
				return n + n - 1 + Square (n - 1);
		}
}
