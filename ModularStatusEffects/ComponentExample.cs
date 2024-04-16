using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ModularStatusEffects;

[CreateAssetMenu(fileName = "Example", menuName = "ModularStatusEffect/StatusEffectComponent/CrowdControl")]
public class ComponentExample : StatusEffectComponent {


    public override void OnApply(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        // Stuff you want to do when status is applied on character

    }

    public override void OnExpire(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        // Stuff you want to do when status expires naturally

    }

    public override void OnRemove(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        // Stuff you want to do when status is removed

    }

    public override void OnTick(Character c, StatusEffectInstance instance, StatusEffectModule module) {

        // Stuff that happens at regular intervals

    }

}
