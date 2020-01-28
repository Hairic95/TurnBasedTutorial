using Godot;
using System;
using Base;
using Models;

public class BattleScene : Node2D
{

    BattleController battleController;

    [Export]
    PackedScene CombatantComponentView_Referene = (PackedScene)GD.Load("res://src/Views/Components/Combatant/CombatantViewComponent.tscn");

    public override void _Ready()
    {
        battleController = new BattleController();
        battleController.AddCombatant("res://assets/warrior1.png", Enumerators.eCombatantSide.Ally);
        battleController.AddCombatant("res://assets/warrior2.png", Enumerators.eCombatantSide.Ally);
        
        battleController.AddCombatant("res://assets/enemy1.png", Enumerators.eCombatantSide.Enemy);
        battleController.AddCombatant("res://assets/enemy2.png", Enumerators.eCombatantSide.Enemy);

        int numberOfAllies = 1;
        int numberOfEnemies = 1;

        foreach(Combatant c in battleController.CurrentCombatant)
        {
            switch(c.Side)
            {
                case (Enumerators.eCombatantSide.Ally):
                    var newAlly = (Sprite)CombatantComponentView_Referene.Instance();
                    newAlly.Texture = c.CharacterModel;
                    newAlly.Position = ((Position2D) GetNode("Arena/StartingPosition/Ally" + numberOfAllies)).Position;
                    GetNode("Arena/CombatantViews").AddChild(newAlly);
                    numberOfAllies += 1;
                    break;
                case (Enumerators.eCombatantSide.Enemy):
                    var newEnemy = (Sprite)CombatantComponentView_Referene.Instance();
                    newEnemy.Texture = c.CharacterModel;
                    newEnemy.Position = ((Position2D) GetNode("Arena/StartingPosition/Enemy" + numberOfEnemies)).Position;
                    GetNode("Arena/CombatantViews").AddChild(newEnemy);
                    numberOfEnemies += 1;
                    break;
            }
        }
    }

}
