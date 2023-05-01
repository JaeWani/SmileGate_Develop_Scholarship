using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderUI : MonoBehaviour
{
    [Header("패널")]
    [SerializeField] Image OrderPanel;
    [Header("텍스트")]
    [SerializeField] Text OrderText;
    [SerializeField] Text GuestName;
    [SerializeField] Text ScoreText;

    [Header("버튼")]
    [SerializeField] Button NextButton;

    [SerializeField] Button EndButton;
    [SerializeField] Button ClearButton;
    [SerializeField] Button FailButton;
    [Header("그 외")]
    public int Index = 0;
    void Start()
    {
        OrderManager.RandomOrder();
        GuestName.text = OrderManager.instance.SelectOrder.guestName;
        OrderText.text = OrderManager.instance.SelectOrder.order[Index];
        NextButton.onClick.AddListener(() =>
        {
            Index++;
            SetOrder();
        });
        EndButton.onClick.AddListener(() =>
        {
            OrderPanel.gameObject.SetActive(true);
            OrderManager.RandomOrder();
        });
        ClearButton.onClick.AddListener(() =>
        {
            OrderManager.instance.Score += 100;
            OrderPanel.gameObject.SetActive(false);
        });
        FailButton.onClick.AddListener(() =>
        {
            OrderPanel.gameObject.SetActive(false);
        });
    }

    void Update()
    {

    }
    public void SetOrder()
    {
        if (Index >= OrderManager.instance.SelectOrder.order.Count)
        {
            OrderPanel.gameObject.SetActive(true);
            OrderManager.RandomOrder();
            Index = 0;
            GuestName.text = OrderManager.instance.SelectOrder.guestName;
            OrderText.text = OrderManager.instance.SelectOrder.order[Index];
        }
        else
        {
            OrderText.text = OrderManager.instance.SelectOrder.order[Index];
        }
    }
}
