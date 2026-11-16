namespace TaskFlowApi.Models
{
    public class Tarea
    /* Representar la estructura de una tarea dentro del backend */
    {
        /* Get y Set permite leer y asignar valores a la propiedad */
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        // Inicializa el texto vacio para evitar advertencias de null
        public string Descripcion { get; set; } = string.Empty;
        public bool Completada { get; set; }
    }
}