using System.Drawing;

namespace MyLib
{
    public interface IAbstractFactory
    {
        ISquare CreateSquare();
        ICircle CreateCircle();
    }

    public class ConcreteFactoryGreen : IAbstractFactory
    {
        public ConcreteFactoryGreen()
        {
        }
        #region IAbstractFactory interface
        public ICircle CreateCircle()
        {
            return new CircleGreen();
        }
        public ISquare CreateSquare()
        {
            return new SquareGreen();
        }
        #endregion IAbstractFactory interface
    }

    public class ConcreteFactoryRed : IAbstractFactory
    {
        public ConcreteFactoryRed()
        {
        }
        #region IAbstractFactory interface
        public ICircle CreateCircle()
        {
            return new CircleRed();
        }
        public ISquare CreateSquare()
        {
            return new SquareRed();
        }
        #endregion IAbstractFactory interface
    }

    public interface ICircle
    {
        int GetRadius();
        bool SetRadius(int radius);
        Color GetCirleColor();
    }

    public interface ISquare
    {
        int GetSideSize();
        bool SetSideSize(int sideSize);
        Color GetSqureColor();
    }

    class CircleGreen : ICircle
    {
        private readonly Color circleColor = Color.Green;
        private int radius;

        public CircleGreen()
        {
            radius = 25;
        }

        #region ICircle interface
        public Color GetCirleColor()
        {
            return circleColor;
        }
        public int GetRadius()
        {
            return radius;
        }
        public bool SetRadius(int radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion ICircle interface
    }

    class CircleRed : ICircle
    {
        private readonly Color circleColor = Color.Red;
        private int radius;

        public CircleRed()
        {
            radius = 25;
        }

        #region ICircle interface
        public Color GetCirleColor()
        {
            return circleColor;
        }
        public int GetRadius()
        {
            return radius;
        }
        public bool SetRadius(int radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion ICircle interface
    }

    class SquareGreen : ISquare
    {
        private int sideSize;
        private readonly Color color = Color.Green;
        public SquareGreen()
        {
            sideSize = 50;
        }
        #region ISquare interface
        public int GetSideSize()
        {
            return sideSize;
        }
        public Color GetSqureColor()
        {
            return color;
        }
        public bool SetSideSize(int sideSize)
        {
            if (sideSize > 0)
            {
                this.sideSize = sideSize;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion ISquare interface
    }

    class SquareRed : ISquare
    {
        private int sideSize;
        private readonly Color color = Color.Red;
        public SquareRed()
        {
            sideSize = 50;
        }
        #region ISquare interface
        public int GetSideSize()
        {
            return sideSize;
        }
        public Color GetSqureColor()
        {
            return color;
        }
        public bool SetSideSize(int sideSize)
        {
            if (sideSize > 0)
            {
                this.sideSize = sideSize;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion ISquare interface
    }
}