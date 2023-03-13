namespace ApiForTestWork.DTO
{
    public class ImageDTO
    {
        public int Id { get; set; }

        public int FromId { get; set; }

        public int ToId { get; set; }

        public byte[]? Buffer { get; set; }

        public virtual UserDTO From { get; set; } = null!;

        public virtual UserDTO To { get; set; } = null!;

    }
}
