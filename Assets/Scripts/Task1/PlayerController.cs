using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerView playerView;
    
    private PlayerModel _playerModel;

    private void Start()
    {
        _playerModel = new PlayerModel();
        _playerModel.OnChangedCount += playerView.RefreshCount;
        playerView.OnClick += _playerModel.AddCount;
    }
}
