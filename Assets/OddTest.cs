using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OddTest : MonoBehaviour
{
		void Start ()
		{
				Odd (8);
//				IEnumerable<int> oddNum = Odd2 (8);
//				foreach (var item in oddNum) {
//						print (item);
//				}
		}

		//帰納的に再帰関数で組んだ場合（実用性は別：あくまで考え方を練習するため）
		int Odd (int n)
		{
				if (n == 0) {
				} else {
						Odd (n - 1);
						n = n * 2 - 1;
						print (n);
				}
				return n;
		}

		//普通はこうする
		IEnumerable<int> Odd2 (int n)
		{
				for (int i = 1; i <= n; i++) {
						yield return i * 2 - 1;
				}
		}
}