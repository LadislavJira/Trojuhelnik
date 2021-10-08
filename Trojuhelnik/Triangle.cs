using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trojuhelnik
{
    class Triangle
    {
        private float _a;
        private float _b;
        private float _c;

        public Triangle(float a, float b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public Triangle(float a)
        {
            _a = a;
            _b = a;
            _c = a;
        }

        public void SetA(float value)
        {
            _a = value;
        }

        public float GetA()
        {
            return _a;
        }

        public void SetB(float value)
        {
            _b = value;
        }

        public float GetB()
        {
            return _b;
        }

        public void SetC(float value)
        {
            _c = value;
        }

        public float GetC()
        {
            return _c;
        }

        public void SetSides(float valueA, float valueB, float valueC)
        {
            _a = valueA;
            _b = valueB;
            _c = valueC;
        }

        public float GetArea()
        {
            float s = (_a + _b + _c) / 2;
            float area = (float)Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
            return area;
        }
         public float GetOutline()
        {
            float outline = _a + _b + _c;
            return outline;
        }
        public bool IsExisting()
        {
            if ((_a + _b > _c) && (_a + _b > _c) && (_b +_c > _a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
