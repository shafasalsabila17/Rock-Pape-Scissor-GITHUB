using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField] new string name;
    [SerializeField] CharacterType type;
    [SerializeField] int currentHP;
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] TMP_Text overHeadText;
    [SerializeField] Image avatar;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text typeText;
    [SerializeField] Image healtBar;
    [SerializeField] TMP_Text hpText;
    [SerializeField] Button button;

    private void start(){
        overHeadText.text = name;
        nameText.text = name;
        typeText.text = type.ToString();
        healtBar.fillAmount = (float) currentHP / (float) maxHP;
        hpText.text =  currentHP + "/" + maxHP;
        button.interactable = false;
    }
}
