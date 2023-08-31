namespace Algorithms;

public class Moyenne
{
        public static double CalculateMoyenne(List<double> lst)
        {
            double sum = 0;
            foreach (double value in lst)
            {
                sum += value;
            }
            double moyenne = sum / lst.Count;
            return moyenne;
        }
        public static void Main(string[] args )
{
    List<double> lst = new List<double> { 5, 10, 6 };
            try
            {
                double moyenne = Moyenne.CalculateMoyenne(lst);
                Console.WriteLine($"La moyenne est : {moyenne}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
}
        
}


    
        
