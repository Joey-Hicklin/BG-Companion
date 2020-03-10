using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	// VARIABLES

	private string name;
	private int health;
	private int equipmentCost;
	private string itemType;

	public int Health
	{
		get { return this.health; }
		set { this.health = value; }
	}

	public string Name
	{
		get { return this.name; }
	}

	public int EquipmentCost
	{
		get { return this.equipmentCost; }
	}

	public string ItemType
	{
		get { return this.itemType; }
	}

	// CONSTRUCTOR

	public Item(string name, int health, int equipmentCost, string itemType)
	{
		this.name = name;
		this.health = health;
		this.equipmentCost = equipmentCost;
		this.itemType = itemType;
	}

	// HEALTH METHODS

	public void Damage(int changeAmount)
	{
		Health = Health - changeAmount;
	}

	public void Heal(int changeAmount)
	{
		Health = Health + changeAmount;
	}
}
