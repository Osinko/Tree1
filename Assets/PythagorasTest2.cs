using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PythagorasTest2 : MonoBehaviour
{
		//ピタゴラスの三角形を生成する数
		public int createValue = 10;

		List<Delta> deltaList = new List<Delta> ();

		void Start ()
		{
				for (int i = 1; i < createValue; i++) {
						deltaList.Add (PythagorasDelta (i));
				}
				foreach (var item in deltaList) {
						print (item);
				}
		}
	
		float B (float n, Delta delta)
		{
				delta.b = 2 * n - 1;
				return delta.b;
		}
	
		float A (float n, Delta delta)
		{
				delta.a = (Mathf.Pow (B (n, delta), 2) - 1) / 2;
				return delta.a;
		}
	
		//A^2 + B^2 = C^2 のピタゴラスの三角形を生成する
		//やや漸化式的に値を求めている
		Delta PythagorasDelta (float n)
		{
				Delta delta = new Delta ();
				delta.c = A (n, delta) + 1;
				return delta;
		}
	
		class Delta
		{
				public float a, b, c;

				public override string ToString ()
				{
						return string.Format ("[ピタゴラスの三角形]{0}^2 + {1}^2 = {2}^2", a, b, c);
				}
		}
}
