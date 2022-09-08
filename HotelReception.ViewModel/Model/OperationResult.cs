namespace HotelReception.ViewModel.Model
{
    public class OperationResult<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }
}