using UnityEngine;
using System.Collections;
using System;
using System.Linq.Expressions;

public class Tousasuuretu1 : MonoBehaviour
{
		void Start ()
		{
				Func<float,float> ans = ArithmeticProgression (Integral_Linear);
				print (ans (5));
				print (ArithmeticProgression (3, 5));

				Expression<Func<double,double>> f = x => x * x;
				print (f);
System.CodeDom
		}

		//An=3n (等差数列＝一次関数)
		static float Integral_Linear (float n)
		{
				return 3 * n;
		}

		//等差数列の和を求める
		static Func<float,float> ArithmeticProgression (Func<float,float> function)
		{
				return (n) => n * (function (1) + function (n)) / 2;
		}

		//等差数列の和を求める
		static float ArithmeticProgression (float d, float n)
		{
				return d * n * (1 + n) / 2;
		}
	

}
