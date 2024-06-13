using System.ComponentModel.DataAnnotations.Schema;

namespace PokeCodexBlazor;

public class Pokemon
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("type_1")]
    public string? Type1 { get; set; }
    
    [Column("type_2")]
    public string? Type2 { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("description")]
    public string? Description { get; set; }
    
    [Column("weight")]
    public double Weight { get; set; }
    
    [Column("height")]
    public int Height { get; set; }
    
    [Column("mega_evolves")]
    public char MegaEvolves { get; set; }
    
    [Column("evolves")]
    public int Evolves { get; set; }
    
    [Column("level")]
    public int Level { get; set; }
    
}