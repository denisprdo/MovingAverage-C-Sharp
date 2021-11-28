namespace MovingAverage
{
    public class MovingAverage
    {
        private enum        Nm_media { mms, mme }

        private string[]    Timevalues  { get; }
        private double[]    Closevalues { get; }

        private double[][]  ArrayMMS  { get; set; }
        private double[][]  ArrayMME  { get; set; }
        private int[]       ArrayMMSTittle { get; set; }
        private int[]       ArrayMMETittle { get; set; }

        public MovingAverage()
        {
            //Ibovespa (IBOV) 09/08/2021 à 19/10/2021

            this.Timevalues = new string[50];
            this.Closevalues = new double[50];

            this.Closevalues[0] = 123.019;		    this.Timevalues[0] = "09.08.2021";
            this.Closevalues[1] = 122.202;		    this.Timevalues[1] = "10.08.2021";
            this.Closevalues[2] = 122.056;		    this.Timevalues[2] = "11.08.2021";
            this.Closevalues[3] = 120.701;		    this.Timevalues[3] = "12.08.2021";
            this.Closevalues[4] = 121.194;		    this.Timevalues[4] = "13.08.2021";
            this.Closevalues[5] = 119.18;		    this.Timevalues[5] = "16.08.2021";
            this.Closevalues[6] = 117.904;		    this.Timevalues[6] = "17.08.2021";
            this.Closevalues[7] = 116.643;		    this.Timevalues[7] = "18.08.2021";
            this.Closevalues[8] = 117.165;		    this.Timevalues[8] = "19.08.2021";
            this.Closevalues[9] = 118.053;		    this.Timevalues[9] = "20.08.2021";
            this.Closevalues[10] = 117.472;		    this.Timevalues[10] = "23.08.2021";
            this.Closevalues[11] = 120.211;		    this.Timevalues[11] = "24.08.2021";
            this.Closevalues[12] = 120.818;		    this.Timevalues[12] = "25.08.2021";
            this.Closevalues[13] = 118.724;		    this.Timevalues[13] = "26.08.2021";
            this.Closevalues[14] = 120.678;		    this.Timevalues[14] = "27.08.2021";
            this.Closevalues[15] = 119.74;		    this.Timevalues[15] = "30.08.2021";
            this.Closevalues[16] = 118.781;		    this.Timevalues[16] = "31.08.2021";
            this.Closevalues[17] = 119.396;		    this.Timevalues[17] = "01.09.2021";
            this.Closevalues[18] = 116.677;		    this.Timevalues[18] = "02.09.2021";
            this.Closevalues[19] = 116.933;		    this.Timevalues[19] = "03.09.2021";
            this.Closevalues[20] = 117.869;		    this.Timevalues[20] = "06.09.2021";
            this.Closevalues[21] = 113.413;		    this.Timevalues[21] = "08.09.2021";
            this.Closevalues[22] = 115.361;		    this.Timevalues[22] = "09.09.2021";
            this.Closevalues[23] = 114.286;		    this.Timevalues[23] = "10.09.2021";
            this.Closevalues[24] = 116.404;		    this.Timevalues[24] = "13.09.2021";
            this.Closevalues[25] = 116.181;		    this.Timevalues[25] = "14.09.2021";
            this.Closevalues[26] = 115.063;		    this.Timevalues[26] = "15.09.2021";
            this.Closevalues[27] = 113.794;		    this.Timevalues[27] = "16.09.2021";
            this.Closevalues[28] = 111.439;		    this.Timevalues[28] = "17.09.2021";
            this.Closevalues[29] = 108.844;		    this.Timevalues[29] = "20.09.2021";
            this.Closevalues[30] = 110.25;		    this.Timevalues[30] = "21.09.2021";
            this.Closevalues[31] = 112.282;		    this.Timevalues[31] = "22.09.2021";
            this.Closevalues[32] = 114.064;		    this.Timevalues[32] = "23.09.2021";
            this.Closevalues[33] = 113.283;		    this.Timevalues[33] = "24.09.2021";
            this.Closevalues[34] = 113.583;		    this.Timevalues[34] = "27.09.2021";
            this.Closevalues[35] = 110.124;		    this.Timevalues[35] = "28.09.2021";
            this.Closevalues[36] = 111.107;		    this.Timevalues[36] = "29.09.2021";
            this.Closevalues[37] = 110.979;		    this.Timevalues[37] = "30.09.2021";
            this.Closevalues[38] = 112.9;		    this.Timevalues[38] = "01.10.2021";
            this.Closevalues[39] = 110.393;		    this.Timevalues[39] = "04.10.2021";
            this.Closevalues[40] = 110.458;		    this.Timevalues[40] = "05.10.2021";
            this.Closevalues[41] = 110.56;		    this.Timevalues[41] = "06.10.2021";
            this.Closevalues[42] = 110.585;		    this.Timevalues[42] = "07.10.2021";
            this.Closevalues[43] = 112.833;		    this.Timevalues[43] = "08.10.2021";
            this.Closevalues[44] = 112.18;		    this.Timevalues[44] = "11.10.2021";
            this.Closevalues[45] = 113.456;		    this.Timevalues[45] = "13.10.2021";
            this.Closevalues[46] = 113.185;		    this.Timevalues[46] = "14.10.2021";
            this.Closevalues[47] = 114.648;		    this.Timevalues[47] = "15.10.2021";
            this.Closevalues[48] = 114.428;		    this.Timevalues[48] = "18.10.2021";
            this.Closevalues[49] = 110.673;		    this.Timevalues[49] = "19.10.2021"; 

        }
        ~MovingAverage()
        {

        }

        public void CalcularMediaSimples(int[] periodos)
        {
            this.SampleMoveAverage(periodos);

            MostrarResultados(Nm_media.mms);
        }
        public void CalcularMediaExponen(int[] periodos)
        {
            this.ExponeMoveAverage(periodos);

            MostrarResultados(Nm_media.mme);
        }
        public void CalcularCruzSimples(int periodo1, int periodo2)
        {
            int[] mm1 = { periodo1, periodo2 };

            this.SampleMoveAverage(mm1);

            MostrarCruzamento(Nm_media.mms);
        }
        public void CalcularCruzExponen(int periodo1, int periodo2)
        {
            int[] mm1 = { periodo1, periodo2 };

            this.ExponeMoveAverage(mm1);

            MostrarCruzamento(Nm_media.mme);
        }

        private void SampleMoveAverage(int[] periodos)
        {
            periodos[0] = 0;
        }
        private void ExponeMoveAverage(int[] periodos)
        {
            periodos[0] = 0;
        }
        private void MostrarResultados(Nm_media valor)
        {
            Nm_media valor1 = valor;
        }
        private void MostrarCruzamento(Nm_media valor)
        {
            Nm_media valor1 = valor;
        }
    }
}
