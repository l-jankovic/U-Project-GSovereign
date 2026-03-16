using UnityEngine;

public class BulwarkAction : MonoBehaviour
{
    private GameObject player;
    private GameObject enemy;

    [SerializeField]
    private GameObject standardAttackPrefab;
    [SerializeField]
    private GameObject speciialAttackPrefab;

    [SerializeField] 
    private Sprite faceIcon;

    private GameObject currentAttack;
    private GameObject stdAttack;
    private GameObject special1Attack;

    public void selectAttack(string btn)
    {
        GameObject victim = tag == "Hero" ? enemy : player;
        switch (btn.ToLower())
        {
            case "standardattack":
                stdAttack.GetComponent<AttackScript>().attack(victim);
                Debug.Log("Melee is preformed");
                break;
            case "special1attack":
                special1Attack.GetComponent<AttackScript>().attack(victim);

                Debug.Log("Special is preformed");
                break;
            case "special2attack":
                Debug.Log("Special2 is preformed");
                
                break;
            default:
                Debug.LogWarning("[InitializeButtons] Unknown attack name: ]" + btn);
                break;
        }
    }
}
