using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class TempDialogueData
{
	[SerializeField]
	protected string _name;
	[SerializeField]
	protected string _dialogue;

	public string CharName
	{
		set
		{
			_name = value;
		}
		get
		{
			return _name;
		}
	}
	public string Dialogue
	{
		set
		{
			_dialogue = value;
		}
		get
		{
			return _dialogue;
		}
	}
}




public class CJooDialogueTest : MonoBehaviour
{
	[SerializeField]
	Text txtName = null;
	[SerializeField]
	Text txtDialogue = null;

	int dialogueIdx = 0;

	[SerializeField]
	protected TempDialogueData[] dialogueDataArray = null;


	// Use this for initialization
	void Start ()
	{
		TempDataSetting();
		dialogueIdx = 0;
		DisplayCurrentDialogue();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void DisplayCurrentDialogue()
	{
		txtName.text = dialogueDataArray[dialogueIdx].CharName;
		txtDialogue.text = dialogueDataArray[dialogueIdx].Dialogue;
	}


	//todo : DoTween->DoText
	public void OnClickBtnNextDialogue()
	{
		if(dialogueIdx >= dialogueDataArray.Length -1)
		{
			return;
		}
		dialogueIdx++;
		DisplayCurrentDialogue();
	}


	private void TempDataSetting()
	{
		dialogueDataArray = new TempDialogueData[10];
		TempDialogueData tdata = null;
		for (int i = 0; i< 10;i++)
		{
			tdata = new TempDialogueData();
			tdata.CharName = i.ToString() + " 번째 캐릭터";
			tdata.Dialogue = i.ToString() + " 번째 대사" + "\n" +
							i.ToString() + " 번째 대사";
			dialogueDataArray[i] = tdata;
		}
	}
}
