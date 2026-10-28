namespace Imc.Models
{
    public static class CalculadoraImc
    {
        public static decimal IndiceDeMasaCorporal(
            decimal peso,
            decimal estatura)
            => peso / (estatura * estatura);

        public static string EstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso bajo";
            }
            if (imc < 25.0m)
            {
                return "Peso normal";
            }
            if (imc < 30.0m)
            {
                return "Sobre peso";
            }
            if (imc < 40m)
            {
                return "Obesidad";
            }
            return "Obesidad extrema";
        }
    }

}