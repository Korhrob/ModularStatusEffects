using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularStatusEffects {

    [CreateAssetMenu(fileName = "DamageOverTime", menuName = "ModularStatusEffect/StatusEffectComponent/DamageOverTime")]
    public class ComponentDOT : StatusEffectComponent {

        public override void OnApply(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        }

        public override void OnExpire(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        }

        public override void OnRemove(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        }

        public override void OnTick(Character c, StatusEffectInstance instance, StatusEffectModule module) {

            // Implement your own function to take damage
            c.LocalTakeDamage(instance.damageData);

        }

    }

}