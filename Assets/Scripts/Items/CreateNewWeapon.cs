using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;
	//private string[] weaponNames = new string[6] ("Weapon of Greatness"); can assign to webname

	void Start(){
		CreateWeapon ();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.ItemDescription);
		Debug.Log (newWeapon.ItemID.ToString() );
		Debug.Log (newWeapon.WeaponType.ToString());
		Debug.Log (newWeapon.Stamina.ToString());
		Debug.Log (newWeapon.Endurance.ToString());

	}

	public void CreateWeapon(){

		newWeapon = new BaseWeapon();

		//Assign name to the weapon
		newWeapon.ItemName = "W" + Random.Range(1,101);
		//Create wep desc
		newWeapon.ItemDescription = "This is a new weapon.";
		//Wep ID
		newWeapon.ItemID = Random.Range(1,101);
		//Stats
		newWeapon.Stamina = Random.Range(1,11);
		newWeapon.Endurance = Random.Range (1, 11);
		newWeapon.Intellect = Random.Range (1, 11);
		newWeapon.Strenght = Random.Range (1, 11);
		//Choose Type of wep
		ChooseWeaponType();
		//Spell effect ID
		newWeapon.SpellEffectID = Random.Range(1,101);
	}

	private void ChooseWeaponType(){
		int randomTemp = Random.Range (1, 7);
		if (randomTemp == 1) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		}else if (randomTemp == 2) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		}else if (randomTemp == 3) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.KNIFE;
		}else if (randomTemp == 4) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
		}else if (randomTemp == 5) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		}else if (randomTemp == 6) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
		}
}
}