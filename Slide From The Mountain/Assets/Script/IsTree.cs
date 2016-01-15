using UnityEngine;
using System.Collections;

public class IsTree : MonoBehaviour {

	public static int tree = 8;

	public static LayerMask isTree()
	{
		LayerMask treeLayer = 1 << tree;
		return treeLayer;
	}
}
