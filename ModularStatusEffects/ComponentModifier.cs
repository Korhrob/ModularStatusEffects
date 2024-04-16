using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularStatusEffects {

    [CreateAssetMenu(fileName = "Modifier", menuName = "ModularStatusEffect/StatusEffectComponent/Stat Modifier")]
    public class ComponentModifier : StatusEffectComponent {

        public StatusBonusType statusBonusType;
        public Stat.Type statusType;

        public override void OnApply(Character c, StatusEffectInstance instance, StatusEffectModule module) {

            if (statusBonusType == StatusBonusType.Penalty)
                module.value = -module.value;

            c.characterStatus.AddFinalStatusModifier(statusType, module.value);

        }

        public override void OnExpire(Character c, StatusEffectInstance instance, StatusEffectModule module) {

            if (statusBonusType == StatusBonusType.Penalty)
                module.value = -module.value;

            c.characterStatus.AddFinalStatusModifier(statusType, -module.value);

        }

        public override void OnRemove(Character c, StatusEffectInstance instance, StatusEffectModule module) {

            if (statusBonusType == StatusBonusType.Penalty)
                module.value = -module.value;

            c.characterStatus.AddFinalStatusModifier(statusType, -module.value);

        }

        public override void OnTick(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        }

    }

}