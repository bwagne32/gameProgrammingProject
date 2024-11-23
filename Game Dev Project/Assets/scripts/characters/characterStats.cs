using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStats : ScriptableObject
{
    public string name_;

    public int movementDistance_;

    public int health_;
    public int attack_;
    public int speed_;
    public int luck_;
    public int defence_;
       
    public Sprite Portrait_;
    public Sprite Mugshot_;
    public Sprite MapSprite_;

    public RuntimeAnimatorController BattleSprite_;
    public weapon weapon_;
}
