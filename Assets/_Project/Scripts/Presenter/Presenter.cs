using System.Collections.Generic;
using System.Linq;
using _Project.Scripts.Models;

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

        private void Spin()
        {
            List<int> tempState = new int[Model.CurrentState.Count].ToList();

            for (int i = 0; i < Model.CurrentState.Count; i++)
            {
                tempState[i] = UnityEngine.Random.Range(0, 6);
            }
            
            Model.SetState(tempState);
            Model.SetStateWin(AnalyzeResult());
        }
        
        public abstract bool AnalyzeResult();
    }
}