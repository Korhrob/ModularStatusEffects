using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularStatusEffects {

    [CreateAssetMenu(fileName = "CopyTargetPosition", menuName = "ModularStatusEffect/StatusEffectComponent/CopyTargetPosition")]
    public class ComponentCopyTargetPosition : StatusEffectComponent {

        // CopyTargetPosition itself doesnt do anything, Character handles this

        public override void OnApply(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        }

        public override void OnExpire(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        }

        public override void OnRemove(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        }

        public override void OnTick(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        }

    }

}