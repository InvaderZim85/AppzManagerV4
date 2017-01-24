namespace AppzManagerV4.DataObjects
{
    public class GroupModel
    {
        /// <summary>
        /// Gets or sets the id 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the group name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Returns the name of the group
        /// </summary>
        /// <returns>The name of the group</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
