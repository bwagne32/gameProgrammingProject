using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor.UI;
using UnityEngine;

public enum weaponType
{
    sword,
    lance,
    axe,
    bow,
    gun
}

public class character : MonoBehaviour
{
    public int health_;
    public int movement_;
    public float speed_;
    public int luck_;
    public int damage_;
    public int defense_;
    public weaponType weapon_;
    int range_;
    public bool alive = true;
    public GameObject self;

    // Start is called before the first frame update
    void Start()
    {
        switch (weapon_){
            case weaponType.sword:
            case weaponType.lance:
            case weaponType.axe:
                range_ = 1;
                break;
            case weaponType.bow:
            case weaponType.gun:
                range_ = 2; break;
        }
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    int hit(float modifier)
    {
        if (modifier >= UnityEngine.Random.Range(0, 100)) return 1;
        else return 0; 
    }

    float advantage(weaponType attacker, weaponType defender)
    {
        switch (defender)
        {
            case(weaponType.sword):
                if (attacker == weaponType.lance) return 2;
                else if (attacker == weaponType.axe) return .5f;
                break;
            case(weaponType.axe):
                if (attacker == weaponType.sword) return 2;
                else if (attacker == weaponType.lance) return .5f;
                break;
            case(weaponType.lance):
                if (attacker == weaponType.lance) return 2;
                else if (attacker == weaponType.axe) return .5f;
                break;
        }
        return 1f;

    }
    void attack(ref character target){
        if(target.speed_ > speed_){
            health_ -= Convert.ToInt32(Mathf.Round(advantage(target.weapon_, weapon_) * target.damage_ * hit(luck_)));
            if(health_ < 0)
            {
                alive = false;
                return;
            }
        }
        else{
            target.health_ -= Convert.ToInt32(Mathf.Round(advantage(weapon_, target.weapon_) * damage_ * hit(target.luck_)));
            if (target.health_ < 0)
            {
                target.alive = false;
                return;
            }
        }
    }

}
