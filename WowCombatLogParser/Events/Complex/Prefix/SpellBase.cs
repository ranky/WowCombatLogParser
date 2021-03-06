﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWCombatLogParser.Models;
using Spells = WoWCombatLogParser.Events.Parts;

namespace WoWCombatLogParser.Events.Complex.Prefix
{
    public class SpellBase : EventSection
    {
        [FieldOrder(1)]
        public Spells.Spell Spell { get; } = new Spells.Spell();        
    }
}
