using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Test4 : MonoBehaviour
{
		List<int> intList = new   List<int> ();
		string[] strList;

		void Start ()
		{
				strList = new string[] {"abc","cde","fgh"};

				intList.Add (1);
				intList.Add (2);

				string str = "|||";
				Method (str, intList, strList);
				print (str);
				foreach (var item in intList) {
						print (item);
				}
				foreach (var item in strList) {
						print (item);
				}
	
		}

		void Method (string str, List<int> intList, string[] strList)
		{
				strList [1] = "000";	//参照渡しの値変更は反映される
				str = str + "000";
				strList = new string[] {"123","456","789"};	//参照渡しの関数内の初期化は無視される

				intList.Add (4);
				intList.Add (5);
		}
}
