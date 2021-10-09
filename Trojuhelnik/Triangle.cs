﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trojuhelnik
{
    class Triangle
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
        if (a > 0)
            {
                _a = a;
            }
        if (b > 0)
            {
                _b = b;
            }
        if (c > 0)
            {
                _c = c;
            }
        }

        public Triangle(double a)
        {
            if (a > 0)
            {
            _a = a;
            _b = a;
            _c = a;
            }
        }

        public void SetA(double value)
        {
            _a = value;
        }

        public double GetA()
        {
            return _a;
        }

        public void SetB(double value)
        {
            _b = value;
        }

        public double GetB()
        {
            return _b;
        }

        public void SetC(double value)
        {
            _c = value;
        }

        public double GetC()
        {
            return _c;
        }

        public void SetSides(double valueA, double valueB, double valueC)
        {
            if (valueA > 0)
            {
                _a = valueA;
            }
            if (valueB > 0)
            {
                _b = valueB;
            }
            if (valueC > 0)
            {
                _c = valueC;
            }
        }

        public double GetArea()
        {
            double s = (_a + _b + _c) / 2;
            double area = Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
            return area;
        }
         public double GetOutline()
        {
            double outline = _a + _b + _c;
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
        public static bool CanExist(double a,  double b,  double c)
        {
            if ((a + b > c) && (a + b > c) && (b + c > a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetAlpha()
        {
            double s = (_a + _b + _c) / 2;
            double alpha = Math.Asin(2 * Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c)) / (_b * _c));
            alpha = (180 / Math.PI) * alpha;
            return alpha;
        }
        public double GetBeta()
        {
            double s = (_a + _b + _c) / 2;
            double beta = Math.Asin(2 * Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c)) / (_a * _c));
            beta = (180 / Math.PI) * beta;
            return beta;
        }
        public double GetGamma()
        {
            double s = (_a + _b + _c) / 2;
            double gamma = Math.Asin(2 * Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c)) / (_a * _b));
            gamma = (180 / Math.PI) * gamma;
            return gamma;
        }
    }
}
