﻿using UnityEngine;
using System;
using System.Collections;

/// <summary>
/// <para>A pre-generated playable character with quest-related properites.</para>
/// <para>Purely for testing so far.</para>
/// </summary>
public class Kami : PlayableCharacter
{
    
    //quest points

    //quest-related method, subscribes to event

    /// <summary>
    /// Overloads the standard constructor.
    /// </summary>
    public Kami()
        : base("Kami",
          new int[5] { 1, 2, 3, 4, 5 },
          new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
          SpriteSetDatabase.inst.masterSpriteSet[0],
          BattleManager.BattlePositions.BACK) { Debug.Log("Constructing Kami"); }


}
