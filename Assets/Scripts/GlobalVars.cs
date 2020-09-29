﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Rock,
    Paper,
    Scissor
}

public enum Player
{
    R,
    L
}

public enum PlayerMode
{
    UI,
    API
}

public enum WeaponAttribute
{
    Attack,
    Defense
}

public enum MenuState
{
    NaN,
    BuyPhaseMenu,
    BuyMenu,
    ActionPhaseMenu,
    UseMenu,
    UpgradeMenu,
    AttackPhaseMenu
}

public enum GamePhase
{
    BuyPhase,
    ActionPhase,
    AttackPhase,
    IdlePhase
}

public class GlobalVars : MonoBehaviour
{
    public static GlobalVars instance;

    //CONSTANTS
    public static readonly float INIT_ATTACK = 1.0f;
    public static readonly float INIT_DEFENSE = 1.0f;

    public static readonly List<int> WEAPON_LEVEL_UPGRADE_PRICES = new List<int> { 5, 10, 20, 40 };
    public static readonly List<float> WEAPON_LEVEL_UPGRADE_AMOUNT = new List<float> { 0.5f, 0.5f, 0.5f, 0.5f };

    //RUNTIME
    public int maxWeaponLevel;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        maxWeaponLevel = WEAPON_LEVEL_UPGRADE_PRICES.Count;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
