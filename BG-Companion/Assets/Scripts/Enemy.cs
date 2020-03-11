using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	// VARIABLES

	private int id;
	private int health;
	private bool activated;
	private string enemyType;
	private bool strong;
	private bool grouped;
	private int groupNum;
	private int groupMove;
	private int singleMove;

	public int Health
	{
		get { return this.health; }
		set { this.health = value; }
	}

	public int ID
	{
		get { return this.id; }
	}

	public bool Activated
	{
		get { return this.activated; }
		set { this.activated = value; }
	}

	public string EnemyType
	{
		get { return this.enemyType; }
	}

	public bool Strong
	{
		get { return this.strong; }
	}

	public bool Grouped
	{
		get { return this.grouped; }
		set { this.grouped = value; }
	}

	public int GroupNum
	{
		get { return this.groupNum; }
		set { this.groupNum = value; }
	}

	public int GroupMove
	{
		get { return this.groupMove; }
		set { this.groupMove = value; }
	}

	public int SingleMove
	{
		get { return this.singleMove; }
		set { this.singleMove = value; }
	}

	// CONSTRUCTOR

	public Enemy(int id, int health, string enemyType, bool strong)
	{
		this.id = id;
		this.health = health;
		this.activated = false;
		this.enemyType = enemyType;
		this.strong = strong;
		this.grouped = false;
		this.groupNum = 0;
		this.groupMove = 0;
		this.singleMove = 0;
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
