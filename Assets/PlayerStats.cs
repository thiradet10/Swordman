using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth = 100f;
    public float health;

    private bool canTakeDamage = true;

    private Animator anim;

    // UI / GameOver refs
    public HealthBar healthBar;       // �ҡ�ͺ�� HealthBar ŧ� Inspector
    public GameOverUI gameOverUI;     // �ҡ�ͺ�� GameOverUI (panel) ŧ� Inspector

    void Start()
    {
        anim = GetComponentInParent<Animator>();
        health = maxHealth;

        // ��駤������������ UI (�����)
        if (healthBar != null)
        {
            healthBar.SetMaxHealth(maxHealth);
            healthBar.SetHealth(health);
        }
    }

    // ���¡�����ⴹ����
    public void TakeDamage(float damage)
    {
        if (!canTakeDamage)
        {
            return;
        }

        health -= damage;
        if (health < 0) health = 0;

        anim.SetBool("Damage", true);

        // �Ѿവ UI
        if (healthBar != null)
        {
            healthBar.SetHealth(health);
        }

        if (health <= 0)
        {
            // �Դ collider / �Ǻ��� ����駵��
            var poly = GetComponent<PolygonCollider2D>();
            if (poly != null) poly.enabled = false;

            var gather = GetComponentInParent<GatherInput>();
            if (gather != null) gather.DisableControls();

            Debug.Log("Player is dead");

            // �ʴ� Game Over (�����)
            if (gameOverUI != null)
            {
                gameOverUI.ShowGameOver();
            }
        }

        StartCoroutine(DamagePrevention());
    }

    private IEnumerator DamagePrevention()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(0.15f);
        if (health > 0)
        {
            canTakeDamage = true;
            anim.SetBool("Damage", false);
        }
        else
        {
            anim.SetBool("Death", true);
        }
    }
}
