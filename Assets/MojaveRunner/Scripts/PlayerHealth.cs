using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healthAmount = 3;

    public void TakeDamage(int damageAmount)
    {
        healthAmount -= damageAmount;

        if (healthAmount <= 0 )
        {
            GameManager.instance.Restart();
        }
    }

    public static void TryDamageTarget(GameObject target, int damageAmount)
    {
        PlayerHealth targetHealth = target.GetComponent<PlayerHealth>(); //PlayerHealth is gettng that info from the class name space here. Because it is static.

        if (targetHealth)
        {
            targetHealth.TakeDamage(damageAmount);
        }
    }


}
