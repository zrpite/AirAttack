using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global {
	public static string lastscore = "0";
	public static string bestscore = "0";
	public static bool achievement = false;
	public static string Best(){
		if(int.Parse(lastscore) > int.Parse(bestscore))
		bestscore = lastscore;
		return bestscore;
	}
	public static string last(){
		return lastscore;
	}
}
