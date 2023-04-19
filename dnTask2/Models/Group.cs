namespace dnTask2.Models
{
    public class Group
    {
        private object value1;
        private object value2;

        public Group()
        {
        }

        public Group(object value1, object value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
