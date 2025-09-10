using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SwordGorge : MonoBehaviour
{
    public Text swordInfoText;
    public Text goldText;
    public Button sharpenssBtn;
    public Button fireBtn;
    public Button iceBtn;
    public Button resetBtn;
    public Button attackBtn;


    public Renderer swordRenderer;
    public Light glowLight;

    public int gold = 1000;
    private ISword currentSword;

    private void Start()
    {
        currentSword = new BasicSword();
        SetupButtons();
        UpdateAll();
    }

    private void SetupButtons()
    {
        // sharpenssBtn.onClick(() => TryEn)
    }

    private void TryEnhance<T>(int cost) where T : SwordDecorator
    {
        if (gold >= cost)
        {
            gold -= cost;
            currentSword = (T)System.Activator.CreateInstance(typeof(T), currentSword);
            UpdateAll();
            Debug.Log($"{typeof(T).Name} 적용!");
        }
        else
        {
            Debug.Log("골드 부족!");
        }
    }

    private void ResetSword()
    {
        currentSword = new BasicSword();
        UpdateAll();
    }

    public void TestAttack()
    {
        int damage = currentSword.GetAttackPower();
        bool isCritical = Random.Range(0, 100) < currentSword.GetCriticalChance();

        if (isCritical)
        {
            damage *= 2;
        }

        Debug.Log($"{(isCritical ? "크리티컬!" : "공격!")} 데미지: {damage}");

        if (!string.IsNullOrEmpty(currentSword.GetSpecialEffect()))
        {
            Debug.Log($"{currentSword.GetSpecialEffect()}");
        }
    }

    private void UpdateAll()
    {
        UpdateUI();
        UpdateVisual();
    }

    private void UpdateUI()
    {
        // swordInfoText.text = $"{currentSword.GetName()}/n"
        //                     $"공격력: {currentSword.GetAttackPower()}/n" +
        // ;
    }

    private void UpdateVisual()
    {

    }
}
