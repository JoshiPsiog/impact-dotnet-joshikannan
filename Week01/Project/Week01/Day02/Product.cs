namespace Week01.Day02
{
    public class Product
    {
        #region Fields

        private int _id;
        private string _name = string.Empty;

        #endregion

        #region Properties

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        #endregion

        #region Constructors

        public Product()
        {
        }

        #endregion

        #region Methods

        public void Display()
        {
            Console.WriteLine($"Product Id   : {Id}");
            Console.WriteLine($"Product Name : {Name}");
        }

        #endregion
    }
}