﻿using UnityEngine;
using System.Collections;

/// <summary>
/// A character's in-battle representation.
/// </summary>
public class Battler : MonoBehaviour
{
    //the set point every Battler returns to after an animation
    private Vector3 homePos;
    public Vector3 HomePos { get { return homePos; } }

    public int batID;       //ID of the Battler

    //which team
    public bool allied;
    
    

    public BattleManager.BattlePositions pos;

    public Character combatant;     //Must be set after Initialize()!

    //battle stats; must be set after Initialize()/Awake()!
    public int ATBmax;
    public int ATBcount;

    public int barrier;


    public BattleAction intendedAction;

    //Initialize battle stats
    void Start()
    {
        this.allied = combatant.Allied; //set to corresponding team, possibly redundant
        homePos = transform.position;   //set "home" position to initial position
        this.pos = combatant.pos;       //set position, possibly redundant
    }

    /// <summary>
    /// Increments ATB and all passive effects if able.
    /// </summary>
    /// <returns>True if the combatant is ready and able to take an action.</returns>
    public bool tick()
    {
        bool able = true;
        //check, bump ATB
        //check, bump stam
        //inc buffs
        //passive effects
        return able && ATBcount > ATBmax;
    }

    /// <summary>
    /// The battler determines their next action based on AI or player control.
    /// </summary>
    /// <returns>The combatant's next intended action.</returns>
    public BattleAction nextAction()
    {
        /* TEST AI */
        if (allied)     //for Kami
        {

        }
        else            //for enemies
        {
            
        }
        return null;
    }

    //post-battle operations
}
