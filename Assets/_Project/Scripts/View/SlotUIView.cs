using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using _Project.Scripts.Presenters;
using Unity.VisualScripting;
using UnityEngine.Serialization;

namespace _Project.Scripts.Views
{
    public class SlotUIView : View
    {
        [SerializeField] private List<Image> _slotValues;
        [SerializeField] private List<Sprite> _imagesByID;
        [SerializeField] private TextMeshProUGUI _winnerText;
        [SerializeField] private Button _spinButton;

        private void Start()
        {
            _spinButton.onClick.AddListener(() =>
            {
                Presenter.OnSpinButtonClicked();
            });
        }

        private void OnDestroy()
        {
            _spinButton.onClick.RemoveAllListeners();
        }
        
        public override void ShowSpinResult(List<int> state)
        {
            _winnerText.gameObject.SetActive(false);

            for (int i = 0; i < state.Count; i++)
            {
                _slotValues[i].sprite = GetImageByID(state[i]);
            }
        }

        public override void ShowWinnerScreen()
        {
            _winnerText.gameObject.SetActive(true);
        }

        private Sprite GetImageByID(int id)
        {
            return _imagesByID[id];
        }
    }
}