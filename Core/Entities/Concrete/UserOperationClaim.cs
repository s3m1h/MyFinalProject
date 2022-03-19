namespace Core.Entities.Concrete
{
    public class UserOperationClaim :IEntity
    {
        // kullanıcının operasyon rolleri
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
