using System.Collections.Generic;
using System.Linq;
using _Project.Scripts.Models;
using UnityEngine;

namespace _Project.Scripts.Presenters
{
    public abstract class Presenter
    {
        protected Model Model;

        public Presenter(Model model)
        {
            Model = model;
        }

        public void OnSpinButtonClicked()
        {
            Spin();
        }
        
        public void Spin()
        {
//            List<int> state = new int[Model.CurrentState.Count].ToList();
            List<int> state = Model.CurrentState;

            for (int i = 0; i < Model.CurrentState.Count; i++)
            {
                state[i] = Random.Range(0, 6);
            }
            
            Model.SetState(state);
            Model.SetWinState(AnalyzeWin(state));
        }
        
        public abstract bool AnalyzeWin(List<int> stateForAnalize);
    }
}