using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SquareTest3 : MonoBehaviour
{
		//この数の平方根を求めるプログラムです
		public int number = 5;

		float[] squareValue;
		const int digitsValue = 6;	//有効６桁

		void Start ()
		{
				//int限界値までのキャッシュ作成の場合は以下のコードを利用します
				//squareValue = GetSquareValue (Mathf.FloorToInt (Mathf.Sqrt (int.MaxValue))).ToArray ();
				squareValue = GetSquareValue (400).ToArray ();	//とりあえず20^2まで大丈夫にしている
				print (number + "の平方根は" + Root (number));
		}

		//平方根を求める
		float Root (int n)
		{
				float ans = 0;
				float digits = 1f;
				float[] list;

				ans += TreeSearch (n + 1, squareValue);
				for (int i = 1; i <= digitsValue; i++) {
						digits *= 0.1f;
						list = AllSquareList (AddDecimal (ans, digits));
						int pos = TreeSearch (n, list);
						ans += (pos) * digits;
				}
				return ans;
		}

		//小数点部生成
		static float[] AddDecimal (float n, float digits)
		{
				float[] temp = new float[11];
				for (int j = 0; j <= 10; j++) {
						temp [j] = n + digits * j;
				}
				return temp;
		}

		//リスト内をすべて２乗する
		static float[] AllSquareList (float[] list)
		{
				for (int i = 0; i < list.Length; i++) {
						list [i] = list [i] * list [i];
				}
				return list;
		}

		//二分検索
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

		//平方数生成
		IEnumerable<float> GetSquareValue (int maxValue)
		{
				for (int i = 0; i <= maxValue; i++) {
						yield return i * i;
				}
		}
}
