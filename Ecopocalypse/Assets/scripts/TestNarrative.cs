﻿using System.Collections;
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

    public GameObject driving;
    public GameObject boiling;
    public GameObject engine;

    public Text description;
    public Text latitudeText;
    public Text chargeFuel;

    public float optionOnePosOne = 0.1f;
    public float optionOnePosTwo = 0.1f;
    public float optionOneNegOne = 0.1f;
    public float optionOneNegTwo = 0.1f;
    public float optionOneNegThree = 0.1f;
    public float optionTwoPosOne = 0.1f;
    public float optionTwoPosTwo = 0.1f;
    public float optionTwoNegOne = 0.1f;
    public float optionTwoNegTwo = 0.1f;
    public float optionTwoNegThree = 0.1f;
    public float optionThreePosOne = 0.1f;
    public float optionThreePosTwo = 0.1f;
    public float optionThreeNegOne = 0.1f;
    public float optionThreeNegTwo = 0.1f;
    public float optionThreeNegThree = 0.1f;
    public float optionFourPosOne = 0.1f;
    public float optionFourPosTwo = 0.1f;
    public float optionFourNegOne = 0.1f;
    public float optionFourNegTwo = 0.1f;
    public float optionFourNegThree = 0.1f;

    public float opOneDistance = 1f;
    public float opTwoDistance = 1f;
    public float opThreeDistance = 1f;
    public float opFourDistance = 1f;

    public bool opOnePetrol = false;
    public bool opTwoPetrol = false;
    public bool opThreePetrol = false;
    public bool opFourPetrol = false;

    public int buttFuncOne = 0;
    public int buttFuncTwo = 0;
    public int buttFuncThree = 0;
    public int buttFuncFour = 0;

    public int opOneScene = 1;
    public int opTwoScene = 1;
    public int opThreeScene = 1;
    public int opFourScene = 1;

    public int backTrack = 0;

    public bool opOneMove = false;
    public bool opTwoMove = false;
    public bool opThreeMove = false;
    public bool opFourMove = false;

    public bool opOneOnce = true;
    public bool opTwoOnce = true;
    public bool opThreeOnce = true;
    public bool opFourOnce = true;

    public bool electricityOp = true;
    public bool fuelOp = true;

    // Use this for initialization
    void Start ()
    {
        if (GameController.Instance.electricity == 0f)
        {
            if (electricityOp == false)
            {
                description.text = "your batteries have run dry and you cannot find a way to keep your vehicle running";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (fuelOp == false)
            {
                description.text = "you run out of fuel and can't find any more nearby";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }
        }

        if (GameController.Instance.petrolCar == true)
        {
            chargeFuel.text = "Fuel";
        }
        else
        {
            chargeFuel.text = "Charge";
        }

        foodBar.fillAmount = GameController.Instance.food;
        localTempBar.fillAmount = GameController.Instance.localTemp;
        electricityBar.fillAmount = GameController.Instance.electricity;

        latitudeText.text = "latitude: " + GameController.Instance.latitudeFloat.ToString() + "/30";

        if (GameController.Instance.petrolCar == true)
        {
            if (opOnePetrol == false)
            {
                optionOne.SetActive(false);
            }
            if (opTwoPetrol == false)
            {
                optionTwo.SetActive(false);
            }
            if (opThreePetrol == false)
            {
                optionThree.SetActive(false);
            }
            if (opFourPetrol == false)
            {
                optionFour.SetActive(false);
            }
        }

        if (GameController.Instance.electricity == 0f)
        {
            if (opOneMove == true)
            {
                optionOne.SetActive(false);
            }
            if (opTwoMove == true)
            {
                optionTwo.SetActive(false);
            }
            if (opThreeMove == true)
            {
                optionThree.SetActive(false);
            }
            if (opFourMove == true)
            {
                optionFour.SetActive(false);
            }
        }

        if (GameController.Instance.food == 0f)
        {
            description.text = "you starve to death";

            optionOne.SetActive(false);
            optionTwo.SetActive(false);
            optionThree.SetActive(false);
            optionFour.SetActive(false);
        }

        if (GameController.Instance.localTemp == 1f)
        {
            description.text = "you are caught by a heat wave and overheat";

            optionOne.SetActive(false);
            optionTwo.SetActive(false);
            optionThree.SetActive(false);
            optionFour.SetActive(false);
        }

        if (GameController.Instance.backTracked == true)
        {
            if (buttFuncOne == 3)
            {
                optionOne.SetActive(false);
            }

            if (buttFuncTwo == 3)
            {
                optionTwo.SetActive(false);
            }

            if (buttFuncThree == 3)
            {
                optionThree.SetActive(false);
            }

            if (buttFuncFour == 3)
            {
                optionFour.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update ()
    {

	}

    public void ElecCar()
    {
        GameController.Instance.petrolCar = false;
        SceneManager.LoadScene(1);
    }

    public void PetCar()
    {
        GameController.Instance.petrolCar = true;
        SceneManager.LoadScene(1);
    }

    public void OpOneDrive()
    {
        GameController.Instance.latitudeFloat += opOneDistance;
        SceneManager.LoadScene(opOneScene);
        optionOne.SetActive(true);
    }

    public void OpTwoDrive()
    {
        GameController.Instance.latitudeFloat += opOneDistance;
        SceneManager.LoadScene(opTwoScene);
        optionTwo.SetActive(true);
    }

    public void OpThreeDrive()
    {
        GameController.Instance.latitudeFloat += opOneDistance;
        SceneManager.LoadScene(opThreeScene);
        optionThree.SetActive(true);
    }

    public void OpFourDrive()
    {
        GameController.Instance.latitudeFloat += opOneDistance;
        SceneManager.LoadScene(opFourScene);
        optionFour.SetActive(true);
    }

    public void OpOneBackTrack()
    {
        GameController.Instance.latitudeFloat -= opOneDistance;
        SceneManager.LoadScene(backTrack);
        optionOne.SetActive(true);
    }

    public void OpTwoBackTrack()
    {
        GameController.Instance.latitudeFloat -= opOneDistance;
        SceneManager.LoadScene(backTrack);
        optionTwo.SetActive(true);
    }

    public void OpThreeBackTrack()
    {
        GameController.Instance.latitudeFloat -= opOneDistance;
        SceneManager.LoadScene(backTrack);
        optionThree.SetActive(true);
    }

    public void OpFourBackTrack()
    {
        GameController.Instance.latitudeFloat -= opOneDistance;
        SceneManager.LoadScene(backTrack);
        optionFour.SetActive(true);
    }

    public void SilenceBoil()
    {
        boiling.SetActive(false);
    }

    public void OptionOne()
    {
        if (buttFuncOne == 0)
        {
            if (GameController.Instance.electricity > optionOneNegOne)
            {
                GameController.Instance.electricity -= optionOneNegOne;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.food > optionOneNegOne)
            {
                GameController.Instance.food -= optionOneNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.localTemp > optionOnePosOne)
            {
                GameController.Instance.localTemp -= optionOnePosOne;
            }
            else
            {
                GameController.Instance.localTemp = 0f;
            }

            GameController.Instance.backTracked = false;

            driving.SetActive(true);

            if (GameController.Instance.petrolCar == true)
            {
                engine.SetActive(true);
            }

            optionOne.SetActive(false);

            Invoke("OpOneDrive", 4f);
        }

        if (buttFuncOne == 1)
        {
            if (opOnePetrol == true && GameController.Instance.petrolCar == true)
            {
                if (GameController.Instance.electricity < (1 - (1.5f * optionOnePosOne)))
                {
                    GameController.Instance.electricity += (1.5f * optionOnePosOne);
                }
                else
                {
                    GameController.Instance.electricity = 1f;
                }
            }

            if (GameController.Instance.petrolCar == false)
            {
                if (GameController.Instance.electricity < (1 - optionOnePosOne))
                {
                    GameController.Instance.electricity += optionOnePosOne;
                }
                else
                {
                    GameController.Instance.electricity = 1f;
                }
            }

            if (GameController.Instance.electricity > 0f)
            {
                if (opOneMove == false)
                {
                    optionOne.SetActive(true);
                }
                if (opTwoMove == false)
                {
                    optionTwo.SetActive(true);
                }
                if (opThreeMove == false)
                {
                    optionThree.SetActive(true);
                }
                if (opFourMove == false)
                {
                    optionFour.SetActive(true);
                }
            }

            if (GameController.Instance.food > optionOneNegOne)
            {
                GameController.Instance.food -= optionOneNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionOneNegTwo))
            {
                GameController.Instance.localTemp += optionOneNegTwo;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            if (opOneOnce == true)
            {
                optionOne.SetActive(false);
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            boiling.SetActive(true);

            Invoke("SilenceBoil", 3f);
        }

        if (buttFuncOne == 2)
        {
            if (GameController.Instance.food < (1 - optionOnePosOne))
            {
                GameController.Instance.food += optionOnePosOne;
            }
            else
            {
                GameController.Instance.food = 1f;
            }

            if (GameController.Instance.electricity == 0f)
            {
                if (opOneMove == true)
                {
                    optionOne.SetActive(false);
                }
                if (opTwoMove == true)
                {
                    optionTwo.SetActive(false);
                }
                if (opThreeMove == true)
                {
                    optionThree.SetActive(false);
                }
                if (opFourMove == true)
                {
                    optionFour.SetActive(false);
                }
            }

            if (GameController.Instance.electricity > optionOneNegOne)
            {
                GameController.Instance.electricity -= optionOneNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionOneNegTwo))
            {
                GameController.Instance.localTemp += optionOneNegTwo;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            if (opOneOnce == true)
            {
                optionOne.SetActive(false);
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }
        }

        if (buttFuncOne == 3)
        {
            if (GameController.Instance.food > optionOneNegOne)
            {
                GameController.Instance.food -= optionOneNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.electricity > optionOneNegTwo)
            {
                GameController.Instance.electricity -= optionOneNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionOneNegThree))
            {
                GameController.Instance.localTemp += optionOneNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            GameController.Instance.backTracked = true;

            Invoke("OpOneBackTrack", 4f);
        }
    }

    public void OptionTwo()
    {
        if (buttFuncTwo == 0)
        {
            if (GameController.Instance.food > optionTwoNegOne)
            {
                GameController.Instance.food -= optionTwoNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.electricity > optionTwoNegTwo)
            {
                GameController.Instance.electricity -= optionTwoNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp > optionTwoPosOne)
            {
                GameController.Instance.localTemp -= optionTwoPosOne;
            }
            else
            {
                GameController.Instance.localTemp = 0f;
            }

            GameController.Instance.backTracked = false;

            driving.SetActive(true);

            if (GameController.Instance.petrolCar == true)
            {
                engine.SetActive(true);
            }

            optionTwo.SetActive(false);

            Invoke("OpTwoDrive", 4f);
        }

        if (buttFuncTwo == 1)
        {
            if (opTwoPetrol == true && GameController.Instance.petrolCar == true)
            {
                if (GameController.Instance.electricity < (1 - (1.5f * optionTwoPosOne)))
                {
                    GameController.Instance.electricity += (1.5f * optionTwoPosOne);
                }
                else
                {
                    GameController.Instance.electricity = 1f;
                }
            }

            if (GameController.Instance.petrolCar == false)
            {
                if (GameController.Instance.electricity < (1 - optionTwoPosOne))
                {
                    GameController.Instance.electricity += optionTwoPosOne;
                }
                else
                {
                    GameController.Instance.electricity = 1f;
                }
            }

            if (GameController.Instance.electricity > 0f)
            {
                if (opOneMove == false)
                {
                    optionOne.SetActive(true);
                }
                if (opTwoMove == false)
                {
                    optionTwo.SetActive(true);
                }
                if (opThreeMove == false)
                {
                    optionThree.SetActive(true);
                }
                if (opFourMove == false)
                {
                    optionFour.SetActive(true);
                }
            }

            if (GameController.Instance.food > optionTwoNegOne)
            {
                GameController.Instance.food -= optionTwoNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionTwoNegThree))
            {
                GameController.Instance.localTemp += optionTwoNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            if (opTwoOnce == true)
            {
                optionTwo.SetActive(false);
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            boiling.SetActive(true);

            Invoke("SilenceBoil", 3f);
        }

        if (buttFuncTwo == 2)
        {
            if (GameController.Instance.food < (1 - optionTwoPosOne))
            {
                GameController.Instance.food += optionTwoPosOne;
            }
            else
            {
                GameController.Instance.food = 1f;
            }

            if (GameController.Instance.electricity == 0f)
            {
                if (opOneMove == true)
                {
                    optionOne.SetActive(false);
                }
                if (opTwoMove == true)
                {
                    optionTwo.SetActive(false);
                }
                if (opThreeMove == true)
                {
                    optionThree.SetActive(false);
                }
                if (opFourMove == true)
                {
                    optionFour.SetActive(false);
                }
            }

            if (GameController.Instance.electricity > optionTwoNegTwo)
            {
                GameController.Instance.electricity -= optionTwoNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionTwoNegThree))
            {
                GameController.Instance.localTemp += optionTwoNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            if (opTwoOnce == true)
            {
                optionTwo.SetActive(false);
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }
        }

        if (buttFuncTwo == 3)
        {
            if (GameController.Instance.food > optionTwoNegOne)
            {
                GameController.Instance.food -= optionTwoNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.electricity > optionTwoNegTwo)
            {
                GameController.Instance.electricity -= optionTwoNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionTwoNegThree))
            {
                GameController.Instance.localTemp += optionTwoNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            GameController.Instance.backTracked = true;
            Invoke("OpOneBackTrack", 4f);
        }
    }

    public void OptionThree()
    {
        if (buttFuncThree == 0)
        {
            if (GameController.Instance.food > optionThreeNegOne)
            {
                GameController.Instance.food -= optionThreeNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.electricity > optionThreeNegTwo)
            {
                GameController.Instance.electricity -= optionThreeNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp > optionThreePosOne)
            {
                GameController.Instance.localTemp -= optionThreePosOne;
            }
            else
            {
                GameController.Instance.localTemp = 0f;
            }

            GameController.Instance.backTracked = false;

            driving.SetActive(true);

            if (GameController.Instance.petrolCar == true)
            {
                engine.SetActive(true);
            }

            optionThree.SetActive(false);

            Invoke("OpThreeDrive", 4f);
        }

        if (buttFuncThree == 1)
        {
            if (opThreePetrol == true && GameController.Instance.petrolCar == true)
            {
                if (GameController.Instance.electricity < (1 - (1.5f * optionThreePosOne)))
                {
                    GameController.Instance.electricity += (1.5f * optionThreePosOne);
                }
                else
                {
                    GameController.Instance.electricity = 1f;
                }
            }

            if (GameController.Instance.petrolCar == false)
            {
                if (GameController.Instance.electricity < (1 - optionThreePosOne))
                {
                    GameController.Instance.electricity += optionThreePosOne;
                }
                else
                {
                    GameController.Instance.electricity = 1f;
                }
            }

            if (GameController.Instance.electricity > 0f)
            {
                if (opOneMove == false)
                {
                    optionOne.SetActive(true);
                }
                if (opTwoMove == false)
                {
                    optionTwo.SetActive(true);
                }
                if (opThreeMove == false)
                {
                    optionThree.SetActive(true);
                }
                if (opFourMove == false)
                {
                    optionFour.SetActive(true);
                }
            }

            if (GameController.Instance.food > optionThreeNegOne)
            {
                GameController.Instance.food -= optionThreeNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionThreeNegThree))
            {
                GameController.Instance.localTemp += optionThreeNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            if (opThreeOnce == true)
            {
                optionThree.SetActive(false);
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            boiling.SetActive(true);

            Invoke("SilenceBoil", 3f);
        }

        if (buttFuncThree == 2)
        {
            if (GameController.Instance.food < (1 - optionThreePosOne))
            {
                GameController.Instance.food += optionThreePosOne;
            }
            else
            {
                GameController.Instance.food = 1f;
            }

            if (GameController.Instance.electricity == 0f)
            {
                if (opOneMove == true)
                {
                    optionOne.SetActive(false);
                }
                if (opTwoMove == true)
                {
                    optionTwo.SetActive(false);
                }
                if (opThreeMove == true)
                {
                    optionThree.SetActive(false);
                }
                if (opFourMove == true)
                {
                    optionFour.SetActive(false);
                }
            }

            if (GameController.Instance.electricity > optionThreeNegTwo)
            {
                GameController.Instance.electricity -= optionThreeNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionThreeNegThree))
            {
                GameController.Instance.localTemp += optionThreeNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            if (opThreeOnce == true)
            {
                optionThree.SetActive(false);
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }
        }

        if (buttFuncOne == 3)
        {
            if (GameController.Instance.food > optionThreeNegOne)
            {
                GameController.Instance.food -= optionThreeNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.electricity > optionThreeNegTwo)
            {
                GameController.Instance.electricity -= optionThreeNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionThreeNegThree))
            {
                GameController.Instance.localTemp += optionThreeNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            GameController.Instance.backTracked = true;
            Invoke("OpOneBackTrack", 4f);
        }
    }

    public void OptionFour()
    {
        if (buttFuncFour == 0)
        {
            if (GameController.Instance.food > optionFourNegOne)
            {
                GameController.Instance.food -= optionFourNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.electricity > optionFourNegTwo)
            {
                GameController.Instance.electricity -= optionFourNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp > optionFourPosOne)
            {
                GameController.Instance.localTemp -= optionFourPosOne;
            }
            else
            {
                GameController.Instance.localTemp = 0f;
            }

            GameController.Instance.backTracked = false;

            driving.SetActive(true);

            if (GameController.Instance.petrolCar == true)
            {
                engine.SetActive(true);
            }

            optionFour.SetActive(false);

            Invoke("OpFourDrive", 4f);
        }

        if (buttFuncFour == 1)
        {
            if (opFourPetrol == true && GameController.Instance.petrolCar == true)
            {
                if (GameController.Instance.electricity < (1 - (1.5f * optionFourPosOne)))
                {
                    GameController.Instance.electricity += (1.5f * optionFourPosOne);
                }
                else
                {
                    GameController.Instance.electricity = 1f;
                }
            }

            if (GameController.Instance.petrolCar == false)
            {
                if (GameController.Instance.electricity < (1 - optionFourPosOne))
                {
                    GameController.Instance.electricity += optionFourPosOne;
                }
                else
                {
                    GameController.Instance.electricity = 1f;
                }
            }

            if (GameController.Instance.electricity > 0f)
            {
                if (opOneMove == false)
                {
                    optionOne.SetActive(true);
                }
                if (opTwoMove == false)
                {
                    optionTwo.SetActive(true);
                }
                if (opThreeMove == false)
                {
                    optionThree.SetActive(true);
                }
                if (opFourMove == false)
                {
                    optionFour.SetActive(true);
                }
            }

            if (GameController.Instance.food > optionFourNegOne)
            {
                GameController.Instance.food -= optionFourNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionFourNegThree))
            {
                GameController.Instance.localTemp += optionFourNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            if (opFourOnce == true)
            {
                optionFour.SetActive(false);
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            boiling.SetActive(true);

            Invoke("SilenceBoil", 3f);
        }

        if (buttFuncFour == 2)
        {
            if (GameController.Instance.food < (1 - optionFourPosOne))
            {
                GameController.Instance.food += optionFourPosOne;
            }
            else
            {
                GameController.Instance.food = 1f;
            }

            if (GameController.Instance.electricity == 0f)
            {
                if (opOneMove == true)
                {
                    optionOne.SetActive(false);
                }
                if (opTwoMove == true)
                {
                    optionTwo.SetActive(false);
                }
                if (opThreeMove == true)
                {
                    optionThree.SetActive(false);
                }
                if (opFourMove == true)
                {
                    optionFour.SetActive(false);
                }
            }
            if (GameController.Instance.electricity > optionFourNegTwo)
            {
                GameController.Instance.electricity -= optionFourNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionFourNegThree))
            {
                GameController.Instance.localTemp += optionFourNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            if (opFourOnce == true)
            {
                optionFour.SetActive(false);
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }
        }

        if (buttFuncFour == 3)
        {
            if (GameController.Instance.food > optionFourNegOne)
            {
                GameController.Instance.food -= optionFourNegOne;
            }
            else
            {
                GameController.Instance.food = 0f;
            }

            if (GameController.Instance.electricity > optionFourNegTwo)
            {
                GameController.Instance.electricity -= optionFourNegTwo;
            }
            else
            {
                GameController.Instance.electricity = 0f;
            }

            if (GameController.Instance.localTemp < (1 - optionFourNegThree))
            {
                GameController.Instance.localTemp += optionFourNegThree;
            }
            else
            {
                GameController.Instance.localTemp = 1f;
            }

            electricityBar.fillAmount = GameController.Instance.electricity;
            foodBar.fillAmount = GameController.Instance.food;
            localTempBar.fillAmount = GameController.Instance.localTemp;

            if (GameController.Instance.food < 0.1f)
            {
                description.text = "you starve to death";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            if (GameController.Instance.localTemp > 0.9f)
            {
                description.text = "you are caught by a heat wave and overheat";

                optionOne.SetActive(false);
                optionTwo.SetActive(false);
                optionThree.SetActive(false);
                optionFour.SetActive(false);
            }

            GameController.Instance.backTracked = true;
            Invoke("OpOneBackTrack", 4f);
        }
        Invoke("energyTest", 0f);
    }
}