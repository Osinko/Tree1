using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PermutationTes : MonoBehaviour
{
		void Start ()
		{
				PermutationNumber (5, 3);
		}

		void PermutationNumber (int n, int r)
		{
				var number = Enumerable.Range (1, n).Select (x => x).ToArray ();
				PermutationNest (number, r, 0, "");
		}

		void PermutationNest (int[] n, int r, int columns, string resume)
		{
				if (columns < r) {
						columns++;
						for (int i = 0; i < n.Length; i++) {
								string resumeClone = resume + n [i].ToString () + ",";
								int[] numClone = n.Where (x => x != n [i]).ToArray ();
								PermutationNest (numClone, r, columns, resumeClone);
						}
				} else {
						print (resume);
				}
		}
}