using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{

    [SerializeField]
    private Text GoldText;

    [SerializeField]
    private Player Base;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateGold(int gold)
    {
        GoldText.text = "Gold: " + gold;
    }
}
