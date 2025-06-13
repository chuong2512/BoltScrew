using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NultBolts
{
    using SingleApp;

    public class HoleBuy : Singleton<HoleBuy>
    {
        public GameObject hole;
        
        public void Newhole()
        {
            hole.SetActive(true);
        }
    }
}
