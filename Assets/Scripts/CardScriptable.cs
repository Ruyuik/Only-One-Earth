using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards/New Card")]
public class CardScriptable : ScriptableObject
{
    public string cardName;
    public string description;
    public bool isBuilding;
    public int tempEff;
    public int bioEff;
    public int powEff;
}
