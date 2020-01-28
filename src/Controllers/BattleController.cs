using Godot;
using System;
using Models;
using Base;
using System.Collections.Generic;

public class BattleController : Godot.Object
{
    
    public List<Combatant> CurrentCombatant {get; set;}

    public int TurnNumber;

    const int MAXALLIESNUMBER = 2;
    const int MAXENEMIESNUMBER = 2;

    public BattleController()
    {
        CurrentCombatant = new List<Combatant>();
        TurnNumber = 0;
    }

    public Boolean AddCombatant(string texturePath, Enumerators.eCombatantSide side)
    {
        try
        {
            Combatant newCombatant = new Combatant(texturePath, side);
            CurrentCombatant.Add(newCombatant);
            return true;
        }
        catch (Exception ex)
        {
            GD.Print(ex);
            return false;
        }
    }

}
