using _Project.Scripts.Models;
using _Project.Scripts.Presenters;
using _Project.Scripts.Views;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private SlotUIView _uiView;

    private void Awake()
    {
        var model = new UnlimitedSpinModel(_uiView);
        Presenter presenter = new SlotPresenter(model);
        _uiView.Init(presenter);
    }
}
