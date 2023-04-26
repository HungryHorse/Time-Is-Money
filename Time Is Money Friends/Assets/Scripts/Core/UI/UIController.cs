using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIM.Core.UI
{
    public class UIController : MonoBehaviour
    {
        private static UIController instance;
        public static UIController Instance => instance;

        [SerializeField]
        private AbilityPanelController abilityPanel;
        public AbilityPanelController AbilityPanel => abilityPanel;

        private void Awake()
        {
            if (instance != null)
            {
                throw new System.Exception("OI you have two singletons");
            }
            instance = this;
        }
    }
}
