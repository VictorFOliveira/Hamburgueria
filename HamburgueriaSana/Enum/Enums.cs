namespace HamburgueriaSana.Enum
{
    public enum PerfilAcesso
    {
        Caixa = 0,
        Administrador = 1,
        Atendente = 2,
        Cozinha = 3
    }

    public enum ReservaMesa
    {
        Disponivel = 0,
        Ocupada = 1
    }

    public enum StatusPedidos
    {
        EmProdução = 0,
        Concluido = 1
    }

    public enum ContaMesa
    {
        PendentePagamento = 0,
        Pago = 1
    }

    public enum FormaPagamento
    {
        Dinheiro = 0,
        Debito = 1,
        Credito = 2,
        Pix = 3,
        ValeRefeicao = 4
    }

}
