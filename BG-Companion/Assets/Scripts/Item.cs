using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	// VARIABLES

	private string title;
	private int health;
	private int equipmentCost;
	private string itemType;
	private List<Ability> ability;

	public int Health
	{
		get { return this.health; }
		set { this.health = value; }
	}

	public string Title
	{
		get { return this.title; }
	}

	public int EquipmentCost
	{
		get { return this.equipmentCost; }
	}

	public string ItemType
	{
		get { return this.itemType; }
	}

	public List<Ability> Ability
	{
		get { return ability; }
		set { this.ability = value; }
	}

	// CONSTRUCTOR

	public Item(string title, int health, int equipmentCost, string itemType, List<Ability> ability)
	{
		this.title = title;
		this.health = health;
		this.equipmentCost = equipmentCost;
		this.itemType = itemType;
		this.ability = ability;
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
