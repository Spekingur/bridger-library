namespace LibraryApp.Models.EntityModels
{
    /// <summary>
    /// Entity model for a usergroup. Direct mapping to database.
    /// </summary>
    public class Usergroup
    {
        /// <summary>
        /// Id of the usergroup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the usergroup (Admin, normal)
        /// </summary>
        public string Name { get; set; }
    }
}