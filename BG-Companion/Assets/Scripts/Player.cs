using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // VARIABLES

    private int ID;
    // TODO Combine device ID and datetime of character creation to generate unique ID
    private string title;
    private Item[] items;
    private int maxStamina;
    private int generatedStamina;
    private int maxDetermination;

    public string Title
    {
        get { return this.title; }
        set { this.title = value; }
    }

    public Item[] Items
    {
        get { return this.items; }
        set { this.items = value; }
    }

    public int MaxStamina
    {
        get { return this.maxStamina; }
        set { this.maxStamina = value; }
    }

    public int GeneratedStamina
    {
        get { return this.generatedStamina; }
        set { this.generatedStamina = value; }
    }

    public int MaxDetermination
    {
        get { return this.maxDetermination; }
        set { this.maxDetermination = value; }
    }
}
