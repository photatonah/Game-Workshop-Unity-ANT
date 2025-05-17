using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    

    public InventoryPanel inventoryPanel;
    
    public void ToggleInventoryPanel()
    {
        if (inventoryPanel.gameObject.activeSelf)
        {
            CloseInventoryPanel();
        }
        else
        {
            OpenInventoryPanel();
        }
    }

    public void OpenInventoryPanel()
    {
        inventoryPanel.gameObject.SetActive(true);
        inventoryPanel.OnOpen();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        Time.timeScale = 0f; // Pause the game


    }

    public void CloseInventoryPanel() {
        inventoryPanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
        Time.timeScale = 1f; // Resume the game
    }

    public float timeCounter = 90f;
    public ItemData[] itemsToCollect;
    private ItemData targetItem;
    public int targetAmount = 5;

    public TMP_Text timeCounterText;
    public Image targetItemIcon;
    public TMP_Text targetCurrentAmountText;

    public bool isPlayerWin = false;

    void Start()
    {
        targetItem = itemsToCollect[UnityEngine.Random.Range(0, itemsToCollect.Length)];

        inventoryPanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        targetItemIcon.sprite = targetItem.itemIcon;
    }

    void Update()
    {
        if (isPlayerWin) {
            return;
        }

        if (timeCounter > 0) {
            timeCounter -= Time.deltaTime;
            timeCounterText.text = "Time left: " + Math.Round(timeCounter) + " seconds";

            targetCurrentAmountText.text = "x " + (targetAmount - InventoryManager.instance.GetItemAmount(targetItem)).ToString();

            if (InventoryManager.instance.GetItemAmount(targetItem) >= targetAmount)
            {
                // player wins
                Debug.Log("You win!");
                isPlayerWin = true;
                SceneManager.LoadScene("WinScene");
            }
        }
        else {
            // player loses
            SceneManager.LoadScene("LoseScene");
        }
    }
}
