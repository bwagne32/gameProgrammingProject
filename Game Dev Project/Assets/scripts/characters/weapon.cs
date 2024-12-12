using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Weapon : ScriptableObject
{
    public int Attack, Hit, Crit, Weight;
	public int Range;

	public string AnimationKey;
	weaponType Type;



	public bool needsAmmo;

	public bool hasAdvantage;

	public double weaponAdvantage(Weapon otherUnit, weaponType otherWeapon)
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
