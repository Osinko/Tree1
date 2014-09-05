using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Combination2 : MonoBehaviour
{
		void Start ()
		{
				List<string> strlist = CombinationNumbers (10, 8);
				foreach (var item in strlist) {
						print (item);
				} 
		}
	
		List<string> CombinationNumbers (int n, int r)
		{
				List <string> strList = new List<string> ();
				int[] numbers = new int[r + 1];
				CombinationNest (n, r, 1, 1, numbers, strList);
				return strList;
		}
	
		void CombinationNest (int n, int r, int nest, int columns, int[] numbers, List <string> strList)
		{
				for (int i = nest; i <= n-r+columns; i++) {
						numbers [columns] = i;
						if (columns != r) {
								CombinationNest (n, r, i + 1, columns + 1, numbers, strList);
						} else {
								string str = "";
								for (int j = 1; j < numbers.Length; j++) {
										str += numbers [j] + ",";
								}
								strList.Add (str);
						}
				}
		}
}