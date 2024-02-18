namespace usov_402_lr3.Services {
    public class CalcService {
        public double Add(double x, double y) => x + y;
        public double Subtract(double x, double y) => x - y;
        public double Multiply(double x, double y) => x * y;
        public double Divide(double x, double y) {
            if (y == 0) {
                throw new ArgumentException("Divider cannot be zero.", nameof(y));
            }
            return x / y;
        }
    }

}
