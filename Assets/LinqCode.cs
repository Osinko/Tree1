using UnityEngine;
using System.Collections;
using System.Linq;

public class LinqCode : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
				int[] quary = Enumerable.Range (1, 10).Select (x => Random.Range (1, 100)).ToArray (); 
				var quarySort = quary.OrderByDescending (x => x);

				foreach (var item in quarySort) {
						print (item);
				}

		}
}
