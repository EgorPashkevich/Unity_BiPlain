using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HealthPlayer = 100;
    public GameObject GameOver;
    
    public void TakeDamage(int Damage){
        HealthPlayer -= Damage;
    }

    private void Update() {
        if(HealthPlayer <= 0){
            SetActiveGameOver();
        }
    }
    public void SetActiveGameOver()
    {
        GameOver.SetActive(true);
        FindObjectOfType<PlayerMoveForward>().enabled = false;
    }
}
