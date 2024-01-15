namespace Gamification.Repositories.Contracts.PassRepository.GetById
{
    public class GetByIdPassRepositoryGetResponse : RepositoryResponse<GetByIdPassRepositoryGetResponseData>
    {
        public GetByIdPassRepositoryGetResponse(bool success, string message, GetByIdPassRepositoryGetResponseData data)
            : base(success, message, data)
        {
        }
    }
}