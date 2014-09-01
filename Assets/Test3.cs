using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Test3 : MonoBehaviour
{
		int value = 8;
		int maxValue;
		int[] squareValue;

		void Start ()
		{
				//int型で2乗できる最大値
				//maxValue = Mathf.FloorToInt (Mathf.Sqrt (int.MaxValue));
				maxValue = 100;		
				squareValue = GetSquareValue ().ToArray ();
				print (TreeSearch (value));
		}

		//二分岐検索
		int TreeSearch (int n)
		{
				int next = squareValue.Length - 1;
				int prev = next;
				int pointer = prev / 2;

				while (prev!=0) {
						if (n == squareValue [pointer]) {
								break;
						} else {
								if (n > squareValue [pointer]) {
										pointer += prev;
								} else {
										pointer -= prev;
								}
								print ("!" + pointer);
						}
						prev /= 2;
				}
				return pointer - 1;
		}

		//平方数生成
		IEnumerable<int> GetSquareValue ()
		{
				for (int i = 0; i <= maxValue; i++) {
						yield return i * i;
				}
		}
}

