namespace Algorithms.Devoir1;

public class Moyenne
{
        private double firstValue; 
        private double secondValue;
        private double thirdValue;
        public Moyenne(double firstValue, double secondValue, double thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public double FirstValue()
        {
            return firstValue;
        }
        public double SecondValue()
        {
            return secondValue;
        }
        public double ThirdValue()
        {
            return thirdValue;
        }
        public double Average()
        {
            return (firstValue + secondValue + thirdValue) / 3;
        }

        public static double Average(List<double> lst)
        {
            double sum = 0;
            foreach (double value in lst)
            {
                sum += value;
            }
            return sum / lst.Count;
        }
        
}


    
        
