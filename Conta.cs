class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set;}

    public Conta(int codigo)
    {
        Codigo = codigo; 
        Saldo = 0.0; 
    }

    public void Sacar (double valor)
    {

        if (valor <= 0)
        {
            throw new ArgumentException ("Não é possível sacar o valor solicitado."); 
        }

        Saldo = Saldo - valor;
    }

    public void Depositar (double valor)
    {

        if (valor <= 0)
        {
            throw new ArgumentException ("Não é possível depositar o valor solicitado."); 
        }

        Saldo = Saldo + valor; 
    }

    public void Transferir (double valor, Conta conta)
    {
        if (valor <= 0)
        {
            throw new ArgumentException ("Não é possível transferir o valor solicitado."); 
        }

        this.Sacar(valor);
        conta.Depositar(valor); 
    }


}