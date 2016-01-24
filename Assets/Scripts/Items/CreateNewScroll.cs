using UnityEngine;
using System.Collections;

public class CreateNewScroll : MonoBehaviour {

	private BaseScroll newScroll;


	// Use this for initialization
	void Start () {
		CreateScroll ();
		Debug.Log (newScroll.ItemName);
		Debug.Log (newScroll.ItemDescription);
		Debug.Log (newScroll.ItemID.ToString());
		Debug.Log (newScroll.ScrollEffectID.ToString ());
	}

	private void CreateScroll(){
		newScroll = new BaseScroll ();
		newScroll.ItemName = "Scroll";
		newScroll.ItemDescription = "This is a powerful scroll.";
		newScroll.ItemID = Random.Range (1, 101);
		newScroll.ScrollEffectID = Random.Range (500, 1001);
		ChooseScrollType ();
	}

	private void ChooseScrollType(){
		int randomTemp = Random.Range (1, 4);
		if (randomTemp == 1) {
			newScroll.ScrollType = BaseScroll.ScrollTypes.EXPERIENCE;
		} else if (randomTemp == 2) {
			newScroll.ScrollType = BaseScroll.ScrollTypes.DAMAGE;
		} else if (randomTemp == 3) {
			newScroll.ScrollType = BaseScroll.ScrollTypes.MAGIC;
		}
	}
}
