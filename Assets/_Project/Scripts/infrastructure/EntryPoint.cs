using _Project.Scripts.Models;
using _Project.Scripts.Presenters;
using _Project.Scripts.Views;
using UnityEngine;

namespace _Project.Scripts.infrastructure
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private UISlotView _uiSlotView;

        private void Awake()
        {
            Model model = new UnlimitedSlotsModel(_uiSlotView);
            Presenter presenter = new CentralLinePresenter(model);
            _uiSlotView.Init(presenter);
        }
    }
}