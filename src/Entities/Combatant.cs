using Godot;
using System;
using System.Collection.Generics;

public class Combatant
{
	
	public List<Action> Moves;

	public int MaxHitPoints;
	public int CurrentHitPoints;

	public int MinDamage;
	public int MaxDamage;

	public int Protection;

	public int Initiative;

	public Combatant()
	{
		
	}

}
