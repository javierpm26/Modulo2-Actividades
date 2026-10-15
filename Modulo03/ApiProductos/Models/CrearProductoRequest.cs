using System.ComponentModel.DataAnnotations;

namespace ApiProductos.Models;

public sealed class CrearProductoRequest
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, MinimumLength = 2,
        ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres.")]
    public string Nombre { get; set; } = string.Empty;

    [StringLength(300, ErrorMessage = "La descripción no puede superar los 300 caracteres.")]
    public string? Descripcion { get; set; } = string.Empty;

    [Required(ErrorMessage = "La categoría es obligatoria.")]
    [StringLength(60, MinimumLength = 2,
        ErrorMessage = "La categoría debe tener entre 2 y 60 caracteres.")]
    public string Categoria { get; set; } = string.Empty;

    [Range(0.01, 1000000,
        ErrorMessage = "El precio debe estar entre 0,01 y 1.000.000.")]
    public decimal Precio { get; set; }

    [Range(0, 100000,
        ErrorMessage = "El stock debe estar entre 0 y 100.000.")]
    public int Stock { get; set; }
}
