using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Text textCount;
    [SerializeField] private Button clickButton;
    
    public event Action OnClick;
    
    public void RefreshCount(int count) => textCount.text = count.ToString();

    private void Start()
    {
        RefreshCount(0);
        clickButton.onClick.AddListener(() => OnClick?.Invoke());
    }
    
}
