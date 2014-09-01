using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class saiki1 : MonoBehaviour
{
		//総和・漸化式
		int Sum1 (int n)
		{
				if (n == 0) {
				} else {
						n = Sum1 (n - 1) + n;
						print (n);
				}
				return n;
		}

		//総和・閉じた式
		int Sum2 (int n)
		{
				return n * (n + 1) / 2; 
		}

		//総和の数列を得る
		IEnumerable<int> Sum3 (int n)
		{
				if (n == 0) {
				} else {
						n = Sum1 (n - 1) + n;
				}
				yield return n;
		}

		void Start ()
		{
				print (Fibonacci (11));
		}

		//漸化式：フィボナッチ数
		int Fibonacci (int n)
		{
				int number = 0;
				if (n > 2) {
						number = Fibonacci (n - 1) + Fibonacci (n - 2);
				} else {
						number = n < 1 ? 0 : 1;
				}
				return number;
		}
	
		void Method (string str, int n)
		{
				if (n != 0) {
						Method ("B", n - 1);	//15
						Method ("C", n - 1);	//15
						Method ("D", n - 1);	//15
						print (str + n);
				}
		}
	
}