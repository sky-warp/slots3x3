using System.Collections.Generic;
using _Project.Scripts.Models;

namespace _Project.Scripts.Presenters
{
    public class CentralLinePresenter : Presenter
    {
        public CentralLinePresenter(Model model) : base(model)
        {
        }

        public override bool AnalyzeWin(List<int> stateForAnalize)
        {
            bool isWin;
            return isWin = stateForAnalize[3] == stateForAnalize[4] && stateForAnalize[4] == stateForAnalize[5];
        }
    }
}