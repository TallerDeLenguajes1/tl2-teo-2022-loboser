// See https://aka.ms/new-console-template for more information


public enum TipoDeExtraccion{
    CajeroHumano = 1,
    CajeroAutomatico = 2
}

public class Cuenta {
    private int pesos = 0;
    private int dolares = 0;

    public class CorrienteEnPesos : Cuenta
    {
        public void Insercion(int monto)
        {
            if (monto>0)
            {
                pesos = pesos + monto;
            }
        }

        public void Extraccion(int monto, TipoDeExtraccion tipo)
        {
            if (tipo == TipoDeExtraccion.CajeroAutomatico && pesos-monto<-5000 && monto<=20000 && monto>=1)
            {
                pesos = pesos-monto;
            }else if(tipo == TipoDeExtraccion.CajeroHumano  && pesos-monto<-5000 && monto>=1)
            {
                dolares = dolares-monto;
            }
        }
    }

    public class CorrienteEnDolares : Cuenta
    {
        public void Insercion(int monto)
        {
            if (monto>0)
            {
                dolares = dolares + monto;
            }
        }

        public void Extraccion(int monto, TipoDeExtraccion tipo)
        {
            if (tipo == TipoDeExtraccion.CajeroAutomatico && monto<=200 && monto>=1 && dolares-monto>=0)
            {
                dolares = dolares-monto;
            }else if(tipo == TipoDeExtraccion.CajeroHumano && monto>=1 && dolares-monto>=0)
            {
                dolares = dolares-monto;
            }
        }
    }

    public class AhorroEnPesos : Cuenta
    {
        public void Insercion(int monto)
        {
            if (monto>0)
            {
                pesos = pesos + monto;
            }
        }

        public void Extraccion(int monto, TipoDeExtraccion tipo)
        {
            if (tipo == TipoDeExtraccion.CajeroAutomatico && monto<=200 && monto>=1 && dolares-monto>=0)
            {
                dolares = dolares-monto;
            }else if(tipo == TipoDeExtraccion.CajeroHumano && monto>=1 && dolares-monto>=0)
            {
                dolares = dolares-monto;
            }
        }
    }

}