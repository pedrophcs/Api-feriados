namespace FeriadosApi.Services
{
    public class FeriadoService
    {
        public DateTime DataPascoa(int ano)
        {
            int a = ano % 19;
            int b = ano / 100;
            int c = ano % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int L = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * L) / 451;
            int mes = (h + L - 7 * m + 114) / 31;
            int dia = ((h + L - 7 * m + 114) % 31) + 1;
            return new DateTime(ano, mes, dia);
        }
        public DateTime DataCarnaval(int ano)
        {
            return DataPascoa(ano).AddDays(-47);
        }
        public DateTime DataCorpusChristi(int ano)
        {
            return DataPascoa(ano).AddDays(60);
        }
        public DateTime DataSextaFeiraSanta(int ano)
        {
            return DataPascoa(ano).AddDays(-2);
        }
    }
}
