using UnityEngine;

public class GameHandler : MonoBehaviour
{

    //This game handler need to be on a gameobject but can call that constructor from anywhere. 
    public Transform pfHealthBar;
    void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);
        
        Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0,.6f), Quaternion.identity);
        HealthBar healthbar = healthBarTransform.GetComponent<HealthBar>();
        healthbar.Setup(healthSystem);
        healthSystem.Damage(10);
    }

   
}
