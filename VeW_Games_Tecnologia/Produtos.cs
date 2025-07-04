namespace VeW_Games_Tecnologia
{
    public record Produto(
        int Id,
        string Nome,
        string Descricao,
        string Plataforma,
        string Genero,
        string ClassificacaoEtaria,
        decimal Preco,
        int Estoque,
        bool Ativo,
        string Categoria
    )
    {
        public override string ToString()
            => $"{Id}: {Nome} ({Categoria}) – R$ {Preco:N2}";
    }
}
