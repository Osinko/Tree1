using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PermutationTes : MonoBehaviour
{
		void Start ()
		{
				PermutationNumber (6, 3);
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
						//forループの中で親の変数を書き換えていないか常に注意する事
						for (int i = 0; i < n.Length; i++) {
								string resumeClone = resume;		//forループの中で親が変更されないように新しく変数を作る（重要）
								resumeClone += n [i].ToString () + ",";
								int[] numClone = n.Where (x => x != n [i]).ToArray ();	//これも作る
								PermutationNest (numClone, r, columns, resumeClone);
						}
				} else {
						print (resume);
				}
		}
}