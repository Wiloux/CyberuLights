using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CharaCellule", menuName =("CharaCellule"))]
public class CharaCell : ScriptableObject
{
    public string Name;
    public Sprite Sprite;
    public float Zoom;
}
