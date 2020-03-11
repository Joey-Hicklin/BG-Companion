using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    // VARIABLES

    private string title;
    private bool attack;
    private bool focus;
    private bool movement;
    private bool trap;
    private bool heal;
    private bool shield;
    private int markerNum;
    private int markerGainNum;
    private int num;
    private int maxNum;
    private int damage;

    public string Title
    {
        get { return title; }
    }

    public bool Attack
    {
        get { return attack; }
    }
    
    public bool Focus
    {
        get { return focus; }
    }

    public bool Movement
    {
        get { return movement; }
    }

    public bool Trap
    {
        get { return trap; }
    }

    public bool Heal
    {
        get { return heal; }
    }

    public bool Shield
    {
        get { return shield; }
    }

    public int MarkerNum
    {
        get { return markerNum; }
        set { markerNum = value; }
    }

    public int MarkerGainNum
    {
        get { return markerGainNum; }
        set { markerGainNum = value; }
    }

    public int Num
    {
        get { return num; }
        set { num = value; }
    }

    public int MaxNum
    {
        get { return maxNum; }
        set { maxNum = value; }
    }

    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    // CONSTRUCTOR

    public Ability(string title, string activity, int num = 0, int maxNum = 0, int markerNum = 0, int markerGainNum = 0, int damage = 0)
    {
        this.title = title;
        this.attack = false;
        this.focus = false;
        this.movement = false;
        this.trap = false;
        this.heal = false;
        this.shield = false;
        this.markerNum = markerNum;
        this.markerGainNum = markerGainNum;
        this.num = num;
        this.maxNum = maxNum;
        this.damage = damage;

        switch (activity)
        {
            case "attack":
                this.attack = true;
                break;
            case "focus":
                this.focus = true;
                break;
            case "movement":
                this.movement = true;
                break;
            case "trap":
                this.trap = true;
                break;
            case "heal":
                this.heal = true;
                break;
            case "shield":
                this.shield = true;
                break;
            default:
                break;
        }
    }
}
