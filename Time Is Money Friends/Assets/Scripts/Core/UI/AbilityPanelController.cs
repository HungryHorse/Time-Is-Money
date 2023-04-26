using System;
using System.Collections;
using System.Collections.Generic;
using TIM.Core.Abilities;
using UnityEngine;
using UnityEngine.UI;

namespace TIM.Core.UI
{
    public class AbilityPanelController : MonoBehaviour
    {
        [SerializeField]
        private Image primaryImage;
        private Image PrimaryImage => primaryImage;

        [SerializeField]
        private Image qImage;
        private Image QImage => qImage;

        [SerializeField]
        private Image eImage;
        private Image EImage => eImage;

        public Action<Slot> OnImageUpdated;

        public void UpdateImage(Sprite image, Slot slot)
        {
            switch (slot)
            {
                case Slot.Primary:
                    PrimaryImage.sprite = image;
                    break;
                case Slot.Q:
                    QImage.sprite = image;
                    break;
                case Slot.E:
                    EImage.sprite = image;
                    break;
            }
            OnImageUpdated?.Invoke(slot);
        }
    }
}
