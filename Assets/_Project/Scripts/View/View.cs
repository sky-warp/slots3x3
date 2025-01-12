using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts.View
{
    public abstract class View : MonoBehaviour
    {
        protected Presenter.Presenter Presenter;

        public void Init(Presenter.Presenter presenter)
        {
            Presenter = presenter;
        }
        
        public abstract void ShowSpinResult(List<int> state);
        public abstract void ShowWinnerScreen();
    }
}