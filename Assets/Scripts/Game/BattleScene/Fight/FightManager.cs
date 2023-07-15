using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ս��������
/// </summary>
public class FightManager : MonoBehaviour
{
    private static FightManager instance;
    public static FightManager Instance => instance;

    public FightUnit fightUnit;//ս����Ԫ

    private void Awake()
    {
        instance = this;
    }

    public void ChnageType(E_FightType type)
    {
        switch (type)
        {
            case E_FightType.None:
                break;
            case E_FightType.Init:
                fightUnit = new FightInit();
                break;
            case E_FightType.Player:
                fightUnit = new PlayerTurn();
                break;
            case E_FightType.Enemy:
                fightUnit = new EnemyTurn();
                break;
            case E_FightType.Win:
                fightUnit = new FightWin();
                break;
            case E_FightType.Loss:
                fightUnit = new FightLose();
                break;
        }
        fightUnit.Init();
    }

    public void Update()
    {
        if(fightUnit != null)
        {
            fightUnit.OnUpdate();
        }
    }
}

//ս��ö��
public enum E_FightType { 
    None,
    Init,
    Player, //player turn
    Enemy, //enemy turn
    Win,
    Loss

}
