namespace UserModuleApi.ViewModels
{
    public class UserViewModel
    {
        public int? Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Info { get; set; }
        public int? BirthDate { get; set; }
        public bool IsActive { get; set; }
    }
}