namespace Descuentos;

public class DDescuentos
{
    public static double descuento1(int edad, double monto)
    {
        if (monto <= 0)
        {
            return monto; 
        }
        if (edad >= 50)
        {
            return monto * 0.75; 
        }
        else if (edad >= 40)
        {
            return monto * 0.80; 
        }
        else if (edad >= 30)
        {
            return monto * 0.88; 
        }
        else if (edad >= 20)
        {
            return monto * 0.92; 
        }
        else
        {
            return monto;
        }
    }

    public static double descuento2(double monto)
    {

        if (monto >= 2000)
        {
            return monto * 0.75; 
        }
        else if (monto >= 1500)
        {
            return monto * 0.80; 
        }
        else if (monto >= 1000)
        {
            return monto * 0.88; 
        }
        else if (monto >= 500)
        {
            return monto * 0.98; 
        }
        else
        {
            return monto; 
        }
    }
}