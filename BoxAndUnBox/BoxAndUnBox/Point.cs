using System;

namespace BoxAndUnBox
{
    struct Point
    {
        private int _x;
        private int _y;
        private string _name;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Point(int x, int y, string name)
        {
            this._x = x;
            this._y = y;
            this._name = name;
        }
        public void Change(Int32 x, Int32 y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }
        public override string ToString()
        {
            return String.Format("({0},{1},{2})", _x.ToString(), _y.ToString(), _name);
        }
    }
}
