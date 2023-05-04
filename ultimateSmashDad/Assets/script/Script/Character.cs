using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    // Start is called before the first frame update
    public string characterName;
    public Sprite characterSprite;
}
