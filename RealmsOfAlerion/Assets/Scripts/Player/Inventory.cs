using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [System.Serializable]
    public class Resources
    {
        public int food;
        public int wood;
        public int magic;
        public int mana;
        public int gold;
    }

    public Resources player1Resources;
    public Resources player2Resources;

}
