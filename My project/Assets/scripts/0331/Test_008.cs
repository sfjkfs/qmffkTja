using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player
{
    private int hp = 100;
    private int Power = 50;

    public void Attack()
    {
        Debug.Log(this.Power + " 데미지를 입혔다. ");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + " 데미지를 입었다. ");
    }
    public int GetHp()
    {
        return hp;
    }


}

public class Test_008 : MonoBehaviour
{
    public Text playerHp;
    public Text playerHp2;

    Player mPlayer = new Player();
    Player mPlayer2 = new Player();


    // Start is called before the first frame update
    void Start()
    {
       // mPlayer.Attack();
        //mPlayer.Damage(30);
       // Debug.Log(mPlayer.GetHp());
    }

    // Update is called once per frame
    void Update()
    {
        playerHp.text = "Plater1 HP : " + mPlayer.GetHp().ToString();
        playerHp2.text = "Player2 HP : " + mPlayer2.GetHp().ToString();

        if (Input.GetMouseButtonDown(0))
        {
            mPlayer.Damage(1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            mPlayer2.Damage(1);
        }
    }
}
