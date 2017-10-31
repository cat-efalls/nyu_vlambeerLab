using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour {
	public static int globalTileCount;
	// Use this for initialization
	void Start () {
		globalTileCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		//- code it so that all the Pathmakers can only spawn a grand total of 500 tiles in the entire world; how would you do that?
			//	- (hint: declare a "public static int" and have each Pathmaker check this "globalTileCount", somewhere in your code? if there are already enough tiles, then maybe the Pathmaker could Destroy my game object

	}
}
