namespace BlazorApp.Shared;
    public class CustomerResponseDto
    {
        public List<Customer> Payload { get; set; }
        public int TotalCount { get; set; }
    }