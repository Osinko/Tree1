using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PermutationTes : MonoBehaviour
{
		void Start ()
		{
				var num = Enumerable.Range (1, 5).Select (x => x).ToArray ();
				//string resume = "0";
				Method (0, "", num);
		}

		void Method (int columns, string resume, int[] num)
		{
				if (columns <= 2) {
						columns++;
						for (int i = 1; i < num.Length+1; i++) {
								string resumeClone = "";
								resumeClone += i.ToString ();
								int[] numClone = num.Where (x => x != i).ToArray ();
						}
				}
		}
}