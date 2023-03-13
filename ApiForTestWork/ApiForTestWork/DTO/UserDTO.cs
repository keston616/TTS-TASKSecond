namespace ApiForTestWork.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string? Login { get; set; }

        public string? Password { get; set; }

        public string? Username { get; set; }

        public virtual ICollection<ImageDTO> ImageFroms { get; } = new List<ImageDTO>();

        public virtual ICollection<ImageDTO> ImageTos { get; } = new List<ImageDTO>();
    }
}
