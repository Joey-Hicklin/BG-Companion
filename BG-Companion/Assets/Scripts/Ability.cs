using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    // VARIABLES

    private string title;
    private string location;
    private List<string> activity;
    private bool attack;
    private bool focus;
    private bool movement;
    private bool trap;
    private bool heal;
    private bool shield;
    private int markerNum;
    private int markerGainNum;
    private int effectNum;
    private int maxNum;

    public string Title
    {
        get { return title; }
    }

    public string Location
    {
        get { return location; }
    }

    public List<string> Activity
    {
        get { return activity; }
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

    public int EffectNum
    {
        get { return effectNum; }
        set { effectNum = value; }
    }

    public int MaxNum
    {
        get { return maxNum; }
        set { maxNum = value; }
    }

    // CONSTRUCTOR

    public Ability(string title, string location, List<string> activity, int effectNum = 0, int maxNum = 0, int markerNum = 0, int markerGainNum = 0)
    {
        this.title = title;
        this.location = location;
        this.activity = activity;
        this.markerNum = markerNum;
        this.markerGainNum = markerGainNum;
        this.effectNum = effectNum;
        this.maxNum = maxNum;

        if (activity.Contains("attack")) { this.attack = true; }
        else this.attack = false;
        if (activity.Contains("focus")) { this.focus = true; }
        else this.focus = false;
        if (activity.Contains("movement")) { this.movement = true; }
        else this.movement = false;
        if (activity.Contains("trap")) { this.trap = true; }
        else this.trap = false;
        if (activity.Contains("heal")) { this.heal = true; }
        else this.heal = false;
        if (activity.Contains("shield")) { this.shield = true; }
        else this.shield = false;
    }
}
