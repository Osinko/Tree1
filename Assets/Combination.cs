using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Combination : MonoBehaviour
{
		void Start ()
		{
				C (5, 3);
		}
	
		void C (int n, int r)
		{
				int[] m = new int[100]; 
				Nest (1, 0, n, r, m);
		}
	
		void Nest (int column, int nest, int n, int r, int[] m)
		{
				for (int i = nest+1; i <= n-r+column; i++) {
						m [column] = i;
						if (r != column) {
								Nest (column + 1, i, n, r, m);
						} else {
								string str = "";
								for (int j = 1; j <= r; j++) {
										str += m [j];
								}
								print (str);
						}
				}
		}
}