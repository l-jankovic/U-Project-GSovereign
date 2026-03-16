using System;
using UnityEngine;
using UnityEngine.UI;

public class InitializeButtons : MonoBehaviour
{
    [SerializeField] bool isPhysical;
    private GameObject player;
    void Start()
    {

        string btnName = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => callBackOnClick(btnName));
        player = GameObject.FindWithTag("Player");
    }


    private void callBackOnClick(string btnName){

        switch (btnName.ToLower())
        {
            case "standardattack":
                player.GetComponent<BulwarkAction>().selectAttack("StandardAttack");
                break;
            case "special1attack":
                player.GetComponent<BulwarkAction>().selectAttack("special1attack");
                break;
            case "special2attack":
                player.GetComponent<BulwarkAction>().selectAttack("special2attack");
                break;
            default:
                Debug.LogWarning("[InitializeButtons] Unknown button name: ]" + btnName);
                break;
        }
        
    }


}
