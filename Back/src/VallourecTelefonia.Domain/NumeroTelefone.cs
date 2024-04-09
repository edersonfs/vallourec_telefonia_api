namespace VallourecTelefonia.Domain
{
    public class NumeroTelefone
    {
        public int id { get; set; }
        public int id_chip_fisico { get; set; }
        public int id_conta { get; set; }
        public int id_plano { get; set; }
        public int id_tipo_acesso { get; set; }
        public int id_categorizacao { get; set; }
        public string? numero { get; set; }
    }
}