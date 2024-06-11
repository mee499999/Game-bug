using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaManager : MonoBehaviour
{
    [SerializeField] private float maxStamina = 100f;
    [SerializeField] private float staminaDrain = 10f; // อัตราการลดพลังงานต่อวินาทีเมื่อวิ่ง
    [SerializeField] private float staminaRecovery = 5f; // อัตราการฟื้นฟูพลังงานต่อวินาทีเมื่อไม่วิ่ง
    [SerializeField] private Slider staminaSlider; // เพิ่ม Slider สำหรับแสดงค่าพลังงาน

    private float currentStamina;

    private void Start()
    {
        currentStamina = maxStamina; // กำหนดค่าเริ่มต้นของพลังงาน
        staminaSlider.maxValue = maxStamina; // กำหนดค่าสูงสุดของ Slider
        staminaSlider.value = currentStamina; // กำหนดค่าเริ่มต้นของ Slider
    }

    public void DrainStamina()
    {
        currentStamina -= staminaDrain * Time.deltaTime;
        if (currentStamina < 0f)
        {
            currentStamina = 0f;ห
        }
        staminaSlider.value = currentStamina;
    }

    public void RecoverStamina()
    {
        currentStamina += staminaRecovery * Time.deltaTime;
        if (currentStamina > maxStamina)
        {
            currentStamina = maxStamina;
        }
        staminaSlider.value = currentStamina;
    }

    public bool HasStamina()
    {
        return currentStamina > 0f;
    }
}
