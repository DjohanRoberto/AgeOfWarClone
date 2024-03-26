using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int gold = 0;
    private int health = 100;

    [SerializeField]
    private UI_Manager uimanager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    // Gold Get, Set FNs
    public int getGold()
    {
        return this.gold;
    }

    public void addGold(int add)
    {
        this.gold += add;
        uimanager.updateGold(this.gold);
    }

    public void buy(int price)
    {
        this.gold -= price;
        uimanager.updateGold(this.gold);
    }


    // Health Get, Set FNs
    public int getHealth()
    {
        return this.health;
    }

    public void takeDmg(int dmg)
    {
        this.health -= dmg;
    }
}
