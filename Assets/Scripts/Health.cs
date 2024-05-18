using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
  //variable for the gamr
    public int maxHealth;       
    public int currentHealth;   

    //store visual representation of health
    public GameObject hp1;      
    public GameObject hp2;


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 2;                 
        currentHealth = maxHealth;
    }

    //Function for when the player takes damages
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;                        //lower health

        if (currentHealth == 2)                         //if health equal two
        {
            hp2.SetActive(false);                       //lose a heart
        }
        if (currentHealth == 1)                         //if health equal one
        {
            hp1.SetActive(false);                       //lose a heart
        }

        if (currentHealth <= 0)                         //if health equal zero
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
