using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;      // �ҡ Slider �ҡ Canvas
    public Text valueText;     // (������) �ʴ���ͤ��� "HP 80/100" �����ҡ����� ����ҡ Text ŧ

    public void SetMaxHealth(float max)
    {
        if (slider != null)
        {
            slider.maxValue = max;
            slider.value = max;
        }
        UpdateText(max, max);
    }

    public void SetHealth(float current)
    {
        if (slider != null)
        {
            slider.value = current;
        }
        UpdateText(current, slider != null ? slider.maxValue : current);
    }

    private void UpdateText(float current, float max)
    {
        if (valueText != null)
        {
            valueText.text = Mathf.CeilToInt(current).ToString() + " / " + Mathf.CeilToInt(max).ToString();
        }
    }
}
