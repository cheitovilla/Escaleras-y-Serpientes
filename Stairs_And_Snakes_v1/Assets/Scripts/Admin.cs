using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Admin : MonoBehaviour
{
    public int numRND; // number Random
    public Text textDice; //text shown this number
    public GameObject player; //the player one
    public int cont;

    //function dice
    public void NumberRND()
    {
        numRND = Random.Range(1, 7);
        Debug.Log("El numero random es: " + numRND);
        textDice.text = numRND.ToString();
        StartCoroutine("MovementPlayer");
    }

    //wait for movement
    public IEnumerator MovementPlayer()
    {
        for (int i = 0; i < numRND; i++)
        {
            cont = cont + 1;
            if (cont < 6)
            {
                yield return new WaitForSeconds(1f);
                iTween.MoveBy(player, iTween.Hash("x", 180, "time", 0.4f));
                Debug.Log("contaodor: " + cont);
            }
            else if (cont == 6)
            {
                yield return new WaitForSeconds(1f);
                iTween.MoveBy(player, iTween.Hash("y", 180, "time", 0.4f));
                Debug.Log("contaodor: " + cont);
            }
            else if (cont > 6 && cont < 11)
            {
                yield return new WaitForSeconds(1f);
                iTween.MoveBy(player, iTween.Hash("x", -180, "time", 0.4f));
                Debug.Log("contaodor: " + cont);
            }
            else if (cont == 11)
            {
                yield return new WaitForSeconds(1f);
                iTween.MoveBy(player, iTween.Hash("y", 180, "time", 0.4f));
                Debug.Log("contaodor: " + cont);
            }
            else if (cont > 11 && cont <16) 
            {
                yield return new WaitForSeconds(1f);
                iTween.MoveBy(player, iTween.Hash("x", 180, "time", 0.4f));
                Debug.Log("contaodor: " + cont);
            }
            else if (cont == 16)
            {
                yield return new WaitForSeconds(1f);
                iTween.MoveBy(player, iTween.Hash("y", 180, "time", 0.4f));
                Debug.Log("contaodor: " + cont);
            }
            else if (cont > 16 && cont < 21)
            {
                yield return new WaitForSeconds(1f);
                iTween.MoveBy(player, iTween.Hash("x", -180, "time", 0.4f));
                Debug.Log("contaodor: " + cont);
            }
            else if (cont == 21)
            {
                yield return new WaitForSeconds(1f);
                iTween.MoveBy(player, iTween.Hash("y", 180, "time", 0.4f));
                Debug.Log("contaodor: " + cont);
            }
            else if (cont > 21 && cont < 26)
            {
                yield return new WaitForSeconds(1f);
                iTween.MoveBy(player, iTween.Hash("x", 180, "time", 0.4f));
                Debug.Log("contaodor: " + cont);
            }
        }
        yield return null;
    }

    //reload scene
    public void ReloadScene()
    {
        SceneManager.LoadScene("Game");
    }

}
