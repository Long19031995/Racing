using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "Racing/PlayerSO", order = 0)]
public class PlayerSO : ScriptableObject
{
    public List<GameObject> prefabs;
}
