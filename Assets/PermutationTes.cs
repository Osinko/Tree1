using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PermutationTes : MonoBehaviour
{
		void Start ()
		{
				var num = Enumerable.Range (1, 5).Select (x => x).ToArray ();
				Method (0, "", num, 3);
		}

		void Method (int columns, string resume, int[] num, int r)
		{
				if (columns < r) {
						columns++;
						//forループの中で親の変数を書き換えていないか常に注意する事
						for (int i = 0; i < num.Length; i++) {
								string resumeClone = resume;		//forループの中で親が変更されないように新しく変数を作る（重要）
								resumeClone += num [i].ToString ();
								int[] numClone = num.Where (x => x != num [i]).ToArray ();	//これも作る
								Method (columns, resumeClone, numClone, r);
						}
				} else {
						print (resume);
				}
		}
}