using System;
using UnityEngine;

public class FighterStats : MonoBehaviour,IComparable
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject healthBar;
    [SerializeField] private GameObject focusBar;
    [SerializeField] private GameObject armorBar;
    [Header("Stats")] public float health;
    public float focus;
    public float baseAttack;
    public float armor;
    public float specialAttackBase;
    public float initiative;
    public float exp;
    
    
    public bool dead=false;
    private float startHealth;
    private float startFocus;
    private float startArmor;
    [HideInInspector] public int nextInTurn;
    
    //resize health and magic bar
    private Transform healthBarTransform;
    private Transform focusBarTransform;
    private Transform armorBarTransform;


    private Vector2 healthScale;
    private Vector2 focusScale;
    private Vector2 armorScale;

    private float xNewHealthScale;
    private float yNewArmorScale;
    private float xNewFocusScale;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBarTransform = healthBar.GetComponent<RectTransform>();
        healthScale = healthBarTransform.localScale;
        focusBarTransform = focusBar.GetComponent<RectTransform>();
        focusScale = focusBarTransform.localScale;
        armorBarTransform = armorBar.GetComponent<RectTransform>();
        armorScale = armorBarTransform.localScale;
        
        startHealth = health;
        startFocus= focus;
        startArmor = armor;
        
        
    }

    public void recieveDamage(float damage)
    {
        health -= damage;
        animator.Play("Damage");
        if (health <= 0)
        {
            dead = true;
            gameObject.tag = "Dead";
            Destroy(gameObject);

        }
        else {
            xNewHealthScale =healthScale.x*( health/startHealth);
            healthBar.transform.localScale = new Vector2(xNewHealthScale, healthBar.transform.localScale.y);
        }
    }

    public void updateFocusBar(float cost)
    {
        focus -= cost;
        xNewFocusScale=focusScale.x*( focus/startFocus);
        focusBar.transform.localScale = new Vector2(xNewFocusScale, focusBar.transform.localScale.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int CompareTo(object obj)
    {
        int next=nextInTurn.CompareTo(((FighterStats)obj).nextInTurn);
        return next;
    }
}
