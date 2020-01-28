using Godot;
using System;

namespace Base {
    public class Enumerators
    {
        
        public enum eEffectType {

        }

        public enum eActionTarget {
            OneEnemy,
            AllEnemies,
            Self,
            Ally,
            AllParty
        }

        public enum eCombatantSide {
            Ally,
            Enemy
        }

    }
}