using System.Collections.Generic;
using System.Linq;
using _Project.Scripts.Views;

namespace _Project.Scripts.Models
{
    public abstract class Model
    {
        protected View View;
        protected List<int> State;
        protected bool IsWin;
        
        public List<int> CurrentState => State;

        public Model(View view)
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