using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class Spawner : ScriptableObject
{
    public int numbrerOfSpawn;

    public GameObject sphere;
}
