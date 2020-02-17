namespace Demo.Models
{
    public class ErrorDataModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"{this.Code} | {this.Message}";
        }
    }



}
