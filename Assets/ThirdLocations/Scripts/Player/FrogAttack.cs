using UnityEngine;

public class FrogAttack : MonoBehaviour
{
    public static FrogAttack FrogAttackInstance;
    public bool CanAttack = true;
    
    private void Update()
    {
        Attack();
        FrogAttackInstance = this;
    }
    
    private void Attack()
    {
        if (Input.GetButtonDown("Fire1") && CanAttack)
        {
            PlayerAnimation.PlayerAnimationInstance.AttackAnimating();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<CaterpillarMovement>() != null)
        {
            CaterpillarRespawn.Spawned--;
            Destroy(other.gameObject);
            FrogExpirienceController._currentExpirience++;
        }
    }
}