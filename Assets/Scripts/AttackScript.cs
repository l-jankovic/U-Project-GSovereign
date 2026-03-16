using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public GameObject owner;
    public string animationName;
    [SerializeField] private bool specialAttack;
    [SerializeField] private float focusCost;
    [SerializeField] private float minAttackMul;
    [SerializeField] private float maxAttackMul;
    [SerializeField] private float minDefMul;
    [SerializeField] private float maxDefMul;
    private FighterStats attackerStats;
    private FighterStats targetStats;

    private float damage = 0.0f;
    private float xFocusNewScale;
    private Vector2 focusScale;
    
    
    
    void Start()
    {
        focusScale = GameObject.Find("Focus").GetComponent<RectTransform>().localScale;
        
    }

    public void attack(GameObject target)
    {/*
        attackerStats = owner.GetComponent<FighterStats>();
        targetStats = target.GetComponent<FighterStats>();
        if (attackerStats.focus >= focusCost)
        {
            float mul = Random.Range(minAttackMul, maxAttackMul);
          
            damage = mul * attackerStats.attack;
            if (specialAttack)
            {
                damage = mul * attackerStats.specialAttack;
                attackerStats.focus-=focusCost;
                attackerStats.updateFocusFill(focusCost);
               // owner.GetComponent<Animator>().Play(animationName);
            }
            float defenseMul=Random.Range(minDefMul, maxDefMul);
            damage = Mathf.Max(0,damage -( defenseMul*targetStats.defense));
            owner.GetComponent<Animator>().Play(animationName);
            targetStats.recieveDamage(damage);


        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
