using Godot;
using System;
using System.Collections.Generic;
using Base;

namespace Models {
	public class Combatant
	{
		
		public List<Action> Moves;

		public int MaxHitPoints;
		public int CurrentHitPoints;

		public int MinDamage;
		public int MaxDamage;

		public int Protection;

		public int Initiative;

		public Enumerators.eCombatantSide Side;

		public Texture CharacterModel;

		protected Combatant()
		{
			Moves = new List<Action>();
		}

		public Combatant(string texturePath, Enumerators.eCombatantSide side)
		{
			Side = side;
			CharacterModel = (Texture)GD.Load(texturePath);
		}

		public Combatant(int hitPoints,
						int minDamage,
						int maxDamage,
						int protection,
						int initiative,
						string texturePath,
						Enumerators.eCombatantSide side)
		{
			MaxHitPoints = hitPoints;
			CurrentHitPoints = hitPoints;
			MinDamage = minDamage;
			MaxDamage = maxDamage;
			Protection = protection;
			Initiative = initiative;
			Side = side;
			CharacterModel = (Texture)GD.Load(texturePath);
		}

	}
}