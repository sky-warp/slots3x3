using System.Collections.Generic;
using System.Linq;
using _Project.Scripts.Views;

namespace _Project.Scripts.Models
{
    public abstract class Model
    {
        private List<int> _state;
        private View _view;
        private bool _isWin;

        public List<int> CurrentState => _state;

        public Model(View view)
        {
            _state = new int[9].ToList();
            _view = view;
        }
        
        public void SetState(List<int> state)
        {
            _state = state;
            
            _view.ShowSpinResult(_state);
        }

        public void SetWinState(bool isWin)
        {
            _isWin = isWin;

            if (_isWin)
            {
                _view.ShowWinnerText();
            }
        }
    }
}