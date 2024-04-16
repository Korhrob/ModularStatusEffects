/* Modular Status Effects by Shiiiifttt (Robert Korhonen)
 * version 0.0.1
 * This is a modular status effect system build for Unity (tested in 2021.3.24f1)
 * using Scriptable Objects to make it easy to make and customize status effects
 * TODO:
 * StatusEffectManager
 * Make ComponentModifier type into flag that can have multiple stats
 * Implement VisualComponent and AudioComponent
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ModularStatusEffects {

    public enum StatusCCType {
        NoMove = 1 << 0,
        NoAttack = 1 << 1,
        NoCast = 1 << 2
    }
    // FreezeStateMachine

    public enum StatusBonusType {
        Bonus,
        Penalty
    }

    public enum StatusReapplyType {
        RefreshDuration,
        StackDuration,
        Stack,
        Immune
    }

    public enum StatusVisualEffectType {
        None,
        OnApply,
        OnTick
    }

    public enum StatusCustomVisualType {
        None,
        HideMesh,
        ColorMesh
    }

    [CreateAssetMenu(fileName = "Name", menuName = "ModularStatusEffect/New Status Effect")]
    public class ModularStatusEffect : ScriptableObject
    {

        public Sprite displayIcon;
        public string displayName;
        public float baseDuration;
        public StatusReapplyType reApplyType;

        public StatusVisualEffectType visualEffectType;
        public VFX visualEffect;
        public bool attachVFX;
        public StatusCustomVisualType customVisualType;

        public StatusVisualEffectType soundEffectType;
        public AudioClip soundEffect;

        public StatusEffectModule[] modules;

        /// <summary>
        /// returns true if any of the modules has a component T
        /// </summary>
        /// <typeparam name="T">StatusEffectComponent</typeparam>
        /// <param name="module">module containing T</param>
        /// <returns></returns>
        public bool ContainsComponent<T>(out StatusEffectModule module) where T : StatusEffectComponent {

            module = null;

            for (var i = 0; i < modules.Length; i++) {

                if (modules[i].component is T) {
                    module = modules[i];
                    return true;
                }

            }

            return false;

        }

    }

}
