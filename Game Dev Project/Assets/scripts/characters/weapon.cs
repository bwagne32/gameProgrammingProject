using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum weaponType{
    sword,
    lance,
    axe,
    bow,
    gun
}



public class weapon : ScriptableObject
{
    public int Attack, Hit, Crit, Weight;
	public int Range;

	public string AnimationKey;
	public weaponType Type;



	public bool needsAmmo;

	public bool hasAdvantage;

	public double weaponAdvantage(weapon otherUnit, weaponType otherWeapon)
	{
        double effectiveness = 1; 
        switch(Type){
            case(weaponType.sword):
                if(otherUnit.Type == weaponType.lance) effectiveness -= .5;
                else if(otherUnit.Type == weaponType.axe) effectiveness += .5;
                break;
            case(weaponType.lance):
                if(otherUnit.Type == weaponType.axe) effectiveness -= .5;
                else if(otherUnit.Type == weaponType.sword) effectiveness += .5;
                break;
            case(weaponType.axe):
                if(otherUnit.Type == weaponType.sword) effectiveness -= .5;
                else if(otherUnit.Type == weaponType.lance) effectiveness += .5;
                break;
            default:
                break; // idk if C# plays nice without defaults
        }
		return effectiveness;
	}

}
