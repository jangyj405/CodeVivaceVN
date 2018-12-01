using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class JsonS
{
	[SerializeField]
	public string S;
}
[Serializable]
public class JsonN
{
	[SerializeField]
	public string N;
}
[Serializable]
public class JsonCollection
{
	[SerializeField]
	public JsonS client_date = new JsonS();
	[SerializeField]
	public JsonS inDate = new JsonS();
	[SerializeField]
	public JsonN Test01 = new JsonN();
	[SerializeField]
	public JsonS updatedDate = new JsonS();
	[SerializeField]
	public JsonS Test02 = new JsonS();

	public JsonCollection(string str)
	{
		client_date.S = str;
		inDate.S = str;
		Test01.N = str;

	}
	public JsonCollection()
	{

	}
	public override string ToString()
	{
		string aaa = "";
		aaa += client_date.S;
		aaa += inDate.S;
		aaa += Test01.N;

		return aaa;
	}
}








public class TestJson : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		JsonCollection jc = new JsonCollection("asdf");
		string a = JsonUtility.ToJson(jc);
		Debug.Log(a);

		JsonCollection jc2 = JsonUtility.FromJson<JsonCollection>(a);
		Debug.Log(jc2);



	}


	// Update is called once per frame
	void Update()
	{

	}
}
