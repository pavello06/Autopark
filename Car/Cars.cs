using System.Runtime.CompilerServices;

namespace Autopark.Car
{
    internal class Cars
    {
        private List<Car> _cars;
        private FlowLayoutPanel _flowLayoutPanel;
        private List<List<Car>> _history;
        private int _index;

        public Car this[int index]
        {
            get => _cars[index];
            set => _cars[index] = value;
        }

        public Cars(FlowLayoutPanel flowLayoutPanel)
        {
            _cars = new List<Car>();
            _flowLayoutPanel = flowLayoutPanel;
            _history = new List<List<Car>>() { new List<Car>() };
            _index = 0;
        }

        public void Add(Car car) 
        {
            _cars.Add(car);
            _flowLayoutPanel.Controls.Add(car.Visualize());
            UpdateHistory();
        }

        public void Delete(Car car)
        {
            _cars.Remove(car);
            UpdateView();
            UpdateHistory();
        }

        public void UpdateView()
        {
            _flowLayoutPanel.Controls.Clear();
            foreach (var car in _cars)
            {
                _flowLayoutPanel.Controls.Add(car.Visualize());
            }
        }

        public void UpdateHistory()
        {
            _index++;
            var copy = new List<Car>();
            foreach (var car in _cars)
            {
                copy.Add(car.DeepCopy());
            }
            _history.Insert(_index, copy);
            _history.RemoveRange(_index + 1, _history.Count - _index - 1);
        }

        public void Undo()
        {
            if (_index > 0)
            {
                _index--;
                _cars = new List<Car>(_history[_index]);
                UpdateView();
            }
        }

        public void Redo()
        {
            if (_index < _history.Count - 1)
            {
                _index++;
                _cars = new List<Car>(_history[_index]);
                UpdateView();
            }
        }
    }
}
