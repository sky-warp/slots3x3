using System.Collections.Generic;
using UnityEngine;
using _Project.Scripts.Presenters;

namespace _Project.Scripts.Views
{
    public abstract class View : MonoBehaviour
    {
        protected Presenter Presenter;

        public void Init(Presenter presenter)
        {
            Presenter = presenter;
        }

        public abstract void ShowSpinResult(List<int> stateToShow);
        public abstract void ShowWinnerText();
    }
}