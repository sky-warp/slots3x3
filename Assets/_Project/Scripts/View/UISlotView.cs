using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.Views
{
    public class UISlotView : View
    {
        [SerializeField] private List<Image> _slotsImages;
        [SerializeField] private List<Sprite> _slotsItems;
        [SerializeField] private Button _spinButton;
        [SerializeField] private TextMeshProUGUI _winnerText;

        private void Awake()
        {
            _spinButton.onClick.AddListener( (() =>
            {
                Presenter.OnSpinButtonClicked();
            }));
        }

        public override void ShowSpinResult(List<int> stateToShow)
        {
            _winnerText.gameObject.SetActive(false);

            for (int i = 0; i < stateToShow.Count; i++)
            {
                _slotsImages[i].sprite = GetSpriteByID(stateToShow[i]);
            }
        }

        public override void ShowWinnerText()
        {
            _winnerText.gameObject.SetActive(true);
        }

        private Sprite GetSpriteByID(int id)
        {
            return _slotsItems[id];
        }
    }
}