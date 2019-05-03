using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestNarrative : MonoBehaviour
{
    //private bool UpdateDone = false;

    public Image electricityBar;
    public Image foodBar;
    public Image localTempBar;

    public GameObject optionOne;
    public GameObject optionTwo;
    public GameObject optionThree;
    public GameObject optionFour;

    public int nextLevel = 1;

    public float optionOneHeatLoss = 0.1f;
    public float optionOneElectricityLoss = 0.1f;
    public float optionOneFoodLoss = 0.1f;
    public float optionTwoGain = 0.1f;
    public float optionTwoLoss = 0.1f;
    public float optionThreeGain = 0.1f;
    public float optionThreeLoss = 0.1f;
    public float optionFourGain = 0.1f;
    public float optionFourLoss = 0.1f;

    // Use this for initialization
    void Start ()
    {
        

        if (GameController.Instance.electricity == 0f)
        {
            optionOne.SetActive(false);
        }

        if (GameController.Instance.food == 0f)
        {
            optionOne.SetActive(false);
            optionTwo.SetActive(false);
            optionThree.SetActive(false);
            optionFour.SetActive(false);
        }

        foodBar.fillAmount = GameController.Instance.food;
        localTempBar.fillAmount = GameController.Instance.localTemp;
        electricityBar.fillAmount = GameController.Instance.electricity;

    }

    // Update is called once per frame
    void Update ()
    {

	}

    public void OptionOne()
    {
        GameController.Instance.electricity -= optionOneElectricityLoss;
        GameController.Instance.food -= optionOneFoodLoss;

        if (GameController.Instance.localTemp > optionOneHeatLoss)
        {
            GameController.Instance.localTemp -= optionOneHeatLoss;
        }
        else
        {
            GameController.Instance.localTemp = 0f;
        }
        SceneManager.LoadScene(nextLevel);
    }

    public void OptionTwo()
    {
        if (GameController.Instance.electricity < (1- optionTwoGain))
        {
            GameController.Instance.electricity += optionTwoGain;
        }
        else
        {
            GameController.Instance.electricity = 1f;
        }

        if (GameController.Instance.electricity > 0f)
        {
            optionOne.SetActive(true);
        }

        GameController.Instance.food -= optionTwoLoss;
        GameController.Instance.localTemp += 0.3f;
        optionTwo.SetActive(false);

        electricityBar.fillAmount = GameController.Instance.electricity;
        foodBar.fillAmount = GameController.Instance.food;
        localTempBar.fillAmount = GameController.Instance.localTemp;
    }

    public void OptionThree()
    {
        if (GameController.Instance.food < (1- optionThreeGain))
        {
            GameController.Instance.food += optionThreeGain;
        }
        else
        {
            GameController.Instance.food = 1f;
        }
        GameController.Instance.localTemp += 0.3f;
        optionThree.SetActive(false);

        electricityBar.fillAmount = GameController.Instance.electricity;
        foodBar.fillAmount = GameController.Instance.food;
        localTempBar.fillAmount = GameController.Instance.localTemp;
    }

    public void OptionFour()
    {
        
    }
}