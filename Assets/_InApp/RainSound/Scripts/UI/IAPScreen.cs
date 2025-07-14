using BabySound.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BabySound
{
    using SingleApp;

    public class IAPScreen : Singleton<IAPScreen>
    {
        [SerializeField] private BuyCoinButton[] _buttons;

        void Start()
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i].Index = i;
            }
        }
    }
}