using System;
using UnityEngine;

[Serializable]
public class Item1
{
    public enum Type
    {
        Cube,
        Ball,
    }

    public Type type;       //���
    public Sprite sprite;  //Slot�ɕ\������摜
}
