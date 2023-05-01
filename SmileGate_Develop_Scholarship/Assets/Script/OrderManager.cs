using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Order
{
    public List<string> order = new List<string>();
    public string guestName;
}

public class OrderManager : MonoBehaviour
{
    public static OrderManager instance;
    public List<Order> OrderList = new List<Order>();
    public Order SelectOrder; // 선택된 주문임.


    public int Score;
    private void Awake() {
        instance = this;
    }
    void Start()
    {
    }

    void Update()
    {
        
    }
    public static void RandomOrder()
    {
        instance._RandomOrder();
    }
    private void _RandomOrder(){
        int index = Random.Range(0,OrderList.Count);
        Debug.Log(index);
        SelectOrder = OrderList[index];
        foreach(var str in SelectOrder.order){
            Debug.Log(str);
        }
    }
}
