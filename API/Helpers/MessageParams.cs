namespace API.Helpers
{
    public class MessageParams : PaginationParams
    {
        #region Properties
        public string Username { get; set; }

        public string Container { get; set; } = "Unread"; 
        #endregion
    }
}
