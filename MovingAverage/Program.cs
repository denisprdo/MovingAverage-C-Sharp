namespace MovingAverage
{
    internal class Program
    {
        static void Main()
        {
            MovingAverage moveaverage = new MovingAverage();

            //--------------------------------------------------
            //Médias Móveis Simples de 5, 10 e 15

            int[] mm1 = { 5, 10, 15 };
            moveaverage.CalcularMediaSimples(mm1);

            //--------------------------------------------------
            //Médias Móveis Exponenciais de 5, 10 e 15

            int[] mm2 = { 5, 10, 15 };
            moveaverage.CalcularMediaExponen(mm2);
            
            //--------------------------------------------------
            //Cruzamento de Médias Móveis Simples de 5, 10

            moveaverage.CalcularCruzSimples(5, 10);

            //--------------------------------------------------
            //Cruzamento de Médias Móveis Exponenciais de 8, 10

            moveaverage.CalcularCruzExponen(8, 10);

            //--------------------------------------------------

            System.Console.ReadKey();
        }
    }
}
