using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SquareTest2 : MonoBehaviour
{
		int[] squareValue;

		void Start ()
		{
				//ここはちょっと乱暴に作ってます
				//squareValue = GetSquareValue (Mathf.FloorToInt (Mathf.Sqrt (int.MaxValue))).ToArray ();
				squareValue = GetSquareValue (400).ToArray ();
				print (TreeSearch (5));
		}

		//二分岐検索
		int  TreeSearch (int n)
		{
				n++;
				int start = 0;
				int end = squareValue.Length;
				int mid;

				while (true) {
						mid = (end - start) / 2;
						if (mid < 1)
								break;
						mid += start;

						if (n > squareValue [mid]) {
								start = mid;
						} else {
								end = mid;
						}
						print (start + "  " + mid + "  " + end);
				}
				return mid + start;
		}
	
		//平方数生成
		IEnumerable<int> GetSquareValue (int maxValue)
		{
				for (int i = 0; i <= maxValue; i++) {
						yield return i * i;
				}
		}
}
