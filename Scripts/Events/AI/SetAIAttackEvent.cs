using Godot;
using System;

namespace EventCallback
{
    public class SetAIAttackEvent : Event<SetAIAttackEvent>
    {
        //The active state for the AI state class
        public bool active;
    }
}
