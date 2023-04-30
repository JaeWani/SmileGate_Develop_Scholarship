using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderUI : MonoBehaviour
{
    [Header ("텍스트")]
    [SerializeField] Text OrderText;
    [Header ("버튼")]
    [SerializeField] Button NextButton;
    [SerializeField] Button EndButton;
    [Header ("그 외")]
    public int Index = 0;
    void Start()
    {
        OrderManager.RandomOrder();
        OrderText.text = OrderManager.instance.SelectOrder.order[Index];
        NextButton.onClick.AddListener(()=> {
            Index++;
            SetOrder();
        });
        EndButton.onClick.AddListener(() => {
                //여기엔 이제 음식을 만드는 화면으로 이동하는 코드 넣어주면 됨.            
        });
    }

    void Update()
    {
        
    }
    public void SetOrder(){
        if(Index > OrderManager.instance.SelectOrder.order.Count){
            //여기엔 이제 음식을 만드는 화면으로 이동하는 코드 넣어주면 됨.  
        }
        else{
             OrderText.text = OrderManager.instance.SelectOrder.order[Index];
        }

    }
}
