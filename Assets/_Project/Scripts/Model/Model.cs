using System.Collections.Generic;
using System.Linq;

namespace _Project.Scripts.Model
{
    public abstract class Model
    {
        protected View.View View;
        protected List<int> State;
        protected bool IsWin;
        
        public List<int> CurrentState => State;

        public Model(View.View view)
        {
            View = view;
            State = new int[9].ToList();
        }

        public void SetState(List<int> state)
        {
            State = state;
            View.ShowSpinResult(State);
        }

        public void SetStateWin(bool isWin)
        {
            IsWin = isWin;

            if (IsWin)
            {
                View.ShowWinnerScreen();
            }
        }
    }
}