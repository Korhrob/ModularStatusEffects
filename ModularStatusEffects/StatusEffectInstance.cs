using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularStatusEffects {
    public class StatusEffectInstance {

        public float duration;
        public float durationElapsed;

        public ModularStatusEffect baseEffect { get; private set; }
        public DamageData damageData { get; private set; }
        public Character Source { get { return damageData.source; } }

        public StatusEffectInstance(Character source, ModularStatusEffect baseEffect) {

            this.duration = baseEffect.baseDuration;
            this.durationElapsed = 0;
            this.baseEffect = baseEffect;

            if (baseEffect.ContainsComponent<ComponentDOT>(out StatusEffectModule module)) {

                damageData = new DamageData(source);

                if (module.isPercentage) {

                    damageData.valueMultiplier = module.value;

                } else {

                    damageData.value = (int)module.value;
                    damageData.valueMultiplier = 1f;

                }

            }

        }

        public void OnApply(Character c) {

            foreach (StatusEffectModule module in baseEffect.modules) {

                module.component.OnApply(c, this, module);

            }

            if (baseEffect.visualEffectType == StatusVisualEffectType.OnApply) {

                VFX v = PrefabManager.instance.InstantiatePrefabType(baseEffect.visualEffect);
                v.Initialize(new PositionData(c.transform.position, Vector3.one), null);

            }

        }

        public void OnExpire(Character c) {

            foreach (StatusEffectModule module in baseEffect.modules) {

                module.component.OnExpire(c, this, module);

            }

        }

        public void OnRemove(Character c) {

            foreach (StatusEffectModule module in baseEffect.modules) {

                module.component.OnRemove(c, this, module);

            }

        }

        /// <summary>
        /// perform OnTick event of each modules component,
        /// if visualEffectType is set to OnTick then also spawn vfx
        /// </summary>
        /// <param name="c"></param>
        public void Tick(Character c) {

            foreach (StatusEffectModule module in baseEffect.modules) {

                module.component.OnTick(c, this, module);

            }

            if (baseEffect.visualEffectType == StatusVisualEffectType.OnTick) {

                VFX v = PrefabManager.instance.InstantiatePrefabType(baseEffect.visualEffect);
                v.Initialize(new PositionData(c.transform.position, Vector3.one), null);

            }

        }

        /// <summary>
        /// if any of the modules has ComponentCC of specific type, return true
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool HasCrowdControlType(StatusCCType type) {

            foreach (StatusEffectModule module in baseEffect.modules) {

                if (module.component is ComponentCC cc) {

                    if ((cc.statusControlType & type) != 0)
                        return true;

                }

            }

            return false;

        }

    }

}
