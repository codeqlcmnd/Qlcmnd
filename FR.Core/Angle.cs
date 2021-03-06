using System;

namespace PatternRecognition.FingerprintRecognition.Core
{

    public static class Angle
    {
        public static double ComputeAngle(double dX, double dY)
        {
            if (dX > 0 && dY >= 0)
                return Math.Atan(dY / dX);
            if (dX > 0 && dY < 0)
                return Math.Atan(dY / dX) + 2 * Math.PI;
            if (dX < 0)
                return Math.Atan(dY / dX) + Math.PI;
            if (dX == 0 && dY > 0)
                return Math.PI / 2;
            if (dX == 0 && dY < 0)
                return 3 * Math.PI / 2;
            throw new ArgumentOutOfRangeException();
        }

        public static double Difference2Pi(double alpha, double beta)
        {
            if (beta >= alpha)
                return (beta - alpha);
            return beta - alpha + 2 * Math.PI;
        }

        public static double DifferencePi(double alpha, double beta)
        {
            double diff = Math.Abs(beta - alpha);
            return Math.Min(diff, 2 * Math.PI - diff);
        }

        public static int Difference180(int alpha, int beta)
        {
            int diff = Math.Abs(beta - alpha);
            return Math.Min(diff, 360 - diff);
        }

        public static double ToRadians(int degrees)
        {
            return degrees * Math.PI / 180;
        }

        public static double ToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }
    }
}
