namespace TestXamarin.Api.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public string ImageUrl { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }
        public Category Category { get; set; }


        public string ImageFullPath
        {

            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }

                return $"https://castangel-001-site1.etempurl.com{this.ImageUrl.Substring(1)}";

            }

        }
    }
}
