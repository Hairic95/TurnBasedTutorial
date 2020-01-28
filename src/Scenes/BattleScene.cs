using Godot;
using System;
using Base;
using Models;

public class BattleScene : Node2D
{

    BattleController battleController;

    [Export]
    PackedScene CombatantComponentView_Referene;

    public override void _Ready()
    {
        battleController = new BattleController();
        battleController.AddCombatant("res://assets/warrior1.png", Enumerators.eCombatantSide.Ally);
        battleController.AddCombatant("res://assets/warrior2.png", Enumerators.eCombatantSide.Ally);
        
        battleController.AddCombatant("res://assets/enemy1.png", Enumerators.eCombatantSide.Enemy);
        battleController.AddCombatant("res://assets/enemy2.png", Enumerators.eCombatantSide.Enemy);

        foreach(Combatant c in battleController.CurrentCombatant)
        {
            switch(c.Side)
            {
                case (Enumerators.eCombatantSide.Ally):
                    var newAlly = (Sprite)CombatantComponentView_Referene.Instance();
                    newAlly.Texture = c.CharacterModel;
                    GetNode("CombantViews").AddChild(newAlly);
                    break;
                case (Enumerators.eCombatantSide.Enemy):
                    var newEnemy = (Sprite)CombatantComponentView_Referene.Instance();
                    newEnemy.Texture = c.CharacterModel;
                    GetNode("CombantViews").AddChild(newEnemy);
                    newEnemy.Position = ((Position2D) GetNode(@"Positions\Enemy2")).Position;
                    break;
            }
        }
    }

}
