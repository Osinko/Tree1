using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PermutationTes : MonoBehaviour
{
		void Start ()
		{
				var num = Enumerable.Range (1, 5).Select (x => x).ToArray ();
				Method (0, "", num);
		}

		void Method (int columns, string resume, int[] num)
		{
				if (columns < 2) {
						columns++;
						for (int i = 0; i < num.Length; i++) {
								string resumeClone = resume;
								resumeClone += num [i].ToString ();
								int[] numClone = num.Where (x => x != num [i]).ToArray ();
								Method (columns, resumeClone, numClone);
						}
				} else {
						print (resume);
				}
		}
}