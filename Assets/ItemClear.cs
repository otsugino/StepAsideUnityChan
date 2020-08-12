using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ItemClear : MonoBehaviour {
	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//unityちゃんとアイテムとの距離
	private float difference;

	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		//Unityちゃんとアイテムの位置（z座標）の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {
		this.difference = unitychan.transform.position.z - this.transform.position.z;

		//Unityちゃんとアイテムの位置（z座標）の差が０以上（Unityちゃんが前）ならアイテムを消去
		if (this.difference > 0)
		{
			Destroy(this.gameObject);
		}
	}
}
