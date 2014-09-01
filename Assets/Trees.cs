using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Trees : MonoBehaviour
{
		void Start ()
		{
				List<string> list = new List<string> ();
				list.Add ("1");
				list.Add ("2");
				list.Add ("3");
				list.Add ("4");

				IEnumerable<string> str = Permutations ("", list);

				foreach (var item in str) {
						print (item);
				}
		}

		IEnumerable<string> Permutations (string str, List<string> list)
		{
				if (list.Count == 0) {
						yield return str;
				}

				for (int i = 0; i < list.Count; i++) {
						List<string> list2 = new List<string> (list);
						str += list [i];
						list2.Remove (list [i]);
						str += Permutations (str, list2);
				}

				yield return str;
		}
}
