using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SquareTest3 : MonoBehaviour
{
		int[] squareValue;
		const int digitsValue = 6;	//有効６桁

		void Start ()
		{
				//ここはちょっと乱暴に作ってます
				//squareValue = GetSquareValue (Mathf.FloorToInt (Mathf.Sqrt (int.MaxValue))).ToArray ();
				squareValue = GetSquareValue (400).ToArray ();
				print (Square (255));
		}

		float Square (int n)
		{
				float ans = 0;
				float digits = 1f;
				float[] list;

				ans += TreeSearch (n, squareValue);
				for (int i = 1; i <= digitsValue; i++) {
						digits *= 0.1f;
						list = AllSquareList (AddDecimal (ans, digits));
						int pos = TreeSearch (n, list);
						ans += (pos) * digits;
				}
				return ans;
		}

		static float[] AddDecimal (float n, float digits)
		{
				float[] temp = new float[11];
				for (int j = 0; j <= 10; j++) {
						temp [j] = n + digits * j;
				}
				return temp;
		}

		static float[] AllSquareList (float[] list)
		{
				for (int i = 0; i < list.Length; i++) {
						list [i] = list [i] * list [i];
				}
				return list;
		}


		//二分岐検索
		int  TreeSearch (float n, float[] list)
		{
				float start = 0;
				float end = list.Length;
				int mid;
		
				while (true) {
						mid = (int)(end - start) / 2;
						if (mid < 1)
								break;
						mid += (int)start;
			
						if (n > list [mid]) {
								start = mid;
						} else {
								end = mid;
						}
						//print (start + "  " + mid + "  " + end);
				}
				return mid + (int)start;
		}


		//二分岐検索
		int  TreeSearch (int n, int[] list)
		{
				n++;
				int start = 0;
				int end = list.Length;
				int mid;
		
				while (true) {
						mid = (end - start) / 2;
						if (mid < 1)
								break;
						mid += start;
			
						if (n > list [mid]) {
								start = mid;
						} else {
								end = mid;
						}
						//print (start + "  " + mid + "  " + end);
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
