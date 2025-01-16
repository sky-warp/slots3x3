using _Project.Scripts.Models;

namespace _Project.Scripts.Presenters
{
    public class SlotPresenter : Presenter
    {
        public SlotPresenter(Model model) : base(model)
        {
        }

        public override bool AnalyzeResult()
        {
            var state = Model.CurrentState;

            bool isWin = (state[3] == state[4] && state[4] == state[5]);
            
            return isWin;
        }
    }
}