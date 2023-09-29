using System;

public class HealthSystem
{
    public event EventHandler OnHealthChanged;
    //this script does not need a gameobject attached to it. It live on its own. 
    private int health;
    private int healthMax;

    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }
    public int GetHealth()
    {
        return health;
    }

    public float GetHealthPercent()
    {
        return (float)health / healthMax;
    }

    //Damange   
    public void Damage(int damage)
    {
        health -= damage;
        if (health < 0) health = 0;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }


    // Heal da boy
    public void Heal(int healAmount) {
        health += healAmount;
        if(health > healthMax) health = healthMax;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }
}
