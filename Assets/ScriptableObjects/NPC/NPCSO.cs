using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPC", menuName = "ScriptableObjects/NPCScriptableObjects", order = 1)]

public class NPCSO : ScriptableObject
{
    public string npcName;
    public string street;
    public int maxTip;
    public int minTip;
    public float maxTime;
    public float minTime;
}
